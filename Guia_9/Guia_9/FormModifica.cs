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

namespace Guia_9
{
    public partial class FormModifica : Form
    {
        private Persona _persona;
        private Button _form;
        public FormModifica()
        {
            InitializeComponent();
        }
        public FormModifica(Persona persona, Control parent)
        {
            InitializeComponent();
            _persona = persona;
            _form = parent as Button;
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
            Edicion();
            this.Close();

        }

        private void Edicion()
        {
            try
            {
                string consulta = $"UPDATE personas SET legajo = {_persona.Legajo}, dni = {TxtDni.Text}, apellido = '{TxtApellido.Text}', nombres = '{TxtNombre.Text}', telefono = '{TxtTelefono.Text}', direccion = '{TxtDireccion.Text}', telefono2 = '{TxtTelefono2.Text}', mensualquincenal = {RBtnMensual.Checked}, baja = {ChBBaja.Checked} WHERE id = {_persona.Id} ;";


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
        }

        private void FormModifica_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.PerformClick();
        }
    }
}
