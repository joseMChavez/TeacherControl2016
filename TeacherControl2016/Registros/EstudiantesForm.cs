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
    public partial class EstudiantesForm : Form
    {
        public EstudiantesForm()
        {
            InitializeComponent();
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
        //Este metodo es para Validar los Textbox
        private void Validar(TextBox tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                EstudianteErrorProvider.SetError(tb, mensaje);
                tb.Focus();
            }
            else
            {
                EstudianteErrorProvider.Clear();
            }
        }
        private bool ValidarTodo()
        {
            if (MatriculatextBox.Text.Equals("") && NombretextBox.Text.Equals("") && ApellidostextBox.Text.Equals("") && (MasculinoRadioButton.Checked || FemeninoradioButton.Checked) && FechaDateTimePicker.Checked && TelefonoMaskedTextBox.MaskCompleted && EmailtextBox.Text.Equals("") && DirecciontextBox.Text.Equals("") && CursocomboBox.Text.Equals("") && NombrePadretextBox.Text.Equals("") && TelefonoPmaskedTextBox.MaskCompleted)
            {
                EstudianteErrorProvider.SetError(MatriculatextBox, "Digite La Matricula del Estudiante!");
                EstudianteErrorProvider.SetError(NombretextBox, "Digite el Nombre del Estudiante!");
                EstudianteErrorProvider.SetError(ApellidostextBox, "Digite el Apellido del Estudiante!");
                EstudianteErrorProvider.SetError(Generolabel, "Seleccione un Sexo!");
                EstudianteErrorProvider.SetError(FechaDateTimePicker, "Seleccione Una Fecha de Nacimiento!");
                EstudianteErrorProvider.SetError(TelefonoMaskedTextBox, "Digite un Email!");
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
        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
