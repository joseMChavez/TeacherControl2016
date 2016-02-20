namespace TeacherControl2016
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.TeacherControlmenuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TControlstatusStrip = new System.Windows.Forms.StatusStrip();
            this.TControltoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TeacherControltoolStrip = new System.Windows.Forms.ToolStrip();
            this.TeacherControlmenuStrip.SuspendLayout();
            this.TControlstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherControlmenuStrip
            // 
            this.TeacherControlmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.evaluacionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.TeacherControlmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TeacherControlmenuStrip.Name = "TeacherControlmenuStrip";
            this.TeacherControlmenuStrip.Size = new System.Drawing.Size(1013, 24);
            this.TeacherControlmenuStrip.TabIndex = 0;
            this.TeacherControlmenuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "&Registros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // evaluacionToolStripMenuItem
            // 
            this.evaluacionToolStripMenuItem.Name = "evaluacionToolStripMenuItem";
            this.evaluacionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.evaluacionToolStripMenuItem.Text = "&Evaluacion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // TControlstatusStrip
            // 
            this.TControlstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TControltoolStripStatusLabel});
            this.TControlstatusStrip.Location = new System.Drawing.Point(0, 502);
            this.TControlstatusStrip.Name = "TControlstatusStrip";
            this.TControlstatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.TControlstatusStrip.Size = new System.Drawing.Size(1013, 22);
            this.TControlstatusStrip.TabIndex = 1;
            this.TControlstatusStrip.Text = "statusStrip1";
            // 
            // TControltoolStripStatusLabel
            // 
            this.TControltoolStripStatusLabel.Name = "TControltoolStripStatusLabel";
            this.TControltoolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.TControltoolStripStatusLabel.Text = "Usuario";
            // 
            // TeacherControltoolStrip
            // 
            this.TeacherControltoolStrip.Location = new System.Drawing.Point(0, 24);
            this.TeacherControltoolStrip.Name = "TeacherControltoolStrip";
            this.TeacherControltoolStrip.Size = new System.Drawing.Size(1013, 25);
            this.TeacherControltoolStrip.TabIndex = 2;
            this.TeacherControltoolStrip.Text = "toolStrip1";
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 524);
            this.Controls.Add(this.TeacherControltoolStrip);
            this.Controls.Add(this.TControlstatusStrip);
            this.Controls.Add(this.TeacherControlmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TeacherControlmenuStrip;
            this.Name = "Portada";
            this.Text = "Portada";
            this.Load += new System.EventHandler(this.Portada_Load);
            this.TeacherControlmenuStrip.ResumeLayout(false);
            this.TeacherControlmenuStrip.PerformLayout();
            this.TControlstatusStrip.ResumeLayout(false);
            this.TControlstatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TeacherControlmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip TControlstatusStrip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TControltoolStripStatusLabel;
        private System.Windows.Forms.ToolStrip TeacherControltoolStrip;
    }
}