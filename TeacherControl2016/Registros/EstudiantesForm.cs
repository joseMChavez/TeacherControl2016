using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;

namespace TeacherControl2016.Registros
{
    public partial class EstudiantesForm : Form
    {
        Estudiantes estudiante = new Estudiantes();
        public EstudiantesForm()
        {
            InitializeComponent();
            CargarComboBox();
          
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
         private void LlenarDatos()
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
                estudiante.Genero = 1;
            }
            else
            {
                estudiante.Genero = 0;
            }
            
            estudiante.FechaNacimiento = FechaDateTimePicker.Text;
            estudiante.Celular = TelefonoMaskedTextBox.Text;
            estudiante.Email = EmailtextBox.Text;
            estudiante.Direccion = DirecciontextBox.Text;

            int cursoId = 0;
            //int.TryParse(CursocomboBox.SelectedValue.ToString(), out cursoId);
            estudiante.CursoId = cursoId;
            estudiante.Grupo = GrupocomboBox.Text;
            estudiante.NombrePadre = NombrePadretextBox.Text;
            estudiante.TelefonoPadre = TelefonoPmaskedTextBox.Text;

            
        }

         private void Limpiar()
            {
            EstudianteIdtextBox.Clear();
            MatriculatextBox.Clear();
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            MasculinoRadioButton.Checked = false;
            FemeninoradioButton.Checked = false;
          
            TelefonoMaskedTextBox.Clear();
            TelefonoMaskedTextBox.Mask = "###-###-####";
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            //CursocomboBox.SelectedIndex = 0;
            GrupocomboBox.SelectedIndex = 0;
            NombrePadretextBox.Clear();
            TelefonoPmaskedTextBox.Clear();
            TelefonoPmaskedTextBox.Mask = "###-###-####";
            EstudianteErrorProvider.Clear();
            MatriculatextBox.Focus();
        }
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        // Regex esta función permite mediante un patrón verificar si una cadena cumple con ese patrón 
        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //Este metodo es para Validar los Textbox
        private bool Validar(TextBox tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                EstudianteErrorProvider.SetError(tb, mensaje);
                tb.Focus();
                return true;
            }
            else
            {
                EstudianteErrorProvider.Clear();
                return false;
            }
        }
        private bool ValidarTodo()
        {
            if (MatriculatextBox.Text.Equals("") && NombretextBox.Text.Equals("") && ApellidostextBox.Text.Equals("") && (MasculinoRadioButton.Checked || FemeninoradioButton.Checked) && FechaDateTimePicker.Checked && TelefonoMaskedTextBox.MaskCompleted && (EmailtextBox.Text.Equals("") || ComprobarFormatoEmail(EmailtextBox.Text)==false ) && DirecciontextBox.Text.Equals("") && NombrePadretextBox.Text.Equals("") && TelefonoPmaskedTextBox.MaskCompleted)
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
                EstudianteErrorProvider.SetError(NombrePadretextBox, "Digite el Nombre del Padre del Estudiante");
                EstudianteErrorProvider.SetError(TelefonoPmaskedTextBox, "Digite el Telefono del Padre o ese Numero es !");
                NombretextBox.Focus();

                return true;
            }
            else
            {
                EstudianteErrorProvider.Clear();
                return false;
            }
        }
        //1 Informacion...2 Error....3 Cuidado.
        private void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }
        // Estos metodos reciven un evento cuando se presiona una tecla en el textbox para Validarlos
        private void TextBoxNuemericos(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


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
        private void TextBoxEspecial(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 44 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 33) || (e.KeyChar == 95) || (e.KeyChar >= 63 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        //=============================================FinMEtodos=================================================////
        private void EstudianteIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNuemericos(e);
            if (e.KeyChar == 13)
            {
                MatriculatextBox.Focus();
            }
        }

        private void MatriculatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNuemericos(e);
            if (e.KeyChar == 13)
            {
                NombretextBox.Focus();
            }
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                ApellidostextBox.Focus();
            }
        }

        private void ApellidostextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                FechaDateTimePicker.Focus();
            }

        }
        private void FechaDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TelefonoMaskedTextBox.Focus();
            }
        }
        //Esto me permite Calcular la Edad de Una Persona;
        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EdadtextBox.Text = (DateTime.Today.AddTicks(-FechaDateTimePicker.Value.Ticks).Year - 1).ToString();
        }

        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EmailtextBox.Focus();
            }
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEspecial(e);
            if (e.KeyChar == 13)
            {
                DirecciontextBox.Focus();
            }
        }

        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                NombrePadretextBox.Focus();
            }
        }

        private void NombrePadretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                TelefonoPmaskedTextBox.Focus();
            }
        }

        private void TelefonoPmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== 13)
            {
                MatriculatextBox.Focus();
            }
        }
        /// 
        /// Boton Buscar
        /// 
       
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(EstudianteIdtextBox.Text, out id);
            try
            {
                if (Validar(EstudianteIdtextBox,"Digite un Id!")==false && estudiante.Buscar(id))
                {
                    EstudianteIdtextBox.Text = estudiante.EstudianteId.ToString();
                    MatriculatextBox.Text = estudiante.Matricula.ToString();
                    NombretextBox.Text = estudiante.Nombre;
                    ApellidostextBox.Text = estudiante.Apellidos;
                    if (estudiante.Genero == 1)
                    {
                        MasculinoRadioButton.Checked = true;
                    }
                    else
                    {
                        FemeninoradioButton.Checked = true;
                    }
                    FechaDateTimePicker.Text = estudiante.FechaNacimiento;
                    TelefonoMaskedTextBox.Text = estudiante.Celular;
                    EmailtextBox.Text = estudiante.Email;
                    DirecciontextBox.Text = estudiante.Direccion;
                    CursocomboBox.Text = estudiante.CursoId.ToString();
                    GrupocomboBox.Text = estudiante.Grupo;
                    NombrePadretextBox.Text = estudiante.NombrePadre;
                    TelefonoPmaskedTextBox.Text = estudiante.TelefonoPadre;
                    ActivarBotones(true);
                    MatriculatextBox.Focus();
                }
                else
                {
                    Mensajes(3, "Id No encontrado!");
                    EstudianteIdtextBox.Focus();
                    ActivarBotones(false);
                    Limpiar();
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
            GuardarButton.Enabled = true;
        }
        /// 
        /// Boton Guardar
        /// 
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                LlenarDatos();
                if (EstudianteIdtextBox.Text.Equals("") && ValidarTodo()==false)
                {
                    if (estudiante.Insertar())
                    {
                        Mensajes(1, "El Estudiante: " + NombretextBox.Text + "\n Ah Sido Guardado Correctamete.");
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Mensajes(2, "El Estudiante: " + NombretextBox.Text + "\n No se ah sido Guardado.");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
                else
                {
                    if (estudiante.Editar())
                    {
                        Mensajes(1, "El Estudiante: " + NombretextBox.Text + "\n Ah Sido Modificado Correctamete.");
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Mensajes(2, "El Estudiante: " + NombretextBox.Text + "\n No se ah sido Modificado.");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
               
        }
        /// 
        /// Boton Eliminar
        /// 
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            DialogResult resut;
            int.TryParse(EstudianteIdtextBox.Text, out id);
            try
            {
                LlenarDatos();
                if ( estudiante.Buscar(id))
                {
                    //Dialogo para confirmar que se desea Eliminar...
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar a "+NombretextBox.Text+"?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (estudiante.Eliminar())
                        {
                            Mensajes(1, NombretextBox.Text + " a sido Eliminado Corectamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, NombretextBox.Text + "No a sido Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                    else {
                        Mensajes(3, " NO Existe el Usuario " + NombretextBox.Text);
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

        private void CursocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
