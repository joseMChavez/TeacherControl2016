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
    public partial class EvaluacionesReporForm : Form
    {
        public EvaluacionesReporForm()
        {
            InitializeComponent();
        }

        private void EvaluacionesReporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacherControlDbDataSetNew.Calificaciones' table. You can move, or remove it, as needed.
            this.calificacionesTableAdapter.Fill(this.teacherControlDbDataSetNew.Calificaciones);
            this.EvaluacioesreportViewer.RefreshReport();
        }
    }
}
