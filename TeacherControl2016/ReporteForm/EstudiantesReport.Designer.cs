﻿namespace TeacherControl2016.ReporteForm
{
    partial class EstudiantesReport
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
            this.reportViewerEstudiantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.teacherControlDbDataSetNew = new TeacherControl2016.TeacherControlDbDataSetNew();
            this.teacherControlDbDataSetNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new TeacherControl2016.TeacherControlDbDataSetNewTableAdapters.EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerEstudiantes
            // 
            this.reportViewerEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Estudiante";
            reportDataSource1.Value = this.estudianteBindingSource;
            this.reportViewerEstudiantes.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerEstudiantes.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.EstudianteReport.rdlc";
            this.reportViewerEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEstudiantes.Name = "reportViewerEstudiantes";
            this.reportViewerEstudiantes.Size = new System.Drawing.Size(727, 310);
            this.reportViewerEstudiantes.TabIndex = 0;
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
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.teacherControlDbDataSetNewBindingSource;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // EstudiantesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 310);
            this.Controls.Add(this.reportViewerEstudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EstudiantesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Estudiantes";
            this.Load += new System.EventHandler(this.EstudiantesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstudiantes;
        private TeacherControlDbDataSetNew teacherControlDbDataSetNew;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetNewBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private TeacherControlDbDataSetNewTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        ////private TeacherControlDbDataSetGenericoTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
    }
}