using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using BLL;

namespace TeacherControl2016.Registros
{
    public partial class EstudiantesForm : Form
    {
        
        public EstudiantesForm()
        {
            InitializeComponent();
            CargarComboBox();
            CargarGrupo();
            DesactivarMenuContextual();
          
        }
        //Este Metodo es para desactivar el menu Contextual el cual sale cuando le damos clip derecho en un textbox;
        private void DesactivarMenuContextual()
        {
            var blankContextMenu = new ContextMenu();

            foreach (Control control in this.Controls)
            {
                control.ContextMenu = blankContextMenu;
            }
        }
        private void CargarComboBox()
        {
            DataTable data = new DataTable();
            Cursos curso = new Cursos();

            data = curso.Listado("CursoId,Descripcion", "0=0", "ORDER BY CursoId");
            CursocomboBox.DataSource = data;
            CursocomboBox.ValueMember = "CursoId";
            CursocomboBox.DisplayMember = "Descripcion";
        }
        private void LlenarDatos(Estudiantes estudiante)
            {
            int id = 0;
            int.TryParse(EstudianteIdtextBox.Text, out id);
            estudiante.EstudianteId = id;
            int matricula = 0;
            int.TryParse(MatriculatextBox.Text, out matricula);
            estudiante.Matricula = matricula;
            estudiante.Nombre = NombretextBox.Text;
            estudiante.Apellidos = ApellidostextBox.Text;
            if (MasculinoRadioButton.Checked)
            {
                estudiante.Genero = "M";
            }
            else
            {
                estudiante.Genero = "F";
            }
            
            estudiante.FechaNacimiento = FechaDateTimePicker.Text;
            int edad = Utility.ConvierteEntero(EdadtextBox.Text);
            estudiante.Edad = edad;
            estudiante.Celular = TelefonoMaskedTextBox.Text;
            estudiante.Email = EmailtextBox.Text;
            estudiante.Direccion = DirecciontextBox.Text;
            
            estudiante.Curso = CursocomboBox.Text;
            estudiante.Grupo = GrupocomboBox.Text;
            

            
        }
        private void ObtenerValor(Estudiantes estudiante) {
            EstudianteIdtextBox.Text = estudiante.EstudianteId.ToString();
            MatriculatextBox.Text = estudiante.Matricula.ToString();
            NombretextBox.Text = estudiante.Nombre;
            ApellidostextBox.Text = estudiante.Apellidos;
            if (estudiante.Genero == "M")
            {
                MasculinoRadioButton.Checked = true;
            }
            if (estudiante.Genero == "F")
            {
                FemeninoradioButton.Checked = true;
            }
           
            FechaDateTimePicker.Text = estudiante.FechaNacimiento;
            TelefonoMaskedTextBox.Text = estudiante.Celular;
            EmailtextBox.Text = estudiante.Email;
            DirecciontextBox.Text = estudiante.Direccion;
            CursocomboBox.Text = estudiante.Curso;
            GrupocomboBox.Text = estudiante.Grupo;
          
        }

        private void Limpiar()
            {
            
            EstudianteIdtextBox.Clear();
            MatriculatextBox.Clear();
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            MasculinoRadioButton.Checked = false;
            FemeninoradioButton.Checked = false;
            EdadtextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Mask = "###-###-####";
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            if (!CursocomboBox.Text.Equals("") && !GrupocomboBox.Text.Equals(""))
            {
                CursocomboBox.SelectedIndex = 0;
                GrupocomboBox.SelectedIndex = 0;
                GuardarButton.Enabled = true;
            }
            else
            {
                Utility.Mensajes(3, "Agregue Los Cursos en el registro de Cursos!\n Si ya Tiene los Cursos Agregue los Grupos en el registro de Grupos!");
                ActivarBotones(false);

            }
            
           
            EstudianteErrorProvider.Clear();
           
        }
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void CargarGrupo()
        {

            DataTable data = new DataTable();
            Grupos grupo = new Grupos();

            data = grupo.Listado("GrupoId,Descripcion","0=0","GrupoId");
            GrupocomboBox.DataSource = data;
            GrupocomboBox.ValueMember = "GrupoId";
            GrupocomboBox.DisplayMember = "Descripcion";
        }

