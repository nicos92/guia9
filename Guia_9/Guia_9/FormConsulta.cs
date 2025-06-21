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
                HeaderText = "ID",
                Width = 50
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colLegajo",
                DataPropertyName = "Legajo",
                HeaderText = "LEGAJO",
                Width = 60
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
                HeaderText = "APELLIDO",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colNombre",
                DataPropertyName = "Nombre",
                HeaderText = "NOMBRE",
                Width = 150
            });

            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTelefono",
                DataPropertyName = "Telefono",
                HeaderText = "TELEFONO",
                Width = 90
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTelefono2",
                DataPropertyName = "Telefono2",
                HeaderText = "TELEFONO 2",
                Width = 90
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDireccion",
                DataPropertyName = "Direccion",
                HeaderText = "DIRECCION",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colMensualQuincenal",
                DataPropertyName = "MensualQuincenal",
                HeaderText = "MENSUAL - QUINCENAL",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBaja",
                DataPropertyName = "Baja",
                HeaderText = "BAJA",
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
            EP.SetError(TxtDni, "Para buscar por dni ingrese un numero");
        }

        private void ObtenerPersonas(string consulta)
        {
            OleDbDataReader lector = null;
            try
            {
                AccesoDB.ConectarDB();
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

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

            if (TxtDni.Text.Length > 0)
            {
                BtnBuscar.Enabled = true;
                EP.Clear();
            }
            else
            {
                BtnBuscar.Enabled = false;
                EP.SetError(TxtDni, "Para buscar por dni ingrese un numero");

            }
        }

        private void BtnBuscar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnBuscar.Enabled)
            {
                BtnBuscar.ForeColor = PaletaColores.Blue50;
                BtnBuscar.BackColor = PaletaColores.Blue450;
            }
            else
            {
                BtnBuscar.ForeColor = PaletaColores.Grey500;
                BtnBuscar.BackColor = PaletaColores.Grey50;
            }
        }

        private void BackWork_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
                worker.ReportProgress(i);
            }
        }

        private void BackWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progres.Value = e.ProgressPercentage;
        }

        private void BackWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string dni = TxtDni.Text;
            string consulta = $"SELECT * FROM personas WHERE dni LIKE '{dni}%';";
            //BuscarPorDni();
            ObtenerPersonas(consulta);
            DesactivarEditElim();
            BtnBuscar.Enabled = true;
            Progres.Visible = false;


        }

        private void DesactivarEditElim()
        {
            if (DGV.Rows.Count > 0)
            {
                BtnEliminar.Enabled = true;
                BtnEditar.Enabled = true;
            }
            else
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
            }
        }

        private void FormConsulta_Activated(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM personas;";

            ObtenerPersonas(consulta);
            DesactivarEditElim();

        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM personas;";
            ObtenerPersonas(consulta);
            DesactivarEditElim();

        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection datos = DGV.CurrentRow.Cells;
            Persona persona = new Persona()
            {
                Id = Convert.ToInt32(datos[0].Value),
                Legajo = Convert.ToInt32(datos[1].Value),
                Dni = Convert.ToInt32(datos[2].Value),
                Apellido = datos[3].Value.ToString(),
                Nombre = datos[4].Value.ToString(),
                Telefono = datos[5].Value.ToString(),
                Telefono2 = datos[6].Value.ToString(),
                Direccion = datos[7].Value.ToString(),
                MensualQuincenal = datos[8].Value.ToString(),
                Baja = datos[9].Value.ToString()

            };
            
            FormModifica fm = new FormModifica(persona,BtnVerTodos);
            fm.ShowDialog();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection datos = DGV.CurrentRow.Cells;
            string id = datos[0].Value.ToString();
            string legajo = datos[1].Value.ToString();
            string dni = datos[2].Value.ToString();

            string apellido = datos[3].Value.ToString();
            string nombre = datos[4].Value.ToString();

            string msj = $"Legajo: {legajo}\nDNI: {dni}\nApellido: {apellido}\nNombre: {nombre}";
            DialogResult dr = MessageBox.Show("Estas seguro que quieres eliminar el registro?\n" + msj, "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ElimarResgistro(id);
                OnActivated(null);
            }
        }

        private void ElimarResgistro(string id)
        {

            try
            {
                AccesoDB.ConectarDB();

                string consulta = $"DELETE FROM personas WHERE id = {id};";

                int res = AccesoDB.DBExecuteNonQuery(consulta);

                if (res > 0)
                {
                    MessageBox.Show("Eliminacion Correcta", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Error en base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AccesoDB.CerrarDB();
            }
        }
    }
}
