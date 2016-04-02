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
    public partial class AsistenciaReporForm : Form
    {
        public AsistenciaReporForm()
        {
            InitializeComponent();
        }

        private void AsistenciaReporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacherControlDbDataSetNew.Asistencias' table. You can move, or remove it, as needed.
            this.asistenciasTableAdapter.Fill(this.teacherControlDbDataSetNew.Asistencias);
            this.AsistenciareportViewer.RefreshReport();
        }
    }
}
