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
        private Persona _persona;
        private Button _form;
        private bool _edicion = false;
        public FormEdicion()
        {
            InitializeComponent();
        }
        public FormEdicion(Persona persona, Control parent)
        {
            InitializeComponent();
            _persona = persona;
            _form = parent as Button;
            _myWorker = new BackWork(Progres, Edicion);
        }

        private void FormModifica_Load(object sender, EventArgs e)
        {
            LblId.Text = "Id: " + _persona.Id.ToString();
            LblLegajo.Text = "Legajo: " + _persona.Legajo.ToString();
            TxtNombre.Text = _persona.Nombre;
            TxtApellido.Text = _persona.Apellido;
            TxtDni.Text = _persona.Dni.ToString();
            TxtDireccion.Text = _persona.Direccion;
            TxtTelefono.Text = _persona.Telefono;
            TxtTelefono2.Text = _persona.Telefono2;
            if (_persona.MensualQuincenal.StartsWith("M"))
            {
                RBtnMensual.Checked = true;
                RBtnQuincenal.Checked = false;
            }
            else
            {
                RBtnMensual.Checked = false;
                RBtnQuincenal.Checked = true;
            }
            ChBBaja.Checked = _persona.Baja.StartsWith("S") ? true : false;
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
                string consulta = $"UPDATE personas SET legajo = {_persona.Legajo}, dni = {TxtDni.Text}, apellido = '{TxtApellido.Text}', nombres = '{TxtNombre.Text}', telefono = '{TxtTelefono.Text}', direccion = '{TxtDireccion.Text}', telefono2 = '{TxtTelefono2.Text}', mensualquincenal = {RBtnMensual.Checked}, baja = {ChBBaja.Checked}, fecha_modificacion = Now() WHERE id = {_persona.Id} ;";


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
                string error = ex.Message.Contains("valores duplicados") ? "DNI duplicado" : ex.Message;
                MessageBox.Show(error, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            bool nom, ape, dni, tel, tel2, dire;
            
            HabilitarBtn(out nom, out ape, out dni, out tel, out tel2, out dire);
            Util.SacarDobleEspacio(txt);
            RevisionIngreso(nom, ape, dni, tel, tel2, dire);
        }

        private void HabilitarBtn(out bool nom, out bool ape, out bool dni, out bool tel, out bool tel2, out bool dire)
        {
            nom = TxtNombre.Text.Length > 2;
            ape = TxtApellido.Text.Length > 2;
            dni = TxtDni.Text.Length == 8;
            tel = TxtTelefono.Text.Length > 7;
            tel2 = TxtTelefono2.Text.Length > 7;
            dire = TxtDireccion.Text.Length > 3;
            BtnEditar.Enabled = nom && ape && dni && tel && tel2 && dire;
        }
        private void RevisionIngreso(bool nom, bool ape, bool dni, bool tel, bool tel2, bool dire)
        {
            Ep.Clear();
            if (!nom)
            {
                Ep.SetError(TxtNombre, "El nombre debe tener mas de tres caracteres");
            }
            if (!ape)
            {
                Ep.SetError(TxtApellido, "El apellido debe tener mas de tres caracteres");

            }
            if (!dni)
            {
                Ep.SetError(TxtDni, "El dni debe tener 8 numeros");

            }
            if (!tel)
            {
                Ep.SetError(TxtTelefono, "El telefono debe tener 8 o mas caracteres");

            }
            if (!tel2)
            {
                Ep.SetError(TxtTelefono2, "El telefono 2 debe tener 8 o mas caracteres");

            }
            if (!dire)
            {
                Ep.SetError(TxtDireccion, "La direccion debe tener 4 o mas caracteres");

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
    }
}
