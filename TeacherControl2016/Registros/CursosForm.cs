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
    public partial class CursosForm : Form
    {
        Cursos curso = new Cursos();
        public CursosForm()
        {
            InitializeComponent();
        }
        private void LlenarDatos() {
            int id = 0;
            int.TryParse(CursosIdtextBox.Text, out id);
            curso.CursoId = id;
            curso.Descripcion = DescripcionTextBox.Text;

        }

        private void Limpiar()
        {
            CursosIdtextBox.Clear();
            DescripcionTextBox.Clear();
            CursosErrorProvider.Clear();
            DescripcionTextBox.Focus();
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

        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private bool ValidarTodo()
        {
            if (DescripcionTextBox.Text.Equals(""))
            {
                CursosErrorProvider.SetError(DescripcionTextBox, "Digite el Nombre o la Descripcion del Curso.");
                DescripcionTextBox.Focus();
                return true;
            }
            else
            {
                CursosErrorProvider.Clear();
                return false;
            }
        }
        private bool Validar(TextBox tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                CursosErrorProvider.SetError(tb, mensaje);
                tb.Focus();
                return true;
            }
            else
            {
                CursosErrorProvider.Clear();
                return false;
            }
        }

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

        private void CursosIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNuemericos(e);

            if (e.KeyChar == 13)
            {
                DescripcionTextBox.Focus();
            }
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if(e.KeyChar==13)
                CursosIdtextBox.Focus();
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool Validacion= ValidarTodo();
            try
            {
                LlenarDatos();
                if (CursosIdtextBox.Text.Equals(""))
                {
                    if (!Validacion)
                    {
                        if (curso.BuscarDescripcion(DescripcionTextBox.Text))
                        {
                            if (curso.Insertar())
                            {
                                Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Guardado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Mensajes(1, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Guardado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            Mensajes(3, "El Curso: " + DescripcionTextBox.Text + "Ya Existe \n Intente Nuevamente!");
                            Limpiar();
                            ActivarBotones(false);
                            
                        }

                    }
                    else
                    {
                        if (curso.BuscarDescripcion(DescripcionTextBox.Text))
                        {
                            if (curso.Editar())
                            {
                                Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Modificado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Mensajes(1, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Modificado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            Mensajes(3, "El Curso: " + DescripcionTextBox.Text + "Ya Existe \n Intente Nuevamente!");
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
            int id = 0;
            int.TryParse(CursosIdtextBox.Text, out id);
            try
            {
                if (curso.Buscar(id))
                {
                    
                        if (curso.Eliminar())
                        {
                            Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Eliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                }
                else
                {
                    Mensajes(2, "Id No Existe!");
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
