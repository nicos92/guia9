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
        private const string CONSULTA = "SELECT Id, Articulo_Codigo,Articulo_Tipo, Articulo_Marca,Articulo_Modelo,Articulo_Caracteristicas,Articulo_Cantidad_stock, Articulo_Precio, Articulo_Ingreso FROM Electrodomesticos ";
        private string _consulta = "";


        public FormConsulta()
        {
            InitializeComponent();
          
        }


        private BindingList<Electrodomestico> _electrosBindingList;
 


       


        private void CargarDatos(List<Electrodomestico> datosCompletos)
        {




            _electrosBindingList = new BindingList<Electrodomestico>(datosCompletos);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _electrosBindingList;
            //DGV.DataSource = bindingSource;
            DGV.DataSource = _electrosBindingList;
           


        }




        private void FormConsulta_Load(object sender, EventArgs e)
        {
            //ConfigurarDGV();
            EP.SetError(TxtBusqueda, "Para tener una mejor busqueda al menos ingrese un numero o letra");
        }

        private void ObtenerPersonas()
        {
            OleDbDataReader lector = null;
            try
            {
                AccesoDB.ConectarDB();
                lector = AccesoDB.LecturaDB(_consulta);
                List<Electrodomestico> electros = new List<Electrodomestico>();
                while (lector.Read())
                {
                   
                    Electrodomestico electro = new Electrodomestico()
                    {
                        Id = Convert.ToInt32(lector[0]),
                        Articulo_Codigo = lector[1].ToString(),
                        Articulo_Tipo = lector[2].ToString(),
                        Articulo_Marca = lector[3].ToString(),
                        Articulo_Modelo = lector[4].ToString(),
                        Articulo_Caracteristicas = lector[5].ToString(),
                        Articulo_Cantidad_Stock =Convert.ToInt32( lector[6]),
                        Articulo_Precio = Convert.ToInt32(lector[7]),
                        Articulo_Ingreso = lector[8].ToString()
                    };
                    electros.Add(electro);
                }
                CargarDatos(electros);
                

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

            if (TxtBusqueda.Text.Length > 0)
            {
                EP.Clear();
            }
            else
            {
                EP.SetError(TxtBusqueda, "Para obtener una mejor busqueda por dni, apellido ó nombre ingrese una letra o un número");

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
            string stock = CHstock.Checked ? " AND Articulo_Cantidad_Stock > 0 " : "  ";
            if (btn.Tag.ToString() == "0")
            {
                _consulta = CONSULTA + " ORDER BY Id DESC;";
            }
            if (btn.Tag.ToString() == "1")
            {
                // _consulta = CONSULTA + $" WHERE (dni LIKE '{TxtDni.Text}%' OR apellido LIKE '{TxtDni.Text}%' OR nombres LIKE '{TxtDni.Text}%') AND baja = False;";
                _consulta = CONSULTA + $" WHERE (Articulo_Codigo LIKE '{TxtBusqueda.Text}%' OR Articulo_Tipo LIKE '{TxtBusqueda.Text}%' OR Articulo_Marca LIKE '{TxtBusqueda.Text}%' OR Articulo_Modelo LIKE '{TxtBusqueda.Text}%' ) {stock} ORDER BY Id DESC";
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

            string dni = TxtBusqueda.Text;
            //string consulta = $"SELECT * FROM personas WHERE dni LIKE '{dni}%';";
            //BuscarPorDni();
            ObtenerPersonas();
            DesactivarEditElim();
            DesactivarBotones(true);
            DesacBtn();
            TxtBusqueda.Focus();


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
            Electrodomestico electro = new Electrodomestico()
            {
                Id = Convert.ToInt32(datos[0].Value),
                Articulo_Codigo = datos[1].Value.ToString(),
                Articulo_Tipo = datos[2].Value.ToString(),
                Articulo_Marca = datos[3].Value.ToString(),
                Articulo_Modelo = datos[4].Value.ToString(),
                Articulo_Caracteristicas = datos[5].Value.ToString(),
                Articulo_Cantidad_Stock = Convert.ToInt32(datos[6].Value),
                Articulo_Precio = Convert.ToInt32(datos[7].Value),
               
            };

            FormEdicion fm = new FormEdicion(electro, BtnVerTodos);
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

            string msj = $"Codigo: {legajo}\nTipo: {dni}\nMarca: {apellido}\nModelo: {nombre}";
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
                string consulta = $"DELETE FROM Electrodomesticos WHERE Id = {id}";
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
                    _consulta = CONSULTA + " WHERE Articulo_Cantidad_Stock > 0 ORDER BY " + columna + " ASC";

                }
                else
                {
                    _consulta = CONSULTA + " WHERE Articulo_Cantidad_Stock > 0  ORDER BY " + columna + " DESC";

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
