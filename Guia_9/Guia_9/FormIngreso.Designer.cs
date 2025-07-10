namespace Guia_9
{
    partial class FormIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.TLPForm = new System.Windows.Forms.TableLayoutPanel();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.Txtstock = new System.Windows.Forms.TextBox();
            this.TxtCarac = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBModalidadPago = new System.Windows.Forms.GroupBox();
            this.RBtnQuincenal = new System.Windows.Forms.RadioButton();
            this.RBtnMensual = new System.Windows.Forms.RadioButton();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.PanelBajo = new System.Windows.Forms.Panel();
            this.TableLayoutPanelBajo = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.PanelProgres = new System.Windows.Forms.Panel();
            this.Progres = new System.Windows.Forms.ProgressBar();
            this.Ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelPrincipal.SuspendLayout();
            this.TLPForm.SuspendLayout();
            this.GBModalidadPago.SuspendLayout();
            this.PanelBajo.SuspendLayout();
            this.TableLayoutPanelBajo.SuspendLayout();
            this.PanelProgres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.TLPForm);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 23);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(780, 306);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // TLPForm
            // 
            this.TLPForm.ColumnCount = 2;
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.73797F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.26203F));
            this.TLPForm.Controls.Add(this.TxtPrecio, 1, 5);
            this.TLPForm.Controls.Add(this.Txtstock, 1, 4);
            this.TLPForm.Controls.Add(this.TxtCarac, 1, 3);
            this.TLPForm.Controls.Add(this.TxtModelo, 1, 2);
            this.TLPForm.Controls.Add(this.TxtMarca, 1, 1);
            this.TLPForm.Controls.Add(this.label1, 0, 0);
            this.TLPForm.Controls.Add(this.label2, 0, 1);
            this.TLPForm.Controls.Add(this.label3, 0, 2);
            this.TLPForm.Controls.Add(this.label4, 0, 3);
            this.TLPForm.Controls.Add(this.label5, 0, 4);
            this.TLPForm.Controls.Add(this.label6, 0, 5);
            this.TLPForm.Controls.Add(this.GBModalidadPago, 0, 6);
            this.TLPForm.Controls.Add(this.TxtTipo, 1, 0);
            this.TLPForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPForm.Location = new System.Drawing.Point(0, 0);
            this.TLPForm.Name = "TLPForm";
            this.TLPForm.RowCount = 7;
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TLPForm.Size = new System.Drawing.Size(780, 306);
            this.TLPForm.TabIndex = 0;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPrecio.BackColor = System.Drawing.Color.White;
            this.TxtPrecio.Location = new System.Drawing.Point(211, 224);
            this.TxtPrecio.MaxLength = 10;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ShortcutsEnabled = false;
            this.TxtPrecio.Size = new System.Drawing.Size(350, 25);
            this.TxtPrecio.TabIndex = 12;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // Txtstock
            // 
            this.Txtstock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txtstock.BackColor = System.Drawing.Color.White;
            this.Txtstock.Location = new System.Drawing.Point(211, 181);
            this.Txtstock.MaxLength = 10;
            this.Txtstock.Name = "Txtstock";
            this.Txtstock.ShortcutsEnabled = false;
            this.Txtstock.Size = new System.Drawing.Size(350, 25);
            this.Txtstock.TabIndex = 11;
            this.Txtstock.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.Txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // TxtCarac
            // 
            this.TxtCarac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtCarac.BackColor = System.Drawing.Color.White;
            this.TxtCarac.Location = new System.Drawing.Point(211, 138);
            this.TxtCarac.MaxLength = 50;
            this.TxtCarac.Name = "TxtCarac";
            this.TxtCarac.ShortcutsEnabled = false;
            this.TxtCarac.Size = new System.Drawing.Size(350, 25);
            this.TxtCarac.TabIndex = 10;
            this.TxtCarac.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtCarac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtModelo
            // 
            this.TxtModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtModelo.BackColor = System.Drawing.Color.White;
            this.TxtModelo.Location = new System.Drawing.Point(211, 95);
            this.TxtModelo.MaxLength = 50;
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.ShortcutsEnabled = false;
            this.TxtModelo.Size = new System.Drawing.Size(350, 25);
            this.TxtModelo.TabIndex = 9;
            this.TxtModelo.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtMarca
            // 
            this.TxtMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtMarca.BackColor = System.Drawing.Color.White;
            this.TxtMarca.Location = new System.Drawing.Point(211, 52);
            this.TxtMarca.MaxLength = 50;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.ShortcutsEnabled = false;
            this.TxtMarca.Size = new System.Drawing.Size(350, 25);
            this.TxtMarca.TabIndex = 8;
            this.TxtMarca.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetras_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Caracteristicas:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de stock:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio:";
            // 
            // GBModalidadPago
            // 
            this.GBModalidadPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GBModalidadPago.BackColor = System.Drawing.Color.Maroon;
            this.TLPForm.SetColumnSpan(this.GBModalidadPago, 2);
            this.GBModalidadPago.Controls.Add(this.RBtnQuincenal);
            this.GBModalidadPago.Controls.Add(this.RBtnMensual);
            this.GBModalidadPago.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBModalidadPago.Location = new System.Drawing.Point(143, 262);
            this.GBModalidadPago.Name = "GBModalidadPago";
            this.GBModalidadPago.Size = new System.Drawing.Size(494, 39);
            this.GBModalidadPago.TabIndex = 13;
            this.GBModalidadPago.TabStop = false;
            this.GBModalidadPago.Text = "Modalidad de pago";
            this.GBModalidadPago.Visible = false;
            // 
            // RBtnQuincenal
            // 
            this.RBtnQuincenal.AutoSize = true;
            this.RBtnQuincenal.Location = new System.Drawing.Point(237, 12);
            this.RBtnQuincenal.Name = "RBtnQuincenal";
            this.RBtnQuincenal.Size = new System.Drawing.Size(86, 21);
            this.RBtnQuincenal.TabIndex = 1;
            this.RBtnQuincenal.Text = "Quincenal";
            this.RBtnQuincenal.UseVisualStyleBackColor = true;
            // 
            // RBtnMensual
            // 
            this.RBtnMensual.AutoSize = true;
            this.RBtnMensual.Checked = true;
            this.RBtnMensual.Location = new System.Drawing.Point(138, 12);
            this.RBtnMensual.Name = "RBtnMensual";
            this.RBtnMensual.Size = new System.Drawing.Size(77, 21);
            this.RBtnMensual.TabIndex = 0;
            this.RBtnMensual.TabStop = true;
            this.RBtnMensual.Text = "Mensual";
            this.RBtnMensual.UseVisualStyleBackColor = true;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtTipo.BackColor = System.Drawing.Color.White;
            this.TxtTipo.Location = new System.Drawing.Point(211, 9);
            this.TxtTipo.MaxLength = 50;
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.ShortcutsEnabled = false;
            this.TxtTipo.Size = new System.Drawing.Size(350, 25);
            this.TxtTipo.TabIndex = 7;
            this.TxtTipo.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetras_KeyPress);
            // 
            // PanelBajo
            // 
            this.PanelBajo.Controls.Add(this.TableLayoutPanelBajo);
            this.PanelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBajo.Location = new System.Drawing.Point(0, 329);
            this.PanelBajo.Name = "PanelBajo";
            this.PanelBajo.Size = new System.Drawing.Size(780, 64);
            this.PanelBajo.TabIndex = 1;
            // 
            // TableLayoutPanelBajo
            // 
            this.TableLayoutPanelBajo.ColumnCount = 1;
            this.TableLayoutPanelBajo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBajo.Controls.Add(this.BtnIngresar, 0, 0);
            this.TableLayoutPanelBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelBajo.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelBajo.Name = "TableLayoutPanelBajo";
            this.TableLayoutPanelBajo.RowCount = 1;
            this.TableLayoutPanelBajo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBajo.Size = new System.Drawing.Size(780, 64);
            this.TableLayoutPanelBajo.TabIndex = 0;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.Enabled = false;
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.BtnIngresar.FlatAppearance.BorderSize = 2;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnIngresar.Image = global::Guia_9.Properties.Resources.user_plus_24_blue50;
            this.BtnIngresar.Location = new System.Drawing.Point(316, 8);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(148, 48);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.EnabledChanged += new System.EventHandler(this.BtnIngresar_EnabledChanged);
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // PanelProgres
            // 
            this.PanelProgres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.PanelProgres.Controls.Add(this.Progres);
            this.PanelProgres.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProgres.Location = new System.Drawing.Point(0, 0);
            this.PanelProgres.Name = "PanelProgres";
            this.PanelProgres.Size = new System.Drawing.Size(780, 23);
            this.PanelProgres.TabIndex = 2;
            // 
            // Progres
            // 
            this.Progres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.Progres.Dock = System.Windows.Forms.DockStyle.Top;
            this.Progres.Location = new System.Drawing.Point(0, 0);
            this.Progres.Name = "Progres";
            this.Progres.Size = new System.Drawing.Size(780, 23);
            this.Progres.TabIndex = 1;
            this.Progres.Visible = false;
            // 
            // Ep
            // 
            this.Ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Ep.ContainerControl = this;
            this.Ep.Icon = ((System.Drawing.Icon)(resources.GetObject("Ep.Icon")));
            // 
            // FormIngreso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(780, 393);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelBajo);
            this.Controls.Add(this.PanelProgres);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIngreso";
            this.ShowIcon = false;
            this.Text = "FormIngreso";
            this.Activated += new System.EventHandler(this.FormIngreso_Activated);
            this.PanelPrincipal.ResumeLayout(false);
            this.TLPForm.ResumeLayout(false);
            this.TLPForm.PerformLayout();
            this.GBModalidadPago.ResumeLayout(false);
            this.GBModalidadPago.PerformLayout();
            this.PanelBajo.ResumeLayout(false);
            this.TableLayoutPanelBajo.ResumeLayout(false);
            this.PanelProgres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel TLPForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelBajo;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelBajo;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.GroupBox GBModalidadPago;
        private System.Windows.Forms.RadioButton RBtnQuincenal;
        private System.Windows.Forms.RadioButton RBtnMensual;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox Txtstock;
        private System.Windows.Forms.TextBox TxtCarac;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Panel PanelProgres;
        private System.Windows.Forms.ProgressBar Progres;
        private System.Windows.Forms.ErrorProvider Ep;
    }
}