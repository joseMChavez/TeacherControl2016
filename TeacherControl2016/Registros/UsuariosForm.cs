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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        Usuarios usuario = new Usuarios();
        public void Limpiar()
        {
            UsuIdtextBox.Clear();
            NombreTextBox.Clear();
            PassTextBox.Clear();
            TipoUsuariocomboBox.ResetText();
            UsuariosErrorProvider.Clear();
            
           
        }
        //Este metodo es para Validar los Textbox
        private void Validar(TextBox tb, string mensaje)
        {
            
            if (tb.Text.Equals(""))
            {
                UsuariosErrorProvider.SetError(tb, mensaje);
                tb.Focus();
            }
            else
            {
                UsuariosErrorProvider.Clear();
            }
        }
        //Este metodo es para Validar los Textbox
        private void ValidarComboBox(ComboBox cbb, string mensaje)
        {

            if (cbb.Text.Equals(""))
            {
                UsuariosErrorProvider.SetError(cbb, mensaje);
                cbb.Focus();
            }
            else
            {
                UsuariosErrorProvider.Clear();
            }
        }
        public void ActivarBotones( bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        public void LlenarDatos()
        {
            int id;
            int.TryParse(UsuIdtextBox.Text, out id);
            usuario.usuarioId = id;
            usuario.nombre = NombreTextBox.Text;
            usuario.pass = PassTextBox.Text;
            usuario.tipoUsuario = TipoUsuariocomboBox.Text;
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
        private void UsuIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
         
            
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar>= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 165))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


            if (e.KeyChar == 13)
                PassTextBox.Focus();
        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 64 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 63) || (e.KeyChar == 33) || (e.KeyChar == 168))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;


            if (e.KeyChar == 13)
                NombreTextBox.Focus();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(UsuIdtextBox.Text, out id);
            try
            {
                Validar(UsuIdtextBox, "Id no Encotrado!");
                if (!UsuIdtextBox.Text.Equals("") && usuario.Buscar(id))
                {
                    NombreTextBox.Text = usuario.nombre;
                    PassTextBox.Text = usuario.pass;
                    TipoUsuariocomboBox.Text = usuario.tipoUsuario;

                    NombreTextBox.Focus();
                    ActivarBotones(true);

                }
                else
                {
                    Mensajes(2, "El Id: " + UsuIdtextBox.Text + " NO existe!");

                    Limpiar();

                    ActivarBotones(false);
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
            EliminarButton.Enabled = false;
            GuardarButton.Enabled = true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validar(NombreTextBox, "Falta El Nombre de Usuario!");
                Validar(PassTextBox, "Falta la contraseña!");
                ValidarComboBox(TipoUsuariocomboBox, "Seleccione un tipo de usuario!");
                if (UsuIdtextBox.Text.Equals(""))
                {
                    if (!NombreTextBox.Text.Equals("") && !PassTextBox.Text.Equals("") && !TipoUsuariocomboBox.Text.Equals(""))
                    {
                        if (usuario.BuscarNombre(NombreTextBox.Text))
                        {
                            MessageBox.Show(NombreTextBox.Text + "Es Un Usuario \n Intenete Nuevamene!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Limpiar();
                            NombreTextBox.Focus();
                        }
                        else
                        {
                            LlenarDatos();
                            if (PassTextBox.Text.Length >= 6)
                            {
                                if (usuario.Insertar())
                                {
                                    Mensajes(1, "El Usuarios " + NombreTextBox.Text + " A sido Guardado Correctamente!");
                                    Limpiar();
                                }
                                else
                                {
                                    Mensajes(2, "Error en Guardar Usuario!");
                                }
                            }
                            else
                            {
                                Mensajes(2, "La Contraseña debe de contener mas de 5 digitos");
                            }

                        }
                    }
                    else
                    {
                        Mensajes(2, "Debe de LLenar Todos los Campos!");
                    }
                }
                else
                {
                    Validar(UsuIdtextBox, "Coloque un Id!");
                    Validar(NombreTextBox, "Falta El Nombre de Usuario!");
                    Validar(PassTextBox, "Falta la contraseña!");
                    ValidarComboBox(TipoUsuariocomboBox, "Seleccione un tipo de Usuario!");
                    if (!NombreTextBox.Text.Equals("") && !PassTextBox.Text.Equals("") && !TipoUsuariocomboBox.Text.Equals(""))
                    {
                        if (usuario.BuscarNombre(NombreTextBox.Text) && PassTextBox.Text.Length >= 6)
                        {
                            if (usuario.Editar())
                            {
                                Mensajes(1, "Usuarios Modificado Correctamente");
                                Limpiar();
                            }
                            else
                            {
                                Mensajes(2, "Error en Modifica Usuario!");
                            }
                        }
                        else
                        {
                            Mensajes(3, "La Contraseña debe de contener mas de 5 digitos \no\n " + NombreTextBox.Text + " Ya existe!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
                
                
               
            
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult resut;
            //Dialogo para confirmar que se desea Eliminar...
            
                int id = 0;
                int.TryParse(UsuIdtextBox.Text, out id);
            
                if (usuario.Buscar(id))
                {
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar al Usuario " + NombreTextBox.Text + "?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (usuario.Eliminar())
                        {
                            Mensajes(1, NombreTextBox.Text + " \nEliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, "No se Pudo Eliminar a" + NombreTextBox.Text);
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Mensajes(2, " NO Existe el Usuario " + NombreTextBox.Text);
                    Limpiar();
                    ActivarBotones(false);
                }
            }
          

       
    }
}
