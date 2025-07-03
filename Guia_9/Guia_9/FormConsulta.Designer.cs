namespace Guia_9
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TLPTop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerTodos = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.PanelBajo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Progres = new System.Windows.Forms.ProgressBar();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.BackWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelProgres = new System.Windows.Forms.Panel();
            this.PanelCartel = new System.Windows.Forms.Panel();
            this.TLPCartel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.TLPTop.SuspendLayout();
            this.PanelBajo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.PanelProgres.SuspendLayout();
            this.PanelCartel.SuspendLayout();
            this.TLPCartel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TLPTop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 23);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(770, 64);
            this.PanelTop.TabIndex = 0;
            // 
            // TLPTop
            // 
            this.TLPTop.ColumnCount = 4;
            this.TLPTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLPTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.14286F));
            this.TLPTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.79221F));
            this.TLPTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPTop.Controls.Add(this.BtnBuscar, 1, 0);
            this.TLPTop.Controls.Add(this.label1, 0, 0);
            this.TLPTop.Controls.Add(this.BtnVerTodos, 2, 0);
            this.TLPTop.Controls.Add(this.TxtDni, 1, 0);
            this.TLPTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPTop.Location = new System.Drawing.Point(0, 0);
            this.TLPTop.Name = "TLPTop";
            this.TLPTop.RowCount = 1;
            this.TLPTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPTop.Size = new System.Drawing.Size(770, 64);
            this.TLPTop.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.BtnBuscar.Image = global::Guia_9.Properties.Resources.user_magnifying_glass_24_blue50;
            this.BtnBuscar.Location = new System.Drawing.Point(481, 11);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(128, 42);
            this.BtnBuscar.TabIndex = 11;
            this.BtnBuscar.Tag = "1";
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.EnabledChanged += new System.EventHandler(this.BtnBuscar_EnabledChanged);
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI, Apellido ó Nombre:";
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVerTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.BtnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.BtnVerTodos.FlatAppearance.BorderSize = 0;
            this.BtnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.BtnVerTodos.Image = global::Guia_9.Properties.Resources.users_24_blue50;
            this.BtnVerTodos.Location = new System.Drawing.Point(628, 11);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(128, 42);
            this.BtnVerTodos.TabIndex = 12;
            this.BtnVerTodos.Tag = "0";
            this.BtnVerTodos.Text = "TODOS";
            this.BtnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVerTodos.UseVisualStyleBackColor = false;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // TxtDni
            // 
            this.TxtDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtDni.BackColor = System.Drawing.Color.White;
            this.TxtDni.Location = new System.Drawing.Point(195, 19);
            this.TxtDni.MaxLength = 50;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(250, 25);
            this.TxtDni.TabIndex = 10;
            this.TxtDni.TextChanged += new System.EventHandler(this.TxtDni_TextChanged);
            this.TxtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDni_KeyPress);
            // 
            // PanelBajo
            // 
            this.PanelBajo.Controls.Add(this.tableLayoutPanel1);
            this.PanelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBajo.Location = new System.Drawing.Point(0, 316);
            this.PanelBajo.Name = "PanelBajo";
            this.PanelBajo.Size = new System.Drawing.Size(770, 64);
            this.PanelBajo.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BtnEditar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(231)))));
            this.BtnEditar.Image = global::Guia_9.Properties.Resources.user_pen_24_yellow50;
            this.BtnEditar.Location = new System.Drawing.Point(125, 11);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(128, 42);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.BtnEliminar.Image = global::Guia_9.Properties.Resources.trash_can_24_red50;
            this.BtnEliminar.Location = new System.Drawing.Point(515, 11);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(128, 42);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.DGV);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 110);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.PanelPrincipal.Size = new System.Drawing.Size(770, 206);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(16, 0);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(738, 206);
            this.DGV.TabIndex = 0;
            this.DGV.VirtualMode = true;
            this.DGV.DataSourceChanged += new System.EventHandler(this.DGV_DataSourceChanged);
            this.DGV.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_ColumnHeaderMouseClick);
            this.DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_RowsRemoved);
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // Progres
            // 
            this.Progres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.Progres.Dock = System.Windows.Forms.DockStyle.Top;
            this.Progres.Location = new System.Drawing.Point(0, 0);
            this.Progres.Name = "Progres";
            this.Progres.Size = new System.Drawing.Size(770, 23);
            this.Progres.TabIndex = 1;
            this.Progres.Visible = false;
            // 
            // EP
            // 
            this.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EP.ContainerControl = this;
            this.EP.Icon = ((System.Drawing.Icon)(resources.GetObject("EP.Icon")));
            // 
            // BackWorker
            // 
            this.BackWorker.WorkerReportsProgress = true;
            this.BackWorker.WorkerSupportsCancellation = true;
            this.BackWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackWork_DoWork);
            this.BackWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackWork_ProgressChanged);
            this.BackWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackWork_RunWorkerCompleted);
            // 
            // PanelProgres
            // 
            this.PanelProgres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.PanelProgres.Controls.Add(this.Progres);
            this.PanelProgres.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProgres.Location = new System.Drawing.Point(0, 0);
            this.PanelProgres.Name = "PanelProgres";
            this.PanelProgres.Size = new System.Drawing.Size(770, 23);
            this.PanelProgres.TabIndex = 1;
            // 
            // PanelCartel
            // 
            this.PanelCartel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.PanelCartel.Controls.Add(this.TLPCartel);
            this.PanelCartel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCartel.Location = new System.Drawing.Point(0, 87);
            this.PanelCartel.Name = "PanelCartel";
            this.PanelCartel.Size = new System.Drawing.Size(770, 23);
            this.PanelCartel.TabIndex = 3;
            // 
            // TLPCartel
            // 
            this.TLPCartel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TLPCartel.ColumnCount = 2;
            this.TLPCartel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.7013F));
            this.TLPCartel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.TLPCartel.Controls.Add(this.label3, 1, 0);
            this.TLPCartel.Controls.Add(this.label2, 0, 0);
            this.TLPCartel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPCartel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLPCartel.Location = new System.Drawing.Point(0, 0);
            this.TLPCartel.Name = "TLPCartel";
            this.TLPCartel.RowCount = 1;
            this.TLPCartel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCartel.Size = new System.Drawing.Size(770, 23);
            this.TLPCartel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Para editar o eliminar un registro seleccione una fila de la tabla";
            // 
            // FormConsulta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 380);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelBajo);
            this.Controls.Add(this.PanelCartel);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelProgres);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsulta";
            this.ShowIcon = false;
            this.Text = "FormConsulta";
            this.Activated += new System.EventHandler(this.FormConsulta_Activated);
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.PanelTop.ResumeLayout(false);
            this.TLPTop.ResumeLayout(false);
            this.TLPTop.PerformLayout();
            this.PanelBajo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.PanelProgres.ResumeLayout(false);
            this.PanelCartel.ResumeLayout(false);
            this.TLPCartel.ResumeLayout(false);
            this.TLPCartel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TableLayoutPanel TLPTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel PanelBajo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.ProgressBar Progres;
        private System.ComponentModel.BackgroundWorker BackWorker;
        private System.Windows.Forms.Panel PanelProgres;
        private System.Windows.Forms.Button BtnVerTodos;
        private System.Windows.Forms.Panel PanelCartel;
        private System.Windows.Forms.TableLayoutPanel TLPCartel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}