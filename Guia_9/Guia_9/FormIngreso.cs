using Colores;
using FuncionesDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validacion;
using VariablesDB;

namespace Guia_9
{
    public partial class FormIngreso : Form
    {
        private BackWork _myWork;
        private string _codigo;
        public FormIngreso()
        {
            InitializeComponent();
            _myWork = new BackWork(Progres, InsertarPersona);
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);
            Validaciones.Borrar(ref e);
        }

        private void TxtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(ref e);
            Validaciones.EspaciosBorrar(ref e);
            Validaciones.Borrar(ref e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.LetrasNumeros(ref e);
            Validaciones.EspaciosBorrar(ref e);
            //Validaciones.EspPrincipio(ref e, TxtDireccion.Text);
        }



       

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            bool tipo, marca, modelo, stock, precio, carac;
            
            HabilitarBtn(out tipo, out marca, out modelo, out stock, out precio, out carac);
            Util.SacarDobleEspacio(txt);
            RevisionIngreso(tipo, marca, modelo, stock, precio, carac);
        }

        private void HabilitarBtn(out bool tipo, out bool marca, out bool modelo, out bool stock, out bool precio, out bool carac)
        {
            tipo = TxtTipo.Text.Length > 2;
            marca = TxtMarca.Text.Length > 2;
            modelo = TxtModelo.Text.Length > 2;
            stock = Txtstock.Text.Length > 0;
            precio = TxtPrecio.Text.Length > 0;
            carac = TxtCarac.Text.Length > 2;
            BtnIngresar.Enabled = tipo && marca && modelo && stock && precio && carac;
        }

        private void RevisionIngreso(bool tipo, bool marca, bool modelo, bool stock, bool precio, bool carac)
        {
            Ep.Clear();
            if (!tipo)
            {
                Ep.SetError(TxtTipo, "El tipo debe tener mas de dos caracteres");
            }
            if (!marca)
            {
                Ep.SetError(TxtMarca, "El marca debe tener mas de dos caracteres");

            }
            if (!modelo)
            {
                Ep.SetError(TxtModelo, "El modelo debe tener mas de dos caracteres");

            }
            if (!stock)
            {
                Ep.SetError(Txtstock, "El stock no puede estar vacio");

            }
            if (!precio)
            {
                Ep.SetError(TxtPrecio, "El precio no puede estar vacio");

            }
            if (!carac)
            {
                Ep.SetError(TxtCarac, "La caracteristica debe tener mas de dos caracteres");

            }
        }

        private void BtnIngresar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnIngresar.Enabled)
            {
                BtnIngresar.ForeColor = PaletaColores.Blue50;
                BtnIngresar.FlatAppearance.BorderColor = PaletaColores.Blue50;
                BtnIngresar.BackColor = PaletaColores.Blue500;
            }
            else
            {
                BtnIngresar.FlatAppearance.BorderColor = PaletaColores.Grey50;
                BtnIngresar.BackColor = PaletaColores.Grey300;
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            HabilitarBtns(false);
            BtnIngresar.Enabled = false;

            _myWork.RunWorkerAsync();
        }

        private void HabilitarBtns(bool bol)
        {
            Progres.Visible = !bol;
            PanelPrincipal.Enabled = bol;
            PanelBajo.Enabled = bol;
        }

        private void InsertarPersona()
        {
           
         
            try
            {
                string dni = TxtModelo.Text;
                
           

                string fecha = DateTime.Now.ToLongDateString();
                AccesoDB.ConectarDB();

                string consulta = $"INSERT INTO Electrodomesticos (Articulo_Codigo, Articulo_Tipo, Articulo_Marca, Articulo_Modelo, Articulo_Caracteristicas, Articulo_Cantidad_Stock, Articulo_Precio, Articulo_Ingreso) VALUES ('{_codigo}', '{TxtTipo.Text.ToLower()}', '{TxtMarca.Text.ToLower()}','{TxtModelo.Text.ToLower()}','{TxtCarac.Text.ToLower()}',{Txtstock.Text},{TxtPrecio.Text}, '{fecha}' );";
               

                int res = AccesoDB.DBExecuteNonQuery(consulta);

                if (res > 0)
                {
                    MessageBox.Show($"Ingreso Correcto:\nCódigo: {_codigo}\nTipo: {TxtTipo.Text}\nMarca: {TxtMarca.Text}\nModelo: {TxtModelo.Text} ", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                    Properties.Settings.Default.actconsultas = true;
                    Properties.Settings.Default.Save();
                }

            }
            catch (OleDbException ex)
            {
                string error = ex.Message.Contains("valores duplicados") ? "DNI duplicado" : ex.Message;
                MessageBox.Show(error, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                AccesoDB.CerrarDB();
                Progres.Visible = false;

            HabilitarBtns(true);

                TxtTipo.Focus();
            }
            ObtenerNuevoCodigo();
        }

        private void LimpiarForm()
        {
            foreach (var item in TLPForm.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }
        }

        private void ObtenerNuevoCodigo()
        {
            OleDbDataReader lector = null;
            int legajo = 0;

            try
            {
                string dni = TxtModelo.Text;
                AccesoDB.ConectarDB();
                string consulta = $"SELECT Articulo_Codigo FROM Electrodomesticos where id = (select max(id) from electrodomesticos)";
                lector = AccesoDB.LecturaDB(consulta);
                while (lector.Read())
                {
                    legajo = lector[0] == DBNull.Value ? 1 : Convert.ToInt32(lector[0]) + 1;
                }
                lector.Close();
                AccesoDB.CerrarDB();
                _codigo = legajo.ToString("0000");
                LblCodigo.Text = _codigo;
                

            }
            catch (OleDbException ex)
            {
                string error = ex.Message.Contains("valores duplicados") ? "DNI duplicado" : ex.Message;
                MessageBox.Show(error, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormIngreso_Activated(object sender, EventArgs e)
        {
            ObtenerNuevoCodigo();
            TxtTipo.Focus();
        }
    }
}
