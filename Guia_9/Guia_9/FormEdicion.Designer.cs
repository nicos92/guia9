namespace Guia_9
{
    partial class FormEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicion));
            this.Ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelProgres = new System.Windows.Forms.Panel();
            this.Progres = new System.Windows.Forms.ProgressBar();
            this.PanelBajo = new System.Windows.Forms.Panel();
            this.TableLayoutPanelBajo = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.TLPForm = new System.Windows.Forms.TableLayoutPanel();
            this.LblLegajo = new System.Windows.Forms.Label();
            this.GBModalidadPago = new System.Windows.Forms.GroupBox();
            this.RBtnQuincenal = new System.Windows.Forms.RadioButton();
            this.RBtnMensual = new System.Windows.Forms.RadioButton();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChBBaja = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).BeginInit();
            this.PanelProgres.SuspendLayout();
            this.PanelBajo.SuspendLayout();
            this.TableLayoutPanelBajo.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.TLPForm.SuspendLayout();
            this.GBModalidadPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ep
            // 
            this.Ep.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Ep.ContainerControl = this;
            this.Ep.Icon = ((System.Drawing.Icon)(resources.GetObject("Ep.Icon")));
            // 
            // PanelProgres
            // 
            this.PanelProgres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.PanelProgres.Controls.Add(this.Progres);
            this.PanelProgres.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProgres.Location = new System.Drawing.Point(0, 0);
            this.PanelProgres.Name = "PanelProgres";
            this.PanelProgres.Size = new System.Drawing.Size(584, 23);
            this.PanelProgres.TabIndex = 3;
            // 
            // Progres
            // 
            this.Progres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.Progres.Dock = System.Windows.Forms.DockStyle.Top;
            this.Progres.Location = new System.Drawing.Point(0, 0);
            this.Progres.Name = "Progres";
            this.Progres.Size = new System.Drawing.Size(584, 23);
            this.Progres.TabIndex = 1;
            this.Progres.Visible = false;
            // 
            // PanelBajo
            // 
            this.PanelBajo.Controls.Add(this.TableLayoutPanelBajo);
            this.PanelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBajo.Location = new System.Drawing.Point(0, 337);
            this.PanelBajo.Name = "PanelBajo";
            this.PanelBajo.Size = new System.Drawing.Size(584, 64);
            this.PanelBajo.TabIndex = 4;
            // 
            // TableLayoutPanelBajo
            // 
            this.TableLayoutPanelBajo.ColumnCount = 2;
            this.TableLayoutPanelBajo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBajo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.TableLayoutPanelBajo.Controls.Add(this.BtnEditar, 1, 0);
            this.TableLayoutPanelBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelBajo.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelBajo.Name = "TableLayoutPanelBajo";
            this.TableLayoutPanelBajo.RowCount = 1;
            this.TableLayoutPanelBajo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelBajo.Size = new System.Drawing.Size(584, 64);
            this.TableLayoutPanelBajo.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(231)))));
            this.BtnEditar.Image = global::Guia_9.Properties.Resources.user_pen_24_yellow50;
            this.BtnEditar.Location = new System.Drawing.Point(376, 11);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(128, 42);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.EnabledChanged += new System.EventHandler(this.BtnEditar_EnabledChanged);
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            this.BtnEditar.MouseHover += new System.EventHandler(this.BtnEditar_MouseHover);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.TLPForm);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 23);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(584, 314);
            this.PanelPrincipal.TabIndex = 5;
            // 
            // TLPForm
            // 
            this.TLPForm.ColumnCount = 2;
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.73797F));
            this.TLPForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.26203F));
            this.TLPForm.Controls.Add(this.LblLegajo, 1, 0);
            this.TLPForm.Controls.Add(this.GBModalidadPago, 0, 7);
            this.TLPForm.Controls.Add(this.TxtTelefono2, 1, 6);
            this.TLPForm.Controls.Add(this.label5, 0, 5);
            this.TLPForm.Controls.Add(this.TxtTelefono, 1, 5);
            this.TLPForm.Controls.Add(this.label4, 0, 4);
            this.TLPForm.Controls.Add(this.TxtDireccion, 1, 4);
            this.TLPForm.Controls.Add(this.label3, 0, 3);
            this.TLPForm.Controls.Add(this.TxtDni, 1, 3);
            this.TLPForm.Controls.Add(this.label2, 0, 2);
            this.TLPForm.Controls.Add(this.TxtApellido, 1, 2);
            this.TLPForm.Controls.Add(this.label1, 0, 1);
            this.TLPForm.Controls.Add(this.TxtNombre, 1, 1);
            this.TLPForm.Controls.Add(this.LblId, 0, 0);
            this.TLPForm.Controls.Add(this.label6, 0, 6);
            this.TLPForm.Controls.Add(this.ChBBaja, 1, 8);
            this.TLPForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPForm.Location = new System.Drawing.Point(0, 0);
            this.TLPForm.Name = "TLPForm";
            this.TLPForm.RowCount = 9;
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPForm.Size = new System.Drawing.Size(584, 314);
            this.TLPForm.TabIndex = 0;
            // 
            // LblLegajo
            // 
            this.LblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLegajo.AutoSize = true;
            this.LblLegajo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblLegajo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegajo.Location = new System.Drawing.Point(159, 0);
            this.LblLegajo.Name = "LblLegajo";
            this.LblLegajo.Size = new System.Drawing.Size(57, 21);
            this.LblLegajo.TabIndex = 14;
            this.LblLegajo.Text = "label7";
            // 
            // GBModalidadPago
            // 
            this.GBModalidadPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TLPForm.SetColumnSpan(this.GBModalidadPago, 2);
            this.GBModalidadPago.Controls.Add(this.RBtnQuincenal);
            this.GBModalidadPago.Controls.Add(this.RBtnMensual);
            this.GBModalidadPago.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBModalidadPago.Location = new System.Drawing.Point(45, 210);
            this.GBModalidadPago.Name = "GBModalidadPago";
            this.GBModalidadPago.Size = new System.Drawing.Size(494, 62);
            this.GBModalidadPago.TabIndex = 6;
            this.GBModalidadPago.TabStop = false;
            this.GBModalidadPago.Text = "Modalidad de pago";
            // 
            // RBtnQuincenal
            // 
            this.RBtnQuincenal.AutoSize = true;
            this.RBtnQuincenal.Location = new System.Drawing.Point(197, 24);
            this.RBtnQuincenal.Name = "RBtnQuincenal";
            this.RBtnQuincenal.Size = new System.Drawing.Size(86, 21);
            this.RBtnQuincenal.TabIndex = 1;
            this.RBtnQuincenal.TabStop = true;
            this.RBtnQuincenal.Text = "Quincenal";
            this.RBtnQuincenal.UseVisualStyleBackColor = true;
            // 
            // RBtnMensual
            // 
            this.RBtnMensual.AutoSize = true;
            this.RBtnMensual.Location = new System.Drawing.Point(114, 24);
            this.RBtnMensual.Name = "RBtnMensual";
            this.RBtnMensual.Size = new System.Drawing.Size(77, 21);
            this.RBtnMensual.TabIndex = 0;
            this.RBtnMensual.TabStop = true;
            this.RBtnMensual.Text = "Mensual";
            this.RBtnMensual.UseVisualStyleBackColor = true;
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtTelefono2.BackColor = System.Drawing.Color.White;
            this.TxtTelefono2.Location = new System.Drawing.Point(159, 179);
            this.TxtTelefono2.MaxLength = 10;
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(350, 25);
            this.TxtTelefono2.TabIndex = 12;
            this.TxtTelefono2.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtTelefono.BackColor = System.Drawing.Color.White;
            this.TxtTelefono.Location = new System.Drawing.Point(159, 148);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(350, 25);
            this.TxtTelefono.TabIndex = 11;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtDireccion.BackColor = System.Drawing.Color.White;
            this.TxtDireccion.Location = new System.Drawing.Point(159, 117);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(350, 25);
            this.TxtDireccion.TabIndex = 10;
            this.TxtDireccion.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // TxtDni
            // 
            this.TxtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtDni.BackColor = System.Drawing.Color.White;
            this.TxtDni.Location = new System.Drawing.Point(159, 86);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(350, 25);
            this.TxtDni.TabIndex = 9;
            this.TxtDni.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtApellido.BackColor = System.Drawing.Color.White;
            this.TxtApellido.Location = new System.Drawing.Point(159, 55);
            this.TxtApellido.MaxLength = 50;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(350, 25);
            this.TxtApellido.TabIndex = 8;
            this.TxtApellido.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetas_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(159, 24);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(350, 25);
            this.TxtNombre.TabIndex = 7;
            this.TxtNombre.Text = "w";
            this.TxtNombre.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetas_KeyPress);
            // 
            // LblId
            // 
            this.LblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblId.AutoSize = true;
            this.LblId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(49, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(57, 21);
            this.LblId.TabIndex = 13;
            this.LblId.Text = "label7";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono 2:";
            // 
            // ChBBaja
            // 
            this.ChBBaja.AutoSize = true;
            this.ChBBaja.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBBaja.Location = new System.Drawing.Point(159, 278);
            this.ChBBaja.Name = "ChBBaja";
            this.ChBBaja.Size = new System.Drawing.Size(52, 21);
            this.ChBBaja.TabIndex = 16;
            this.ChBBaja.Text = "Baja";
            this.ChBBaja.UseVisualStyleBackColor = true;
            // 
            // FormEdicion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelBajo);
            this.Controls.Add(this.PanelProgres);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 440);
            this.Name = "FormEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EDICION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormModifica_FormClosed);
            this.Load += new System.EventHandler(this.FormModifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).EndInit();
            this.PanelProgres.ResumeLayout(false);
            this.PanelBajo.ResumeLayout(false);
            this.TableLayoutPanelBajo.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.TLPForm.ResumeLayout(false);
            this.TLPForm.PerformLayout();
            this.GBModalidadPago.ResumeLayout(false);
            this.GBModalidadPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider Ep;
        private System.Windows.Forms.Panel PanelProgres;
        private System.Windows.Forms.ProgressBar Progres;
        private System.Windows.Forms.Panel PanelBajo;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelBajo;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.TableLayoutPanel TLPForm;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBModalidadPago;
        private System.Windows.Forms.RadioButton RBtnQuincenal;
        private System.Windows.Forms.RadioButton RBtnMensual;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblLegajo;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox ChBBaja;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}