namespace TeacherControl2016.ReporteForm
{
    partial class EvaluacionesReporForm
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
            this.EvaluacioesreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.teacherControlDbDataSetNew = new TeacherControl2016.TeacherControlDbDataSetNew();
            this.teacherControlDbDataSetNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calificacionesTableAdapter = new TeacherControl2016.TeacherControlDbDataSetNewTableAdapters.CalificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EvaluacioesreportViewer
            // 
            this.EvaluacioesreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Calificaciones";
            reportDataSource1.Value = this.calificacionesBindingSource;
            this.EvaluacioesreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.EvaluacioesreportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.EvalucionesReport.rdlc";
            this.EvaluacioesreportViewer.Location = new System.Drawing.Point(0, 0);
            this.EvaluacioesreportViewer.Name = "EvaluacioesreportViewer";
            this.EvaluacioesreportViewer.Size = new System.Drawing.Size(717, 312);
            this.EvaluacioesreportViewer.TabIndex = 2;
            // 
            // teacherControlDbDataSetNew
            // 
            this.teacherControlDbDataSetNew.DataSetName = "TeacherControlDbDataSetNew";
            this.teacherControlDbDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherControlDbDataSetNewBindingSource
            // 
            this.teacherControlDbDataSetNewBindingSource.DataSource = this.teacherControlDbDataSetNew;
            this.teacherControlDbDataSetNewBindingSource.Position = 0;
            // 
            // calificacionesBindingSource
            // 
            this.calificacionesBindingSource.DataMember = "Calificaciones";
            this.calificacionesBindingSource.DataSource = this.teacherControlDbDataSetNewBindingSource;
            // 
            // calificacionesTableAdapter
            // 
            this.calificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // EvaluacionesReporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.Controls.Add(this.EvaluacioesreportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EvaluacionesReporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Evaluaciones";
            this.Load += new System.EventHandler(this.EvaluacionesReporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EvaluacioesreportViewer;
        private TeacherControlDbDataSetNew teacherControlDbDataSetNew;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetNewBindingSource;
        private System.Windows.Forms.BindingSource calificacionesBindingSource;
        private TeacherControlDbDataSetNewTableAdapters.CalificacionesTableAdapter calificacionesTableAdapter;
    }
}