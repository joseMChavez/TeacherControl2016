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
            DesactivarMenuContextual();
        }
        private void DesactivarMenuContextual()
        {
            var blankContextMenu = new ContextMenu();

            foreach (Control control in this.Controls)
            {
                control.ContextMenu = blankContextMenu;
            }
        }
        private void BuscartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
             Estudiantes estudiante= new Estudiantes();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            EstudianteDataGridView.DataSource = estudiante.Listado("EstudianteId as Id,Matricula,Nombre as Nombres ,Apellido as Apellidos,Genero as Sexo,FechaNacimiento as Fecha_de_Nacimiento,Edad,Celular,Email,Direccion As Direcciòn,NombrePadre as Padre,TelefonoPadre as Telefono", filtro, "");

            TotaltextBox.Text = EstudianteDataGridView.RowCount.ToString();
        }

        
    }
}
