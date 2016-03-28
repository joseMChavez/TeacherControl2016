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
    public partial class EstudianteCursoReporte : Form
    {
        public EstudianteCursoReporte()
        {
            InitializeComponent();
        }

        private void EstudianteCursoReporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacherControlDbDataSetGenerico.CursosDetalle' table. You can move, or remove it, as needed.
            //this.cursosDetalleTableAdapter.Fill(this.teacherControlDbDataSetGenerico.CursosDetalle);

            this.EstudianteCursoreportViewer.RefreshReport();
        }
    }
}
