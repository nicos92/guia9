using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesDB;
using System.Data.OleDb;
using Validacion;
using Colores;
using System.Threading;
using VariablesDB;

namespace Guia_9
{
    public partial class FormConsulta : Form
    {

        public FormConsulta()
        {
            InitializeComponent();
        }

        // 1. Usar DataSource con BindingList (mejor rendimiento que List)
        private BindingList<Persona> _personasBindingList;

        // 2. Configuración inicial del DataGridView
        private void ConfigurarDGV()
        {
            // Desactivar características que impactan el rendimiento
            DGV.AutoGenerateColumns = false;
            DGV.RowHeadersVisible = false;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToOrderColumns = false;
            DGV.ReadOnly = true;
            DGV.MultiSelect = false;

            // Limpiar columnas existentes
            DGV.Columns.Clear();

            // Agregar solo las columnas necesarias
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                DataPropertyName = "Id",
                HeaderText = "Id",
                Width = 50
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colLegajo",
                DataPropertyName = "Legajo",
                HeaderText = "Legajo",
                Width = 50
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDni",
                DataPropertyName = "DNI",
                HeaderText = "DNI",
                Width = 100
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colApellido",
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colNombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 150
            });

            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTelefono",
                DataPropertyName = "Telefono",
                HeaderText = "Telefono",
                Width = 80
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTelefono2",
                DataPropertyName = "Telefono2",
                HeaderText = "Telefono2",
                Width = 80
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDireccion",
                DataPropertyName = "Direccion",
                HeaderText = "Direccion",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colMensualQuincenal",
                DataPropertyName = "MensualQuincenal",
                HeaderText = "Mensual - Quincenal",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBaja",
                DataPropertyName = "Baja",
                HeaderText = "Baja",
                Width = 50
            });
        }

        // 3. Cargar datos de forma eficiente
        private void CargarDatos(List<Persona> datosCompletos)
        {
            // Usar VirtualMode para grandes conjuntos de datos
            DGV.VirtualMode = true;

            // Configurar el tamaño del buffer
            _personasBindingList = new BindingList<Persona>(datosCompletos);

            // Asignar el origen de datos
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _personasBindingList;
            DGV.DataSource = bindingSource;

            // Opcional: Paginación para mejor rendimiento
            ConfigurarPaginas(bindingSource);
        }

        // 4. Implementar paginación (opcional pero recomendado)
        private void ConfigurarPaginas(BindingSource bindingSource)
        {
            // Ejemplo básico de paginación
            int pageSize = 100;
            int currentPage = 0;

            bindingSource.DataSource = _personasBindingList
                .Skip(currentPage * pageSize)
                .Take(pageSize)
                .ToList();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            //ObtenerPersonas();
        }

        private void ObtenerPersonas()
        {
            OleDbDataReader lector = null;
            try
            {
                AccesoDB.ConectarDB();
                string consulta = "SELECT * FROM personas;";
                lector = AccesoDB.LecturaDB(consulta);
                List<Persona> personas = new List<Persona>();
                while (lector.Read())
                {
                    string mensual = Convert.ToBoolean(lector[8]) ? "Mensual" : "Quincenal";
                    string baja = Convert.ToBoolean(lector[9]) ? "Si" : "No";
                    Persona lapersona = new Persona()
                    {
                        Id = Convert.ToInt32(lector[0]),
                        Legajo = Convert.ToInt32(lector[1]),
                        Dni = Convert.ToInt32(lector[2]),
                        Apellido = lector[3].ToString(),
                        Nombre = lector[4].ToString(),
                        Telefono = lector[5].ToString(),
                        Direccion = lector[6].ToString(),
                        Telefono2 = lector[7].ToString(),
                        MensualQuincenal = mensual,
                        Baja = baja
                    };
                    personas.Add(lapersona);
                }
                CargarDatos(personas);
            }
            catch
            {
                MessageBox.Show("Error al Abrir la base de datos");
            }
            finally
            {
                lector.Close();
                AccesoDB.CerrarDB();
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);
            Validaciones.Borrar(ref e);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnBuscar.Enabled = false;
            Progres.Visible = true;
            BackWork.RunWorkerAsync();

        }

        private void BuscarPorDni()
        {
            OleDbDataReader lector = null;
            try
            {
                string dni = TxtDni.Text;
                AccesoDB.ConectarDB();
                string consulta = $"SELECT * FROM personas WHERE dni LIKE '{dni}%';";
                lector = AccesoDB.LecturaDB(consulta);
                List<Persona> personas = new List<Persona>();
                while (lector.Read())
                {
                    string mensual = Convert.ToBoolean(lector[8]) ? "Mensual" : "Quincenal";
                    string baja = Convert.ToBoolean(lector[9]) ? "Si" : "No";

                    Persona lapersona = new Persona()
                    {
                        Id = Convert.ToInt32(lector[0]),
                        Legajo = Convert.ToInt32(lector[1]),
                        Dni = Convert.ToInt32(lector[2]),
                        Apellido = lector[3].ToString(),
                        Nombre = lector[4].ToString(),
                        Telefono = lector[5].ToString(),
                        Direccion = lector[6].ToString(),
                        Telefono2 = lector[7].ToString(),
                        MensualQuincenal = mensual,
                        Baja = baja
                    };
                    personas.Add(lapersona);
                }
                CargarDatos(personas);
            }
            catch
            {
                MessageBox.Show("Error al Abrir la base de datos");
            }
            finally
            {
                lector.Close();
                AccesoDB.CerrarDB();
            }
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            if (TxtDni.Text.Length > 0)
            {
                BtnBuscar.Enabled = true;
            }
            else
            {
                BtnBuscar.Enabled = false;
            }
        }

        private void BtnBuscar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnBuscar.Enabled)
            {
                BtnBuscar.ForeColor = MaterialColors.Blue500;
                BtnBuscar.FlatAppearance.BorderColor = MaterialColors.Blue500;
                BtnBuscar.BackColor = Color.White; ;
            }
            else
            {
                BtnBuscar.ForeColor = MaterialColors.Grey500;
                BtnBuscar.FlatAppearance.BorderColor = MaterialColors.Grey500;
                BtnBuscar.BackColor = MaterialColors.Grey50;
            }
        }

        private void BackWork_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
                worker.ReportProgress(i);
            }
        }

        private void BackWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progres.Value = e.ProgressPercentage;
        }

        private void BackWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            BuscarPorDni();
            BtnBuscar.Enabled = true;
            Progres.Visible = false;

         
        }

        private void FormConsulta_Activated(object sender, EventArgs e)
        {
            ObtenerPersonas();

        }
    }
}
