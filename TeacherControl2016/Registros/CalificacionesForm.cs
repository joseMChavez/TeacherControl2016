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

namespace TeacherControl2016.Registros
{
    public partial class CalificacionesForm : Form
    {
        public CalificacionesForm()
        {
            InitializeComponent();
            CargarCursos();
            CargaMateria();
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

        private void CargarCursos()
        {

            DataTable data = new DataTable();
            Cursos curso = new Cursos();

            data = curso.Listado("CursoId,Descripcion", "0=0", "ORDER BY CursoId");
            CursoComboBox.DataSource = data;
            CursoComboBox.ValueMember = "CursoId";
            CursoComboBox.DisplayMember = "Descripcion";
        }
        private void CargarGrupo()
        {

            DataTable data = new DataTable();
            CursosDetalle cDetalle = new CursosDetalle();

            data = cDetalle.ListadoNormal("Id,Grupo", "0=0", "Id");
            GrupocomboBox.DataSource = data;
            GrupocomboBox.ValueMember = "Id";
            GrupocomboBox.DisplayMember = "Grupo";
        }
        private void CargarEstudiantes()
        {
            DataTable dato = new DataTable();
            Estudiantes estudiante = new Estudiantes();
            string filtro = "0=0";
            dato = estudiante.Listado("CursoId,Nombre", filtro, "CursoId,Grupo");
            EstudiantecomboBox.DataSource = dato;
            EstudiantecomboBox.ValueMember = "CursoId";
            EstudiantecomboBox.DisplayMember = "Nombre";
        }
        private void CargaMateria()
        {
            DataTable dt = new DataTable();
            Materias materia = new Materias();

            dt = materia.Listado("MateriaId,Descripcion", "0=0", "MateriaId");
            MateriacomboBox.DataSource = dt;

            MateriacomboBox.ValueMember = "MateriaId";
            MateriacomboBox.DisplayMember = "Descripcion";
        }

        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            Agregarbutton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void ValidarTodo()
        {
            if (CalificacionesDataGridView.RowCount == 0)
            {
                CalificaioneserrorProvider.SetError(CalificacionesDataGridView, "No hay estudiantes en la Lista");
                MateriacomboBox.Focus();
            }
            else
            {
                CalificaioneserrorProvider.Clear();
            }
        }
        private void Validar(Control tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                CalificaioneserrorProvider.SetError(tb, mensaje);
                tb.Focus();

            }
            else
            {
                CalificaioneserrorProvider.Clear();

            }
        }

        private void AsistenciaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
        }
        private void CursoComboBox_TextChanged(object sender, EventArgs e)
        {
            CargarGrupo();
        }

        private void GrupocomboBox_TextChanged(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }
    }
}
