using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TeacherControl2016.Consultas
{
    public partial class ConsultaEstudiantes : Form
    {
        public ConsultaEstudiantes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
             Estudiantes estudiante= new Estudiantes();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            EstudianteDataGridView.DataSource = estudiante.Listado("EstudianteId,Matricula,Nombre,Apellido,Genero,FechaNacimiento,Edad,Celular,Email,Direccion,NombrePadre,TelefonoPadre", filtro, "");

            TotaltextBox.Text = EstudianteDataGridView.RowCount.ToString();
        }
    }
}
