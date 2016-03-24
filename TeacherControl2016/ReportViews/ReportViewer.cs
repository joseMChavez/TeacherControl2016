using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploReporte
{
    public partial class ReportViewer : Form
    {
        public string reporte { get; set; }
        public DataTable data { get; set; }

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            this.reportViewer1.LocalReport.ReportPath = this.reporte;

            ReportDataSource source = new ReportDataSource(this.data.TableName , this.data);

            this.reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }


    }
}
