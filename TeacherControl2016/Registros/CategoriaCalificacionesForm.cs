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
    public partial class CategoriaCalificacionesForm : Form
    {
        
        public CategoriaCalificacionesForm()
        {
            InitializeComponent();
            DesactivarMenuContextual();
        }
        private void LlenarDatos(CategoriaCalificaciones cCalificaciones)
        {
            int id = Utility.ConvierteEntero(CCalificacionesIdtextBox.Text);
            cCalificaciones.CategoriaCalificacionesId = id;
            cCalificaciones.Descripcion = DescripcionTextBox.Text;

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
            CCalificacionesIdtextBox.Clear();
            DescripcionTextBox.Clear();
            cCalificacioneserrorProvider.Clear();
        }


        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
      
        private void CCalificacionesIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == 13 && GuardarButton.Enabled == true)
            {
                DescripcionTextBox.Focus();
            }
            else if (e.KeyChar == 13 && GuardarButton.Enabled == false)
            {
                BuscarButton.Focus();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            int id = Utility.ConvierteEntero(CCalificacionesIdtextBox.Text);
            try
            {
                Utility.Validar(CCalificacionesIdtextBox,cCalificacioneserrorProvider, "Digite un Id!");
                if (!CCalificacionesIdtextBox.Text.Equals(""))
                {
                    if (cCalificaciones.Buscar(id))
                    {
                        DescripcionTextBox.Text = cCalificaciones.Descripcion;
                        DescripcionTextBox.Focus();
                        ActivarBotones(true);
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id no Econtrado!");
                        ActivarBotones(false);
                        CCalificacionesIdtextBox.Focus();

                    }

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
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            int id = Utility.ConvierteEntero(CCalificacionesIdtextBox.Text);
            try
            {
                LlenarDatos(cCalificaciones);
                Utility.Validar(DescripcionTextBox, cCalificacioneserrorProvider, "Digite la Descripcion de la Categoria de Calificaiones!");
                if (CCalificacionesIdtextBox.Text.Equals("") && !DescripcionTextBox.Text.Equals(""))
                {
                    if (cCalificaciones.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        Utility.Mensajes(3, "La Categoria: " + DescripcionTextBox.Text + " Ya Existe \n Intente Nuevamente!");
                        Limpiar();
                        DescripcionTextBox.Focus();
                    }
                    else
                    {

                        if (cCalificaciones.Insertar())
                        {
                            Utility.Mensajes(1, "La Categoria " + DescripcionTextBox.Text + " Ah Sido Guardada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "La Categoria  " + DescripcionTextBox.Text + "No Ah Sido Guardada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }

                    }

                }
                else
                 if (!CCalificacionesIdtextBox.Text.Equals("") && cCalificaciones.Buscar(id) && !DescripcionTextBox.Text.Equals(""))
                {
                    if (cCalificaciones.BuscarDescripcion(DescripcionTextBox.Text))
                    {

                        Utility.Mensajes(3, "La Categoria: " + DescripcionTextBox.Text + "Ya Existe \n Intente Nuevamente!");
                        Limpiar();
                        DescripcionTextBox.Focus();
                    }
                    else
                    {
                        if (cCalificaciones.Editar())
                        {
                            Utility.Mensajes(1, "La Categoria: " + DescripcionTextBox.Text + " Ah Sido Modificada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(1, "La Categoria: " + DescripcionTextBox.Text + "No Ah Sido Modificada Correctamente!");
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
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            int id = Utility.ConvierteEntero(CCalificacionesIdtextBox.Text);
            DialogResult resultado;
            try
            {
                if (cCalificaciones.Buscar(id))
                {
                    resultado = MessageBox.Show("¿Esta seguro que desea eliminar la Categoria de Calificaciones " + DescripcionTextBox.Text + "?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (cCalificaciones.Eliminar())
                        {

                            Utility.Mensajes(1, "La Categoria: " + DescripcionTextBox.Text + " Ah Sido Eliminada Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "La Categoria: " + DescripcionTextBox.Text + "No Ah Sido Eliminada!");
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
