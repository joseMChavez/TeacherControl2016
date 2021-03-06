﻿namespace TeacherControl2016.ReporteForm
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
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherControlDbDataSetNew = new TeacherControl2016.TeacherControlDbDataSetNew();
            this.CursosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new TeacherControl2016.TeacherControlDbDataSetNewTableAdapters.CursoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.teacherControlDbDataSetNewBindingSource;
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
            // CursosreportViewer
            // 
            this.CursosreportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cursos";
            reportDataSource1.Value = this.cursoBindingSource1;
            this.CursosreportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.CursosreportViewer.LocalReport.ReportEmbeddedResource = "TeacherControl2016.Reportes.CursosReport.rdlc";
            this.CursosreportViewer.Location = new System.Drawing.Point(0, 0);
            this.CursosreportViewer.Name = "CursosreportViewer";
            this.CursosreportViewer.Size = new System.Drawing.Size(717, 316);
            this.CursosreportViewer.TabIndex = 0;
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataMember = "Curso";
            this.CursoBindingSource.DataSource = this.teacherControlDbDataSetNew;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // CursosReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 316);
            this.Controls.Add(this.CursosreportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CursosReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Cursos";
            this.Load += new System.EventHandler(this.CursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherControlDbDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CursosreportViewer;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private TeacherControlDbDataSetNew teacherControlDbDataSetNew;
        private System.Windows.Forms.BindingSource teacherControlDbDataSetNewBindingSource;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private TeacherControlDbDataSetNewTableAdapters.CursoTableAdapter cursoTableAdapter;
        //private TeacherControlDbDataSetGenericoTableAdapters.CursoTableAdapter cursoTableAdapter;
    }
}