using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_9
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnForms(object sender, EventArgs e)
        {
            AbrirFormularioMDI(((Button)sender).Tag as Type);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            BtnIngreso.Tag = typeof(FormIngreso);
            BtnConsulta.Tag = typeof(FormConsulta);
        }

        private void AbrirFormularioMDI(Type formType)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    form.BringToFront();
                    return;
                }
            }

            Form nuevoForm = Activator.CreateInstance(formType) as Form;
            nuevoForm.MdiParent = this;
            nuevoForm.Dock = DockStyle.Fill;
            nuevoForm.Show();
        }
    }
}
