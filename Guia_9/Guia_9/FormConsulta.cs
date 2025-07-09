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
        private bool btntodosconsul = false;
        private bool ascdesc = false;
        private const string CONSULTA = "SELECT Id, legajo, dni, apellido, nombres, telefono, direccion, telefono2, mensualquincenal, baja FROM personas ";
        private string _consulta = "";


        public FormConsulta()
        {
            InitializeComponent();
            _primeravez = 0;
        }


        private BindingList<Persona> _personasBindingList;
        private int _primeravez;


        private void ConfigurarDGV()
        {




            DGV.Columns.Clear();


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
                Name = "colNombres",
                DataPropertyName = "nombres",
                HeaderText = "NOMBRES",
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


        private void CargarDatos(List<Persona> datosCompletos)
        {




            _personasBindingList = new BindingList<Persona>(datosCompletos);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _personasBindingList;
            //DGV.DataSource = bindingSource;
            DGV.DataSource = _personasBindingList;
           


        }




        private void FormConsulta_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            EP.SetError(TxtDni, "Para buscar por dni al menos ingrese un numero");
        }

        private void ObtenerPersonas()
        {
            OleDbDataReader lector = null;
            try
            {
                AccesoDB.ConectarDB();
                lector = AccesoDB.LecturaDB(_consulta);
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
                        Nombres = lector[4].ToString(),
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
            catch (OleDbException ez)
            {
                MessageBox.Show("Error al consultar: \n" + ez.Message, "Error base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lector.Close();
                AccesoDB.CerrarDB();
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validaciones.Numeros(ref e);
            Validaciones.LetrasNumeros(ref e);
            Validaciones.Borrar(ref e);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            btntodosconsul = false;
            DesactivarBotones(false);

            BackWorker.RunWorkerAsync(sender);

        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

            if (TxtDni.Text.Length > 0)
            {
                EP.Clear();
            }
            else
            {
                EP.SetError(TxtDni, "Para obtener una mejor busqueda por dni, apellido ó nombre ingrese una letra o un número");

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
            Button btn = e.Argument as Button;
            if (btn.Tag.ToString() == "0")
            {
                _consulta = CONSULTA;
            }
            if (btn.Tag.ToString() == "1")
            {
                _consulta = CONSULTA + $" WHERE (dni LIKE '{TxtDni.Text}%' OR apellido LIKE '{TxtDni.Text}%' OR nombres LIKE '{TxtDni.Text}%') AND baja = False;";
            }

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
            //string consulta = $"SELECT * FROM personas WHERE dni LIKE '{dni}%';";
            //BuscarPorDni();
            ObtenerPersonas();
            DesactivarEditElim();
            DesactivarBotones(true);
            DesacBtn();
            TxtDni.Focus();


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
            if (Properties.Settings.Default.actconsultas)
            {
                Properties.Settings.Default.actconsultas = false;
                Properties.Settings.Default.Save();
                DesactivarBotones(false);
                BackWorker.RunWorkerAsync(BtnBuscar);
                //ObtenerPersonas(CONSULTA);
                DesactivarEditElim();
            }


        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            btntodosconsul = true;
            DesactivarBotones(false);
            BackWorker.RunWorkerAsync(sender);
            //ObtenerPersonas(CONSULTA);
            //DesactivarEditElim();
        }
        private void DesactivarBotones(bool bol)
        {
            BtnBuscar.Enabled = bol;
            BtnVerTodos.Enabled = bol;
            BtnEditar.Enabled = bol;
            BtnEliminar.Enabled = bol;
            Progres.Visible = !bol;
            PanelBajo.Enabled = bol;
            PanelTop.Enabled = bol;

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
                Nombres = datos[4].Value.ToString(),
                Telefono = datos[5].Value.ToString(),
                Telefono2 = datos[6].Value.ToString(),
                Direccion = datos[7].Value.ToString(),
                MensualQuincenal = datos[8].Value.ToString(),
                Baja = datos[9].Value.ToString()

            };

            FormEdicion fm = new FormEdicion(persona, BtnVerTodos);
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
                if (ascdesc)
                {

                    BtnVerTodos.PerformClick();
                }
                else
                {
                    BtnBuscar.PerformClick();
                }
            }
        }

        private void ElimarResgistro(string id)
        {
            try
            {
                AccesoDB.ConectarDB();
                //string consulta = $"UPDATE personas SET fecha_eliminacion = Now() WHERE id = {id};";
                string consulta = $"DELETE FROM personas WHERE id = {id}";
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

        private void DGV_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = DGV.Columns[e.ColumnIndex];
            string nomcol = columna.DataPropertyName;
            OrdenarLista(nomcol);

        }

        private void OrdenarLista(string columna)
        {
            if (btntodosconsul)
            {
                if (ascdesc)
                {
                    _consulta = CONSULTA + " ORDER BY " + columna + " ASC";

                }
                else
                {
                    _consulta = CONSULTA + " ORDER BY " + columna + " DESC";

                }
            }
            else
            {
                if (ascdesc)
                {
                    _consulta = CONSULTA + " WHERE baja = False ORDER BY " + columna + " ASC";

                }
                else
                {
                    _consulta = CONSULTA + " WHERE baja = False ORDER BY " + columna + " DESC";

                }
            }

            ascdesc = !ascdesc;


            ObtenerPersonas();

        }

        private void DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DGV.Rows.Count > 0)
            {
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

        private void DesacBtn()
        {
            if (DGV.Rows.Count > 0)
            {
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }

       
    }
}
