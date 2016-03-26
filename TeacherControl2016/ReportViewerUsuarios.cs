using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherControl2016
{
    public partial class ReportViewerUsuarios : Form
    {
        public ReportViewerUsuarios()
        {
            InitializeComponent();
        }

        private void ReportViewerUsuarios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
