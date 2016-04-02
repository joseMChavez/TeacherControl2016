namespace TeacherControl2016.ReporteForm
{
    partial class AsistenciaReporForm
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
            this.asistenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetNew = new TeacherControl2016.TeacherControlDbDataSetNew();
            this.AsistenciareportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asistenciasTableAdapter = new TeacherControl2016.TeacherControlDbDataSetNewTableAdapters.AsistenciasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).BeginInit();
            this.SuspendLayout();
            // 
            // asistenciasBindingSource
            // 
            this.asistenciasBindingSource.DataMember = "Asistencias";
            this.asistenciasBindingSource.DataSource = this.teacherControlDbDataSetNewBindingSource;
            // 
            // teacherControlDbDataSetNewBindingSource
            // 
            this.teacherControlDbDataSetNewBindingSource.DataSource = this.teacherControlDbDataSetNew;
            this.teacherControlDbDataSetNewBindingSource.Position = 0;
            // 
            // teacherControlDbDataSetNew
            // 
            this.teacherControlDbDataSetNew.DataSetName = "TeacherControlDbDataSetNew";
            this.teacherControlDbDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AsistenciareportViewer
            // 
            this.AsistenciareportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Asistencias";
            reportDataSource1.Value = this.asistenciasBindingSource;
            this.AsistenciareportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.AsistenciareportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.AsistenciaReport.rdlc";
            this.AsistenciareportViewer.Location = new System.Drawing.Point(0, 0);
            this.AsistenciareportViewer.Name = "AsistenciareportViewer";
            this.AsistenciareportViewer.Size = new System.Drawing.Size(731, 326);
            this.AsistenciareportViewer.TabIndex = 1;
            // 
            // asistenciasTableAdapter
            // 
            this.asistenciasTableAdapter.ClearBeforeFill = true;
            // 
            // AsistenciaReporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 326);
            this.Controls.Add(this.AsistenciareportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AsistenciaReporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de  Asistencias";
            this.Load += new System.EventHandler(this.AsistenciaReporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asistenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer AsistenciareportViewer;
        private TeacherControlDbDataSetNew teacherControlDbDataSetNew;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetNewBindingSource;
        private System.Windows.Forms.BindingSource asistenciasBindingSource;
        private TeacherControlDbDataSetNewTableAdapters.AsistenciasTableAdapter asistenciasTableAdapter;
    }
}