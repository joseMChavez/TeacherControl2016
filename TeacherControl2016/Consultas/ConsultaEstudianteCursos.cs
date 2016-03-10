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
    public partial class ConsultaEstudianteCursos : Form
    {
        public ConsultaEstudianteCursos()
        {
            InitializeComponent();
            CargarComboBox();
        }
        private void CargarComboBox()
        {
            DataTable data = new DataTable();
            Cursos curso = new Cursos();

            data = curso.Listado("CursoId,Descripcion", "0=0", "ORDER BY CursoId");
            FiltrocomboBox.DataSource = data;
            FiltrocomboBox.ValueMember = "CursoId";
            FiltrocomboBox.DisplayMember = "Descripcion";
        }
        private void TextboxAlfaNumerico(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        private void BuscartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (FiltrocomboBox.Text.Equals(""))
            {
                MessageBox.Show("Agregue Estudiantes, pero Antes Agregue los Cursos a los Cuales lo Agregara en el Registro de Cursos.", "Teacher Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CursosDetalle curso = new CursosDetalle();
                string filtro = "1=1";

                if (BuscartextBox.Text.Length > 0)
                {
                    filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

                CursoEstDataGridView.DataSource = curso.Listado("Curso,Descripcion,Nombre,Apellidos,Matricula", filtro, "");

                TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
            }
        }
    }
}