        private bool ValidarTodo()
        {
            if (MatriculatextBox.Text.Equals("") && NombretextBox.Text.Equals("") && ApellidostextBox.Text.Equals("") && (MasculinoRadioButton.Checked || FemeninoradioButton.Checked) && FechaDateTimePicker.Checked && TelefonoMaskedTextBox.MaskCompleted && EmailtextBox.Text.Equals("") && DirecciontextBox.Text.Equals(""))
            {
                EstudianteErrorProvider.SetError(MatriculatextBox, "Digite La Matricula del Estudiante!");
                EstudianteErrorProvider.SetError(NombretextBox, "Digite el Nombre del Estudiante!");
                EstudianteErrorProvider.SetError(ApellidostextBox, "Digite el Apellido del Estudiante!");
                EstudianteErrorProvider.SetError(Generolabel, "Seleccione un Sexo!");
                EstudianteErrorProvider.SetError(FechaDateTimePicker, "Seleccione Una Fecha de Nacimiento!");
                EstudianteErrorProvider.SetError(TelefonoMaskedTextBox, "Digite un Email del Usuario que sea del Formato ejemplo@ejemail.eje!");
                EstudianteErrorProvider.SetError(EmailtextBox, "Digite un Email!");
                EstudianteErrorProvider.SetError(DirecciontextBox, "Digite una Direccion!");
                EstudianteErrorProvider.SetError(CursocomboBox, "Seleccione un Curso!");
               
                NombretextBox.Focus();

                return true;
            }
            else
            {
                EstudianteErrorProvider.Clear();
                return false;
            }
        }
        
