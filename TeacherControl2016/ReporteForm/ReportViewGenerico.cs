using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherControl2016.ReporteForm
{
    public partial class ReportViewGenerico : Form
    {
        public string reporte { get; set; }
        public DataTable data { get; set; }
        public ReportViewGenerico()
        {
            InitializeComponent();
        }

        private void ReportViewGenerico_Load(object sender, EventArgs e)
        {
            this.reportViewerGenerico.Reset();
            this.reportViewerGenerico.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            this.reportViewerGenerico.LocalReport.ReportPath = this.reporte;

            ReportDataSource source = new ReportDataSource(this.data.TableName, this.data);

            this.reportViewerGenerico.LocalReport.DataSources.Add(source);

           
            this.reportViewerGenerico.RefreshReport();
        }
    }
}
