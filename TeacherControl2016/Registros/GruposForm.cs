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
    public partial class GruposForm : Form
    {
        public GruposForm()
        {
            InitializeComponent();
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
        private void Limpiar()
        {
            GruposIdtextBox.Clear();
            DescripcionTextBox.Clear();
            GruposerrorProvider.Clear();
        }
        private void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void LLenarDatos(Grupos grupo)
        {
            int id = Utility.ConvierteEntero(GruposIdtextBox.Text);
            grupo.GrupoId = id;
            grupo.Descripcion = DescripcionTextBox.Text;

        }
        private void GruposIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxNuemericos(e);
            if (e.KeyChar==13 && GuardarButton.Enabled==true)
            {
                DescripcionTextBox.Focus();
            }
            else
            {
                BuscarButton.Focus();
            }
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            Utility.Enter(e, GuardarButton);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Grupos grupo = new Grupos();
            int id = 0;
            try
            {
                Utility.Validar(GruposIdtextBox, GruposerrorProvider, "Digite el Id!");
                if (!GruposIdtextBox.Text.Equals(""))
                {
                    id = Utility.ConvierteEntero(GruposIdtextBox.Text);
                    if (grupo.Buscar(id))
                    {
                        DescripcionTextBox.Text = grupo.Descripcion;
                        ActivarBotones(true);
                        DescripcionTextBox.Focus();
                    }
                    else {
                        Utility.Mensajes(3,"Id no encontrado!");
                        Limpiar();
                        GruposIdtextBox.Focus();
                        ActivarBotones(false);
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
            Grupos grupo = new Grupos();
            int id =0;
            try
            {
                LLenarDatos(grupo);
                Utility.Validar(DescripcionTextBox, GruposerrorProvider, "Digite una Descripcion o Nombre del Grupo!");
                if (GruposIdtextBox.Text.Equals("") && !DescripcionTextBox.Text.Equals(""))
                {
                    if (grupo.BuscarDescripcion(DescripcionTextBox.Text)==false)
                    {
                        
                            if (grupo.Insertar())
                            {
                                Utility.Mensajes(1, "El Grupo " + DescripcionTextBox.Text + " Ah Sido Guardado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Utility.Mensajes(1, "El Grupo " + DescripcionTextBox.Text + "No Ah Sido Guardado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }

                    }
                    else
                    {
                        Utility.Mensajes(3, "El Grupo " + DescripcionTextBox.Text + " Ya Existe \n Intente Nuevamente!");
                        Limpiar();
                        DescripcionTextBox.Focus();
                    }
                }
                else
                {
                   id= Utility.ConvierteEntero(GruposIdtextBox.Text);
                    if (!DescripcionTextBox.Text.Equals("") && grupo.Buscar(id))
                    {
                        if (grupo.BuscarDescripcion(DescripcionTextBox.Text) == false)
                        {
                            if (grupo.Editar())
                            {
                                Utility.Mensajes(1, "El Grupo " + DescripcionTextBox.Text + " Ah Sido Modificado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                            else
                            {
                                Utility.Mensajes(1, "El Grupo " + DescripcionTextBox.Text + "No Ah Sido Modificado Correctamente!");
                                Limpiar();
                                ActivarBotones(false);
                            }
                        }
                        else
                        {
                            Utility.Mensajes(3, "El Grupo " + DescripcionTextBox.Text + " Ya Existe \n Intente Nuevamente!");
                            DescripcionTextBox.Clear();
                            DescripcionTextBox.Focus();
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
            Grupos grupo = new Grupos();
            int id = Utility.ConvierteEntero(GruposIdtextBox.Text);
            DialogResult resultado;
            try
            {
                if (!GruposIdtextBox.Text.Equals("")&& grupo.Buscar(id) && !DescripcionTextBox.Text.Equals(""))
                {
                    resultado = MessageBox.Show("¿Esta seguro que desea eliminar el Grupo  " + DescripcionTextBox.Text + "?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        if (grupo.Eliminar())
                        {
                            Utility.Mensajes(1, "El Grupo " + DescripcionTextBox.Text + " Ah Sido Eliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "El Grupo " + DescripcionTextBox.Text + "No Ah Sido Eliminado!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(3, "Id No Existe!");
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
