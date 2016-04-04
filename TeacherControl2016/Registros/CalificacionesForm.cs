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
        Calificaciones calificaciones = new Calificaciones();
        public CalificacionesForm()
        {
            InitializeComponent();
            CargarCursos();
            CargaMateria();
            CargarDescripcion();
            DesactivarMenuContextual();

        }

        private void Limpiar() {
            CalificacionesDataGridView.Rows.Clear();
            CalificaioneserrorProvider.Clear();
            CalificacionIdtextBox.Clear();
            if (CursoComboBox.Text.Equals("") || GrupocomboBox.Text.Equals("") || EstudiantecomboBox.Text.Equals("") || MateriacomboBox.Text.Equals(""))
            {
                Utility.Mensajes(1, "En esto Momentos No se Puede Agregar Calificaciones \nPues no Tenemos Estudiantes  o Materias Registrados\n Registrelos eh Intente Nuevamente.");
                ActivarBotones(false);
            }
            else
            {
                CursoComboBox.SelectedIndex = 0;
                MatriculatextBox.Clear();
                GrupocomboBox.SelectedIndex = 0;
                EstudiantecomboBox.SelectedIndex = 0;
                MateriacomboBox.SelectedIndex = 0;
                
                TotaltextBox.Clear();
                GuardarButton.Enabled = true;
                Agregarbutton.Enabled = true;
            }
        }
        private void DesactivarMenuContextual()
        {
            var blankContextMenu = new ContextMenu();

            foreach (Control control in this.Controls)
            {
                control.ContextMenu = blankContextMenu;
            }
        }

        private void LlenarDatos()
        {
            
            int id = Utility.ConvierteEntero(CalificacionIdtextBox.Text);
            int matricula = Utility.ConvierteEntero(MatriculatextBox.Text);
            calificaciones.CalificacionId = id;
            calificaciones.Fecha = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            calificaciones.Curso = CursoComboBox.Text;
            calificaciones.CursoGrupo = GrupocomboBox.Text;
            calificaciones.Estudiante = EstudiantecomboBox.Text;
            calificaciones.Materia = MateriacomboBox.Text;
            calificaciones.Matricula = matricula;
            float total = 0;
            float.TryParse(TotaltextBox.Text, out total);
            calificaciones.TotalPuntos = total;
            foreach (DataGridViewRow item in CalificacionesDataGridView.Rows)
            {
                calificaciones.AgregarCalificaiones(item.Cells["Categoria"].Value.ToString(), (float)Convert.ToDecimal(item.Cells["Puntos"].Value));
            }
            
        }
        private void ObtenerDatos() {
            
            FechadateTimePicker.Text = calificaciones.Fecha;
            CursoComboBox.Text = calificaciones.Curso;
            GrupocomboBox.Text = calificaciones.CursoGrupo;
            MateriacomboBox.Text = calificaciones.Materia;
            EstudiantecomboBox.Text = calificaciones.Estudiante;
            MatriculatextBox.Text = calificaciones.Matricula.ToString();
            TotaltextBox.Text = calificaciones.TotalPuntos.ToString();
            foreach (CalificacionesDetalle item in calificaciones.CalificaionesD)
            {
                CalificacionesDataGridView.Rows.Add(item.Descripcion, item.Puntuacion);
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
        private void CargarDescripcion()
        {
            DataTable dt = new DataTable();
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();

            dt = cCalificaciones.Listado("CategoriaCalificacionesId,Descripcion", "0=0", "CategoriaCalificacionesId");
            CCalificaionesComboBox.DataSource = dt;
            CCalificaionesComboBox.ValueMember = "CategoriaCalificacionesId";
            CCalificaionesComboBox.DisplayMember = "Descripcion";
        }

        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            Agregarbutton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void ValidarTodo()
        {
            if (CalificacionesDataGridView.RowCount == 0 && MatriculatextBox.Text.Equals(""))
            {
                CalificaioneserrorProvider.SetError(CalificacionesDataGridView, "No hay Calificaciones");
                CalificaioneserrorProvider.SetError(MatriculatextBox, "Digite Una Matricula!");
                CalificacionesDataGridView.Focus();
                MatriculatextBox.Focus();
            }
            else
            {
                CalificaioneserrorProvider.Clear();
            }
        }
        private void EstudiantecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MatriculatextBox.Focus();
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

        private void MatriculatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar == 13)
            {
                PuntostextBox.Focus();
            }
        }
        private void PuntostextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar == 13)
            {
                Agregarbutton.Focus();
            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
            int id = Utility.ConvierteEntero(CalificacionIdtextBox.Text);

            try
            {
                Utility.Validar(CalificacionIdtextBox, CalificaioneserrorProvider, "Digite un Id a Buscar!");
                if (!CalificacionIdtextBox.Text.Equals(""))
                {
                    if (calificaciones.Buscar(id))
                    {
                        ObtenerDatos();
                        ActivarBotones(true);
                        PuntostextBox.Focus();
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id No Encontrado!");
                        ActivarBotones(false);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Teacher Control");
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
           
            float total=0;

            try
            {
                Utility.Validar(PuntostextBox, CalificaioneserrorProvider, "Digite los Puntos para la Descripcion Designada.");
                Utility.Validar(CCalificaionesComboBox, CalificaioneserrorProvider, "Registre un Descripcion en el Registro de Categorias de Calificaciones!");
                if (!PuntostextBox.Text.Equals("") || !CCalificaionesComboBox.Text.Equals(""))
                {
                    
                    CalificacionesDataGridView.Rows.Add(CCalificaionesComboBox.Text, PuntostextBox.Text);
                  
                    foreach(DataGridViewRow item in CalificacionesDataGridView.Rows)
                    {
                        total += (float)Convert.ToDecimal(item.Cells["Puntos"].Value);
                    }
                        
                    
                    PuntostextBox.Clear();
                    PuntostextBox.Focus();

                }

                TotaltextBox.Text = total.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Teacher Control");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EstudiantecomboBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            int matricula = Utility.ConvierteEntero(MatriculatextBox.Text);
            try
            {
                calificaciones.LimpiarLista();
                LlenarDatos();
                ValidarTodo();
                if (CalificacionIdtextBox.Text.Equals("") && CalificacionesDataGridView.RowCount>0)
                {
                    if (estudiante.BuscarMatricula(matricula,CursoComboBox.Text,GrupocomboBox.Text))
                    {
                        if (calificaciones.Insertar())
                        {
                            Utility.Mensajes(1, "Las Calificaciónes del Estudiante " + EstudiantecomboBox.Text + " An sido Guardada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, " Las Calificaciónes del Estudiante " + EstudiantecomboBox.Text + "NO An sido Guardada!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else
                    {
                        CalificaioneserrorProvider.SetError(MatriculatextBox, "No existe un Estudiante con esta Matricula En ese Curso!");
                        MatriculatextBox.Clear();
                        MatriculatextBox.Focus();
                    }
                    
                }
                else
                {
                    if (!CalificacionIdtextBox.Text.Equals("") && CalificacionesDataGridView.RowCount > 0)
                    {
                      
                        if (estudiante.BuscarMatricula(matricula, CursoComboBox.Text, GrupocomboBox.Text))
                        {
                            if (calificaciones.Editar())
                            {
                                Utility.Mensajes(1, "Calificaciónes del Estudiante " + EstudiantecomboBox.Text + " An sido Modificada Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Utility.Mensajes(2, " Las Calificaciónes del Estudiante " + EstudiantecomboBox.Text + "NO An sido Modificada!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            CalificaioneserrorProvider.SetError(MatriculatextBox, "No existe un Estudiante con esta Matricula En ese Curso!");
                            MatriculatextBox.Clear();
                            MatriculatextBox.Focus();
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Teacher Control");

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            

            int id = Utility.ConvierteEntero(CalificacionIdtextBox.Text);
            DialogResult resultado;
            try
            {
                if (!CalificacionIdtextBox.Text.Equals("") && calificaciones.Buscar(id))
                {
                    resultado = MessageBox.Show("¿Esta Seguro de Eliminar las Calificaiones del Estudiante " + EstudiantecomboBox.Text + " de la Materia" + MateriacomboBox.Text + "?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado== DialogResult.Yes)
                    {
                        if (calificaciones.Eliminar())
                        {
                            Utility.Mensajes(1, "Calificaciónes del Estudiante " + EstudiantecomboBox.Text + " An sido Eliminadas Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, " Las Calificaciónes del Estudiante " + EstudiantecomboBox.Text + "NO An sido Eliminadas!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    
                }
                else
                {
                    Utility.Mensajes(3, "Id No Encontrado!");
                    ActivarBotones(false);
                    CalificacionIdtextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Teacher Control");
            }
        }

        private void EstudiantecomboBox_TextChanged(object sender, EventArgs e)
        {
           
            
                DataRowView row;
               
                row= (DataRowView)EstudiantecomboBox.SelectedItem;

                MatriculatextBox.Text = row["Matricula"].ToString();
            


        }
    }
}
