﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colores;

namespace Guia_9
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            BtnIngreso.Tag = typeof(FormIngreso);
            BtnConsulta.Tag = typeof(FormConsulta);
            BtnHome.Tag = typeof(FormInicio);

            FormInicio nuevoForm = new FormInicio() ;
            nuevoForm.MdiParent = this;
            nuevoForm.Dock = DockStyle.Fill;
            nuevoForm.Show();
            Properties.Settings.Default.actconsultas = true;
            Properties.Settings.Default.Save();
        }
        private void BtnForms(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Type btntype = btn.Tag as Type;

            AbrirFormularioMDI(btntype);
            DesactivarBtn(btn.GetType());
            btn.BackColor = PaletaColores.Blue500;
            btn.ForeColor = PaletaColores.Blue50;
        }

        private void DesactivarBtn(Type btntype)
        {
            foreach (Control btn in TableLayoutPaneltop.Controls)
            {
                if (btn.GetType() == btntype)
                {
                    btn.BackColor = PaletaColores.Blue50;
                    btn.ForeColor = PaletaColores.Blue500;
                }
            }
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

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
