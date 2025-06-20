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
        private void ConfigureGridView()
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
                HeaderText = "MensualQuincenal",
                Width = 150
            });
            DGV.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBaja",
                DataPropertyName = "Baja",
                HeaderText = "Baja",
                Width = 150
            });
        }

        // 3. Cargar datos de forma eficiente
        private void LoadLargeData(List<Persona> datosCompletos)
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
            ConfigurePagination(bindingSource);
        }

        // 4. Implementar paginación (opcional pero recomendado)
        private void ConfigurePagination(BindingSource bindingSource)
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
            ConfigureGridView();
            OleDbDataReader lector = null;
            try
            {
                AccesoDB.ConectarDB();
                MessageBox.Show("Conexion Exitosa con la base de datos");
                string consulta = "SELECT * FROM personas WHERE baja = false;";
                lector = AccesoDB.LecturaDB(consulta);
                List<Persona> personas = new List<Persona>();
                while (lector.Read())
                {
                    string mensual = Convert.ToBoolean(lector[8]) ? "Mensual" : "Quincenal";
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
                        Baja = Convert.ToBoolean(lector[9])
                    };
                    personas.Add(lapersona);
                }

                
                lector.Close();
                AccesoDB.CerrarDB();
                LoadLargeData(personas);
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
    }
}
