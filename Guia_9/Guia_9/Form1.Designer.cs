namespace Guia_9
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TableLayoutPaneltop = new System.Windows.Forms.TableLayoutPanel();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.TableLayoutPaneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TableLayoutPaneltop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(784, 64);
            this.PanelTop.TabIndex = 1;
            // 
            // TableLayoutPaneltop
            // 
            this.TableLayoutPaneltop.ColumnCount = 2;
            this.TableLayoutPaneltop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPaneltop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPaneltop.Controls.Add(this.BtnConsulta, 1, 0);
            this.TableLayoutPaneltop.Controls.Add(this.BtnIngreso, 0, 0);
            this.TableLayoutPaneltop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPaneltop.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPaneltop.Name = "TableLayoutPaneltop";
            this.TableLayoutPaneltop.RowCount = 1;
            this.TableLayoutPaneltop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPaneltop.Size = new System.Drawing.Size(784, 64);
            this.TableLayoutPaneltop.TabIndex = 0;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.BtnConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.BtnConsulta.Image = global::Guia_9.Properties.Resources.user_magnifying_glass_32_blue50;
            this.BtnConsulta.Location = new System.Drawing.Point(392, 0);
            this.BtnConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(392, 64);
            this.BtnConsulta.TabIndex = 1;
            this.BtnConsulta.Text = "CONSULTA";
            this.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnForms);
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.BtnIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIngreso.FlatAppearance.BorderSize = 0;
            this.BtnIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.BtnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.BtnIngreso.Image = global::Guia_9.Properties.Resources.user_plus_32_blue50;
            this.BtnIngreso.Location = new System.Drawing.Point(0, 0);
            this.BtnIngreso.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(392, 64);
            this.BtnIngreso.TabIndex = 0;
            this.BtnIngreso.Text = "INGRESO";
            this.BtnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnForms);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormPrincipal";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            this.TableLayoutPaneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPaneltop;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnIngreso;
    }
}

