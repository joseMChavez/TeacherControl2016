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
            AsistenciadataGridView.Rows.Clear();
            AsistenciaerrorProvider.Clear();
            
            if (CursoComboBox.Text.Equals("") || GrupocomboBox.Text.Equals("") || EstudiantecomboBox.Text.Equals(""))
            {
                Utility.Mensajes(1, "En esto Momentos No se Puede Pasar Lista \nPues no Tenemos Estudiantes Registrados\n Registrelos eh Intente Nuevamente.");
                ActivarBotones(false);
            }
            else
            {
                CursoComboBox.SelectedIndex = 0;
                GrupocomboBox.SelectedIndex = 0;
                EstudiantecomboBox.SelectedIndex = 0;
                EstacomboBox.SelectedIndex = 0;
                CursoComboBox.Focus();
                CantidadEsttextBox.Clear();
                GuardarButton.Enabled = true;
                Agregarbutton.Enabled = true;
            }

        }

        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            Agregarbutton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void ValidarTodo()
        {
            if (AsistenciadataGridView.RowCount == 0)
            {
                AsistenciaerrorProvider.SetError(AsistenciadataGridView, "No hay estudiantes en la Lista");
                EstacomboBox.Focus();
            }
            else
            {
                AsistenciaerrorProvider.Clear();
            }
        }
        
        private void Llenardatos() {
            int cantidad = Utility.ConvierteEntero(CantidadEsttextBox.Text);
            int id = Utility.ConvierteEntero(AsistenciaIdtextBox.Text);
            asistencia.AsistenciaId = id;
            asistencia.Fecha = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            asistencia.CantidadEst = cantidad;
            asistencia.Curso = CursoComboBox.Text; 
            asistencia.CursoGrupo = GrupocomboBox.Text;
            foreach (DataGridViewRow row in AsistenciadataGridView.Rows)
            {
                asistencia.AgregarAsistencia(row.Cells["Estudiante"].Value.ToString(), row.Cells["Estado"].Value.ToString());
            }

        }
        private void ObtenerDatos()
        {
            
            FechadateTimePicker.Text = asistencia.Fecha;
            CursoComboBox.Text = asistencia.Curso.ToString();
            GrupocomboBox.Text = asistencia.CursoGrupo;
            CantidadEsttextBox.Text = asistencia.CantidadEst.ToString();
            foreach (var item in asistencia.aDetalle)
            {
                AsistenciadataGridView.Rows.Add(item.EstudianteId, item.Activo);
            }

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
            
            int id = Utility.ConvierteEntero(AsistenciaIdtextBox.Text);
            try
            {
                Utility.Validar(AsistenciaIdtextBox, AsistenciaerrorProvider, "Digite un Id a Buscar!");
                if (!AsistenciaIdtextBox.Text.Equals(""))
                {
                    if (asistencia.Buscar(id))
                    {
                        ObtenerDatos();
                        ActivarBotones(true);
                        EstacomboBox.Focus();
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id No encontrado!");
                        AsistenciaIdtextBox.Focus();
                        ActivarBotones(false);
                    }

                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Utility.Validar(EstacomboBox, AsistenciaerrorProvider, "Seleccione el Estado del Estudiante!");
                if (!EstacomboBox.Text.Equals(""))
                {
                   
                    AsistenciadataGridView.Rows.Add(EstudiantecomboBox.Text, EstacomboBox.Text);
                    
                }

                CantidadEsttextBox.Text = AsistenciadataGridView.Rows.Count.ToString();

                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            int id = Utility.ConvierteEntero(AsistenciaIdtextBox.Text);
            try
            {
                ValidarTodo();
                Llenardatos();
                if (AsistenciaIdtextBox.Text.Equals("") && AsistenciadataGridView.Rows.Count > 0)
                {
                    if (asistencia.Insertar())
                    {
                        Utility.Mensajes(1, "Se ah Guardado Correctamente \nla Asistencia\n del Curso " + CursoComboBox.Text + " " + GrupocomboBox.Text + "\n del dia " + FechadateTimePicker.Text);
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Utility.Mensajes(1, " No Se ah Guardado \nla Asistencia\n del Curso " + CursoComboBox.Text + " " + GrupocomboBox.Text + "\n del dia " + FechadateTimePicker.Text);
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
                else
                {
                    if (!AsistenciaIdtextBox.Text.Equals("") && asistencia.Buscar(id) && AsistenciadataGridView.Rows.Count > 0)
                    {
                        if (asistencia.Editar())
                        {
                            Utility.Mensajes(1, "Se ah Modificado Correctamente \nla Asistencia\n del Curso " + CursoComboBox.Text + " " + GrupocomboBox.Text + "\n del dia " + FechadateTimePicker.Text);
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, " No Se ah Modificado \nla Asistencia\n del Curso " + CursoComboBox.Text + " " + GrupocomboBox.Text + "\n del dia " + FechadateTimePicker.Text);
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
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
