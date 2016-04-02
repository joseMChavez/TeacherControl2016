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
    public partial class EstudiantesReport : Form
    {
        public EstudiantesReport()
        {
            InitializeComponent();
        }

        private void EstudiantesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacherControlDbDataSetNew.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.teacherControlDbDataSetNew.Estudiante);
            // TODO: This line of code loads data into the 'teacherControlDbDataSetGenerico.Estudiante' table. You can move, or remove it, as needed.
            //this.estudianteTableAdapter.Fill(this.teacherControlDbDataSetGenerico.Estudiante);

            this.reportViewerEstudiantes.RefreshReport();
        }
    }
}
