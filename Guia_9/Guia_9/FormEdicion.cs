using FuncionesDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validacion;

namespace Guia_9
{
    public partial class FormEdicion : Form
    {
        private BackWork _myWorker;
        private Electrodomestico _electro;
        private Button _form;
        private bool _edicion = false;
        private Electrodomestico electro;
        private Button btnVerTodos;

        public FormEdicion()
        {
            InitializeComponent();
        }
        public FormEdicion(Electrodomestico electro, Control parent)
        {
            InitializeComponent();
            _electro = electro;
            _form = parent as Button;
            _myWorker = new BackWork(Progres, Edicion);
        }

       

        private void FormModifica_Load(object sender, EventArgs e)
        {
            LblId.Text = "Id: " + _electro.Id.ToString();
            LblLegajo.Text = "Codigo: " + _electro.Articulo_Codigo.ToString();
            TxtTipo.Text = _electro.Articulo_Tipo;
            TxtMarca.Text = _electro.Articulo_Marca;
            TxtModelo.Text = _electro.Articulo_Modelo.ToString();
            TxtCarac.Text = _electro.Articulo_Caracteristicas;
            TxtStock.Text = _electro.Articulo_Cantidad_Stock.ToString();
            TxtPrecio.Text = _electro.Articulo_Precio.ToString();
            TxtTipo.Focus();
            TxtTipo.SelectAll();
            
        }
      
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // todo si el boton esta deshabilitado al pasar el mouse por encima  mostrar carlet de verificacion
            Progres.Visible = true;
            this.Enabled = false;
            _myWorker.RunWorkerAsync();
         

        }

        private void Edicion()
        {
            try
            {
                string consulta = $"UPDATE Electrodomesticos SET  Articulo_Modelo = '{TxtModelo.Text}', Articulo_Marca = '{TxtMarca.Text.ToLower()}', Articulo_Tipo = '{TxtTipo.Text.ToLower()}', Articulo_Cantidad_stock = {TxtStock.Text}, Articulo_Caracteristicas = '{TxtCarac.Text.ToLower()}', Articulo_Precio = {TxtPrecio.Text}  WHERE id = {_electro.Id} ;";


                AccesoDB.ConectarDB();
                int res = AccesoDB.DBExecuteNonQuery(consulta);

                if (res > 0)
                {
                    MessageBox.Show("Edicion Correcta", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccesoDB.CerrarDB();
                }

            }
            catch (OleDbException ex)
            {
               
                MessageBox.Show(ex.Message, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _edicion = true;
            BtnEditar.Enabled = true;
            this.Enabled = true;

        }

        private void FormModifica_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_edicion)
            {

            _form.PerformClick();
            }
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
            stock = TxtStock.Text.Length > 0;
            precio = TxtPrecio.Text.Length > 0;
            carac = TxtCarac.Text.Length > 2;
            BtnEditar.Enabled = tipo && marca && modelo && stock && precio && carac;
        }
        private void RevisionIngreso(bool tipo, bool marca, bool modelo, bool stock, bool precio, bool carac)
        {
            Ep.Clear();
            if (!tipo)
            {
                Ep.SetError(TxtTipo, "El nombre debe tener mas de tres caracteres");
            }
            if (!marca)
            {
                Ep.SetError(TxtMarca, "El apellido debe tener mas de tres caracteres");

            }
            if (!modelo)
            {
                Ep.SetError(TxtModelo, "El dni debe tener 8 numeros");

            }
            if (!stock)
            {
                Ep.SetError(TxtStock, "El telefono debe tener 8 o mas caracteres");

            }
            if (!precio)
            {
                Ep.SetError(TxtPrecio, "El telefono 2 debe tener 8 o mas caracteres");

            }
            if (!carac)
            {
                Ep.SetError(TxtCarac, "La direccion debe tener 4 o mas caracteres");

            }
        }

        private void TxtLetas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(ref e);
            Validaciones.EspaciosBorrar(ref e);
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);
            Validaciones.Borrar(ref e);
        }
        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.LetrasNumeros(ref e);
            Validaciones.EspaciosBorrar(ref e);
            //Validaciones.EspPrincipio(ref e, TxtDireccion.Text);
        }

        private void BtnEditar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnEditar.Enabled)
            {
                ToolTip.SetToolTip(BtnEditar, "Haga click para confirmar la edicion");
                
                BtnEditar.BackColor = Colores.PaletaColores.Yellow500;

            }
            else
            {
                BtnEditar.BackColor = Colores.PaletaColores.Grey200;
            }
        }

        private void BtnEditar_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void FormEdicion_Activated(object sender, EventArgs e)
        {
            TxtTipo.Focus();
        }
    }
}
