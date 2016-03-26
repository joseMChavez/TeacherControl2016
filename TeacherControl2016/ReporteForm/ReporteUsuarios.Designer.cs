namespace TeacherControl2016.ReporteForm
{
    partial class ReporteUsuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UsuarioreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.teacherControlDbDataSetGenericoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetGenerico = new TeacherControl2016.TeacherControlDbDataSetGenerico();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new TeacherControl2016.TeacherControlDbDataSetGenericoTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioreportViewer
            // 
            this.UsuarioreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuario";
            reportDataSource1.Value = this.usuarioBindingSource;
            this.UsuarioreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.UsuarioreportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.UsuarioReport.rdlc";
            this.UsuarioreportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioreportViewer.Name = "UsuarioreportViewer";
            this.UsuarioreportViewer.Size = new System.Drawing.Size(663, 261);
            this.UsuarioreportViewer.TabIndex = 0;
            // 
            // teacherControlDbDataSetGenericoBindingSource
            // 
            this.teacherControlDbDataSetGenericoBindingSource.DataSource = this.teacherControlDbDataSetGenerico;
            this.teacherControlDbDataSetGenericoBindingSource.Position = 0;
            // 
            // teacherControlDbDataSetGenerico
            // 
            this.teacherControlDbDataSetGenerico.DataSetName = "TeacherControlDbDataSetGenerico";
            this.teacherControlDbDataSetGenerico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.teacherControlDbDataSetGenericoBindingSource;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 261);
            this.Controls.Add(this.UsuarioreportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Usuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer UsuarioreportViewer;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetGenericoBindingSource;
        private TeacherControlDbDataSetGenerico teacherControlDbDataSetGenerico;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private TeacherControlDbDataSetGenericoTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
    }
}