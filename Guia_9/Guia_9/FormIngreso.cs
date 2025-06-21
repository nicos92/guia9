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
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(ref e);
            Validaciones.Borrar(ref e);
        }

        private void TxtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(ref e);
            Validaciones.Borrar(ref e);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.LetrasNumeros(ref e);
            Validaciones.EspaciosBorrar(ref e);
            //Validaciones.EspPrincipio(ref e, TxtDireccion.Text);
        }



        private void SacarDobleEspacio()
        {
            if (Regex.IsMatch(TxtDireccion.Text, @"\s{2,}"))
            {

                int cursor = TxtDireccion.SelectionStart;
                TxtDireccion.Text = Regex.Replace(TxtDireccion.Text, @"\s{2,}", " ");
                TxtDireccion.SelectionStart = cursor - 1;
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            bool nom = TxtNombre.Text.Length > 2;
            bool ape = TxtApellido.Text.Length > 2;
            bool dni = TxtDni.Text.Length == 8;
            bool tel = TxtTelefono.Text.Length > 7;
            bool tel2 = TxtTelefono2.Text.Length > 7;

            bool dire = TxtDireccion.Text.Length > 3;

            BtnIngresar.Enabled = nom && ape && dni && tel && tel2 && dire;
            SacarDobleEspacio();
        }

        private void BtnIngresar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnIngresar.Enabled)
            {
                BtnIngresar.ForeColor = MaterialColors.Blue50;
                BtnIngresar.FlatAppearance.BorderColor = MaterialColors.Blue50;
                BtnIngresar.BackColor = MaterialColors.Blue500;
            }
            else
            {
                BtnIngresar.FlatAppearance.BorderColor = MaterialColors.Grey50;
                BtnIngresar.BackColor = MaterialColors.Grey300;
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
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
                    legajo = Convert.ToInt32(lector[0]) + 1;
                }
                lector.Close();
                AccesoDB.CerrarDB();



                AccesoDB.ConectarDB();

                consulta = $"INSERT INTO personas (legajo, dni, apellido, nombres, telefono, direccion, telefono2, mensualquincenal, baja) VALUES ({legajo},{TxtDni.Text},'{TxtApellido.Text}','{TxtNombre.Text}','{TxtTelefono.Text}','{TxtDireccion.Text}','{TxtTelefono2.Text}', {menquin}, {false});";

             
                int res = AccesoDB.Insertar(consulta);

                if (res > 0)
                {
                    MessageBox.Show("ingreso Correcto");
                    LimpiarForm();
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Error al Abrir la base de datos");
            }
            finally
            {
                lector.Close();
                AccesoDB.CerrarDB();
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
    }
}
