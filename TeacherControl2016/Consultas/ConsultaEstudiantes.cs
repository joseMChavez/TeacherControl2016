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
            ImprimirButton.Enabled = false;
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
            if (FiltrocomboBox.SelectedIndex <= 1)
            {
                Utility.TextBoxNuemericos(e);
                BuscartextBox.MaxLength = 5;
            }
            else
            {
                Utility.TextBoxSoloTexto(e);
                BuscartextBox.MaxLength = 45;
            }
        }
        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void Mostrar(Estudiantes estudiante)
        {
            string filtro = "1=1";

            if (FiltrocomboBox.SelectedIndex==0)
            {
                filtro = "Estudiante"+FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }
            else
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            EstudianteDataGridView.DataSource = estudiante.Listado("EstudianteId as Id,Matricula,Nombre as Nombres ,Apellido as Apellidos,Genero as Sexo,FechaNacimiento as Fecha_de_Nacimiento,Edad,Celular,Email,Direccion As Direcciòn,NombrePadre as Padre,TelefonoPadre as Telefono", filtro, "");

            TotaltextBox.Text = EstudianteDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            Estudiantes estudiante = new Estudiantes();
            
            if (FiltrocomboBox.SelectedIndex== 0)
            {
                id = Utility.ConvierteEntero(BuscartextBox.Text);
                if (estudiante.Buscar(id))
                {
                    Mostrar(estudiante);
                    ImprimirButton.Enabled =true;
                }
                else
                {
                    Utility.Mensajes(3, "Id no Encontrado!");
                    BuscartextBox.Clear();
                    BuscartextBox.Focus();
                }
            }
            else
            {
                Mostrar(estudiante);
                ImprimirButton.Enabled = true;
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteForm.ReportViewGenerico reporte = new ReporteForm.ReportViewGenerico();
            DataTable dt = new DataTable();

            dt = (DataTable)EstudianteDataGridView.DataSource;
            dt.TableName = "Estudiante";

            reporte.reporte = "EstudianteReport.rdlc";
            reporte.data = dt;

            reporte.ShowDialog();
            reporte.ShowDialog();

        }
    }
}
