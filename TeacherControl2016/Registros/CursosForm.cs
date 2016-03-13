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
            DesactivarMenuContextual();
        }
        private void LlenarDatos() {
            int id = Utility.ConvierteEntero(CursosIdtextBox.Text);
            curso.CursoId = id;
            curso.Descripcion = DescripcionTextBox.Text;

        }
        private void DesactivarMenuContextual()
        {
            var blankContextMenu = new ContextMenu();

            foreach (Control control in this.Controls)
            {
                control.ContextMenu = blankContextMenu;
            }
        }
        private void Limpiar()
        {
            CursosIdtextBox.Clear();
            DescripcionTextBox.Clear();
            CursosErrorProvider.Clear();
            DescripcionTextBox.Focus();
        }
      
      
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void ValidarTodo()
        {
            if (DescripcionTextBox.Text.Equals(""))
            {
                CursosErrorProvider.SetError(DescripcionTextBox, "Digite el Nombre o la Descripción del Curso.");
                DescripcionTextBox.Focus();
                
            }
            else
            {
                CursosErrorProvider.Clear();
                
            }
        }
        private void Validar(TextBox tb, string mensaje)
        {

            if (tb.Text.Equals(""))
            {
                CursosErrorProvider.SetError(tb, mensaje);
                tb.Focus();
                
            }
            else
            {
                CursosErrorProvider.Clear();
                
            }
        }
        
        private void CursosIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);

            if (e.KeyChar == 13)
            {
                DescripcionTextBox.Focus();
            }
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            if(e.KeyChar==13)
                CursosIdtextBox.Focus();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Utility.ConvierteEntero(CursosIdtextBox.Text);
            try
            {
                Validar(CursosIdtextBox, "Digite un Id!");
                if (!CursosIdtextBox.Text.Equals("") && curso.Buscar(id))
                {
                    DescripcionTextBox.Text = curso.Descripcion;
                    DescripcionTextBox.Focus();
                    ActivarBotones(true);
                }
                else
                {
                    Utility.Mensajes(3, "Id no Econtrado!");
                    ActivarBotones(false);
                    CursosIdtextBox.Focus();

                }
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
             ValidarTodo();
            int id = Utility.ConvierteEntero(CursosIdtextBox.Text);
            try
            {
                LlenarDatos();

                if (CursosIdtextBox.Text.Equals("") && !DescripcionTextBox.Text.Equals(""))
                {
                    if (curso.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        Utility.Mensajes(3, "El Curso: " + DescripcionTextBox.Text + "Ya Existe \n Intente Nuevamente!");
                        Limpiar();
                        DescripcionTextBox.Focus();
                    }
                    else
                    {
                        if (curso.Insertar())
                        {
                            Utility.Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Guardado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Guardado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }

                    }
                }
                else if (!CursosIdtextBox.Text.Equals("") && curso.Buscar(id) && !DescripcionTextBox.Text.Equals(""))
                {
                    if (curso.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        Utility.Mensajes(3, "El Curso: " + DescripcionTextBox.Text + "Ya Existe \n Intente Nuevamente!");
                        Limpiar();
                        DescripcionTextBox.Focus();
                    }
                    else
                    {
                        if (curso.Editar())
                        {
                            Utility.Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Modificado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Modificado Correctamente!");
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
            int id = Utility.ConvierteEntero(CursosIdtextBox.Text);
            DialogResult resultado;
            try
            {
                if (curso.Buscar(id))
                {
                    resultado = MessageBox.Show("¿Esta seguro que desea eliminar el Curso  " + DescripcionTextBox.Text + "?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (curso.Eliminar())
                        {
                            Utility.Mensajes(1, "El Curso: " + DescripcionTextBox.Text + " Ah Sido Eliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "El Curso: " + DescripcionTextBox.Text + "No Ah Sido Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(2, "Id No Existe!");
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
