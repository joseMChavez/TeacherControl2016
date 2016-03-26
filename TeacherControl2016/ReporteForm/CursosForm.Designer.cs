namespace TeacherControl2016.ReporteForm
{
    partial class CursosReportes
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
            this.teacherControlDbDataSetGenericoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetGenerico = new TeacherControl2016.TeacherControlDbDataSetGenerico();
            this.CursosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new TeacherControl2016.TeacherControlDbDataSetGenericoTableAdapters.CursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // CursosreportViewer
            // 
            this.CursosreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CurosDataSet";
            reportDataSource1.Value = this.cursoBindingSource;
            this.CursosreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.CursosreportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.CursosReport.rdlc";
            this.CursosreportViewer.Location = new System.Drawing.Point(0, 0);
            this.CursosreportViewer.Name = "CursosreportViewer";
            this.CursosreportViewer.Size = new System.Drawing.Size(496, 316);
            this.CursosreportViewer.TabIndex = 0;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.teacherControlDbDataSetGenericoBindingSource;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // CursosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 316);
            this.Controls.Add(this.CursosreportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CursosReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Cursos";
            this.Load += new System.EventHandler(this.CursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenericoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CursosreportViewer;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetGenericoBindingSource;
        private TeacherControlDbDataSetGenerico teacherControlDbDataSetGenerico;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private TeacherControlDbDataSetGenericoTableAdapters.CursoTableAdapter cursoTableAdapter;
    }
}