        private void EstudianteIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar == 13 && GuardarButton.Enabled==true)
            {
                MatriculatextBox.Focus();
            }
            else
            {
                BuscarButton.Focus();
            }
        }

        private void MatriculatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            Utility.Enter(e, NombretextBox);
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            Utility.Enter(e,ApellidostextBox);
        }

        private void ApellidostextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            if (e.KeyChar == 13)
            {
                FechaDateTimePicker.Focus();
                MasculinoRadioButton.Checked = true;
            }

        }
        private void FechaDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Enter(e, TelefonoMaskedTextBox);
        }
        //Esto me permite Calcular la Edad de Una Persona;
        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                EdadtextBox.Text = (DateTime.Today.AddTicks(-FechaDateTimePicker.Value.Ticks).Year - 1).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Enter(e, EmailtextBox);
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, DirecciontextBox);
        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            Utility.Enter(e, CursocomboBox);
        }
        private void CursocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CursocomboBox.SelectedIndex = 0;
                GrupocomboBox.SelectedIndex = 0;
            }
            Utility.Enter(e, GrupocomboBox);
        }
        private void GrupocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.Enter(e, GuardarButton);
        }


        /// 
        /// Boton Buscar
        /// 

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            int id = Utility.ConvierteEntero(EstudianteIdtextBox.Text);
            try
            {
                Utility.Validar(EstudianteIdtextBox, EstudianteErrorProvider, "Digite el Id a Buscar!");
                if (!EstudianteIdtextBox.Text.Equals(""))
                {
                    if (estudiante.Buscar(id))
                    {
                        ObtenerValor(estudiante);
                        ActivarBotones(true);
                        MatriculatextBox.Focus();
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id No encontrado!");
                        EstudianteIdtextBox.Focus();
                        ActivarBotones(false);
                        Limpiar();
                    }

                }
                
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        /// 
        /// Boton Nuevo
        /// 
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
            MatriculatextBox.Focus();
        }
        /// 
        /// Boton Guardar
        /// 
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            int matricula = Utility.ConvierteEntero(MatriculatextBox.Text);
            try
            {
                LlenarDatos(estudiante);
                
                if (EstudianteIdtextBox.Text.Equals("") && ValidarTodo()==false)
                {
                    
                    if (Utility.ComprobarFormatoEmail(EmailtextBox.Text))
                    {
                        if (estudiante.BuscarMatricula(matricula,CursocomboBox.Text, GrupocomboBox.Text)==false)
                        {
                            if (estudiante.Insertar())
                            {
                                Utility.Mensajes(1, "El Estudiante '" + NombretextBox.Text + "' con la Matricula '" + MatriculatextBox.Text + "' En el Curso'" + CursocomboBox.Text + " " + GrupocomboBox.Text + "'\n Ah Sido Guardado Correctamete.");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Utility.Mensajes(2, "El Estudiante '" + NombretextBox.Text + "' con la Matricula '" + MatriculatextBox.Text + "' En el Curso'" + CursocomboBox.Text + " " + GrupocomboBox.Text + "\n No se ah sido Guardado.");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            Utility.Mensajes(3,"Ya Existe un Estudiante con la Matricula'"+MatriculatextBox.Text+"' En el Curso'"+CursocomboBox.Text+" " + GrupocomboBox.Text+"'\n Por Favor Intente Nuevamente!");
                            MatriculatextBox.Clear();
                            MatriculatextBox.Focus();
                        }
                       
                    }
                    else
                    {
                        EstudianteErrorProvider.SetError(EmailtextBox, "Email Invalido");
                        EmailtextBox.Clear();
                        EmailtextBox.Focus();
                    }
                    
                }
                else
                {
                    if (Utility.ComprobarFormatoEmail(EmailtextBox.Text))
                    {
                        if (estudiante.BuscarMatricula(matricula,CursocomboBox.Text, GrupocomboBox.Text)==false)
                        {
                            if (estudiante.Editar())
                            {
                                Utility.Mensajes(1, "El Estudiante '" + NombretextBox.Text + "' con la Matricula '" + MatriculatextBox.Text + "' En el Curso'" + CursocomboBox.Text + " " + GrupocomboBox.Text + "\n Ah Sido Modificado Correctamete.");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Utility.Mensajes(2, "El Estudiante '" + NombretextBox.Text + "' con la Matricula '" + MatriculatextBox.Text + "' En el Curso'" + CursocomboBox.Text + " " + GrupocomboBox.Text + "\n No se ah sido Modificado.");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            Utility.Mensajes(3, "Ya Existe un Estudiante con la Matricula'" + MatriculatextBox.Text + "' En el Curso'" + CursocomboBox.Text + " " + GrupocomboBox.Text + "'\n Por Favor Intente Nuevamente!");
                            MatriculatextBox.Clear();
                            MatriculatextBox.Focus();
                        }
                        
                    }
                    else
                    {
                        EstudianteErrorProvider.SetError(EmailtextBox, "Email Invalido");
                        EmailtextBox.Clear();
                        EmailtextBox.Focus();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                
            }
               
        }
        /// 
        /// Boton Eliminar
        /// 
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Utility.ConvierteEntero(EstudianteIdtextBox.Text);
            DialogResult resut;
            Estudiantes estudiante = new Estudiantes();
            try
            {
               
                if (!EstudianteIdtextBox.Text.Equals("") && estudiante.Buscar(id))
                {
                    //Dialogo para confirmar que se desea Eliminar...
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar a "+NombretextBox.Text+"?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (estudiante.Eliminar())
                        {
                            Utility.Mensajes(1, NombretextBox.Text + " a sido Eliminado Corectamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, NombretextBox.Text + "No a sido Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else {
                        Utility.Mensajes(3, " NO Existe el Usuario " + NombretextBox.Text);
                        Limpiar();
                        ActivarBotones(false);
                    }

                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        
    }
}
