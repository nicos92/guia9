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
            BtnIngresar.Enabled = nom && ape && dni && tel && tel2 && dire;
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
            OleDbDataReader lector = null;
            int legajo = 0;
            bool menquin = RBtnMensual.Checked ? true : false;
            try
            {
                string dni = TxtDni.Text;
                AccesoDB.ConectarDB();
                string consulta = $"SELECT MAX(legajo) FROM personas;";
                lector = AccesoDB.LecturaDB(consulta);
                while (lector.Read())
                {
                    legajo = lector[0] == DBNull.Value ? 1 : Convert.ToInt32(lector[0]) + 1;
                }
                lector.Close();
                AccesoDB.CerrarDB();



                AccesoDB.ConectarDB();

                consulta = $"INSERT INTO personas (legajo, dni, apellido, nombres, telefono, direccion, telefono2, mensualquincenal, baja) VALUES ({legajo},{TxtDni.Text},'{TxtApellido.Text.ToLower()}','{TxtNombre.Text.ToLower()}','{TxtTelefono.Text}','{TxtDireccion.Text.ToLower()}','{TxtTelefono2.Text}', {menquin}, {false});";


                int res = AccesoDB.DBExecuteNonQuery(consulta);

                if (res > 0)
                {
                    MessageBox.Show("Ingreso Correcto", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                }

            }
            catch (OleDbException ex)
            {
                string error = ex.Message.Contains("valores duplicados") ? "DNI duplicado" : ex.Message;
                MessageBox.Show(error, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lector.Close();
                AccesoDB.CerrarDB();
                Progres.Visible = false;

            HabilitarBtns(true);

                TxtNombre.Focus();
            }
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

        private void FormIngreso_Activated(object sender, EventArgs e)
        {
            TxtNombre.Focus();
        }
    }
}
