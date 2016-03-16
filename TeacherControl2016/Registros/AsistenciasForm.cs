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
    public partial class AsistenciasForm : Form
    {
        Asistencia asistencia = new Asistencia();
        public AsistenciasForm()
        {
            InitializeComponent();
            DesactivarMenuContextual();
            CargarCursos();
        }
        private void DesactivarMenuContextual()
        {
            var blankContextMenu = new ContextMenu();

            foreach (Control control in this.Controls)
            {
                control.ContextMenu = blankContextMenu;
            }
        }
        private void Limpiar() {
            AsistenciaIdtextBox.Clear();
            CursoComboBox.SelectedIndex = 0;
            GrupocomboBox.SelectedIndex = 0;
            EstudiantecomboBox.SelectedIndex = 0;
            EstacomboBox.SelectedIndex = 0;
            AsistenciadataGridView.Rows.Clear();

        }
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void Llenardatos() {
            int id = Utility.ConvierteEntero(AsistenciaIdtextBox.Text);
            asistencia.AsistenciaId = id;
            asistencia.Fecha = FechadateTimePicker.Text;
            int cursoId = Utility.ConvierteEntero(CursoComboBox.SelectedValue.ToString());
            asistencia.CursoId = cursoId;
            asistencia.CursoGrupo = GrupocomboBox.Text;
            

        }
        //Metodos para Cargar los ComboBox

        private void CargarCursos() {
            
            DataTable data = new DataTable();
            Cursos curso = new Cursos();

            data = curso.Listado("CursoId,Descripcion", "0=0", "ORDER BY CursoId");
            CursoComboBox.DataSource = data;
            CursoComboBox.ValueMember = "CursoId";
            CursoComboBox.DisplayMember = "Descripcion";
        }
        private void CargarGrupo() {

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
            EstudiantecomboBox.DataSource= dato;
            EstudiantecomboBox.ValueMember = "CursoId";
            EstudiantecomboBox.DisplayMember = "Nombre";
        }


        private void AsistenciaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
        }
        private void CursoComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarGrupo();
        }

        private void GrupocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            int EstudianteId = Utility.ConvierteEntero(EstudiantecomboBox.SelectedValue.ToString());
            try
            {
                
                asistencia.AgregarAsistencia(EstudianteId, EstacomboBox.Text);

                AsistenciadataGridView.Rows.Add(EstudiantecomboBox.Text, EstacomboBox.Text);

                Porcentagelabel.Text = AsistenciadataGridView.RowCount.ToString();

                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utility.ConvierteEntero(AsistenciaIdtextBox.Text);
            DialogResult resultado;
           
            try
            {
                if (!AsistenciaIdtextBox.Text.Equals("") && asistencia.Buscar(id))
                {
                    resultado = MessageBox.Show("¿Esta Seguro que desea Eliminar la lista del dia " + FechadateTimePicker.Text + " del Curso "+CursoComboBox.Text+" "+GrupocomboBox.Text+"? ","Teacher Control", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (asistencia.Eliminar())
                        {
                            Utility.Mensajes(1, "Lista de Asistencia Eliminada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "Error en Eliminar Lista!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(3, "Id No Encontrado!");
                    Limpiar();
                    ActivarBotones(false);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
