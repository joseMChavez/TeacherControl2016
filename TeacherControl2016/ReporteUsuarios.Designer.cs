namespace TeacherControl2016
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
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerGenerico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TeacherControlDbDataSet = new TeacherControl2016.TeacherControlDbDataSet();
            this.UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuarioTableAdapter = new TeacherControl2016.TeacherControlDbDataSetTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherControlDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerGenerico
            // 
            this.reportViewerGenerico.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuario";
            reportDataSource1.Value = this.UsuarioBindingSource;
            this.reportViewerGenerico.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerGenerico.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.UsuarioReport.rdlc";
            this.reportViewerGenerico.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGenerico.Name = "reportViewerGenerico";
            this.reportViewerGenerico.Size = new System.Drawing.Size(664, 261);
            this.reportViewerGenerico.TabIndex = 0;
            // 
            // TeacherControlDbDataSet
            // 
            this.TeacherControlDbDataSet.DataSetName = "TeacherControlDbDataSet";
            this.TeacherControlDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuarioBindingSource
            // 
            this.UsuarioBindingSource.DataMember = "Usuario";
            this.UsuarioBindingSource.DataSource = this.TeacherControlDbDataSet;
            // 
            // UsuarioTableAdapter
            // 
            this.UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.reportViewerGenerico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Usuarios";
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherControlDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGenerico;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private System.Windows.Forms.BindingSource UsuarioBindingSource;
        private TeacherControlDbDataSet TeacherControlDbDataSet;
        private TeacherControlDbDataSetTableAdapters.UsuarioTableAdapter UsuarioTableAdapter;
    }
}