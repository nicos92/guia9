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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            OleDbDataReader lector = null;
            int cant = 0;
            try
            {
          
                AccesoDB.ConectarDB();
                string consulta = $"SELECT COUNT(id) FROM personas;";
                lector = AccesoDB.LecturaDB(consulta);
                while (lector.Read())
                {
                    cant = Convert.ToInt32(lector[0]);
                }
                LblCant.Text = cant.ToString();

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

        private void LblCant_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
