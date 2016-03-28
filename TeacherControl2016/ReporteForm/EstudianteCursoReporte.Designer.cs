namespace TeacherControl2016.ReporteForm
{
    partial class EstudianteCursoReporte
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
            this.EstudianteCursoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            //this.teacherControlDbDataSetGenerico = new TeacherControl2016.TeacherControlDbDataSetGenerico();
            this.teacherControlDbDataSetGenericoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.cursosDetalleTableAdapter = new TeacherControl2016.TeacherControlDbDataSetGenericoTableAdapters.CursosDetalleTableAdapter();
            //((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudianteCursoreportViewer
            // 
            this.EstudianteCursoreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cursosDetalleBindingSource;
            this.EstudianteCursoreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.EstudianteCursoreportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.ReportEstudianteCurso.rdlc";
            this.EstudianteCursoreportViewer.Location = new System.Drawing.Point(0, 0);
            this.EstudianteCursoreportViewer.Name = "EstudianteCursoreportViewer";
            this.EstudianteCursoreportViewer.Size = new System.Drawing.Size(830, 261);
            this.EstudianteCursoreportViewer.TabIndex = 0;
            // 
            // teacherControlDbDataSetGenerico
            // 
            //this.teacherControlDbDataSetGenerico.DataSetName = "TeacherControlDbDataSetGenerico";
            //this.teacherControlDbDataSetGenerico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // teacherControlDbDataSetGenericoBindingSource
            // 
            //this.teacherControlDbDataSetGenericoBindingSource.DataSource = this.teacherControlDbDataSetGenerico;
            this.teacherControlDbDataSetGenericoBindingSource.Position = 0;
            // 
            // cursosDetalleBindingSource
            // 
            this.cursosDetalleBindingSource.DataMember = "CursosDetalle";
            this.cursosDetalleBindingSource.DataSource = this.teacherControlDbDataSetGenericoBindingSource;
            // 
            // cursosDetalleTableAdapter
            // 
            //this.cursosDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // EstudianteCursoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 261);
            this.Controls.Add(this.EstudianteCursoreportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EstudianteCursoReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Estudiante Por Cursos";
            this.Load += new System.EventHandler(this.EstudianteCursoReporte_Load);
            //((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EstudianteCursoreportViewer;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetGenericoBindingSource;
        //private TeacherControlDbDataSetGenerico teacherControlDbDataSetGenerico;
        private System.Windows.Forms.BindingSource cursosDetalleBindingSource;
        //private TeacherControlDbDataSetGenericoTableAdapters.CursosDetalleTableAdapter cursosDetalleTableAdapter;
    }
}