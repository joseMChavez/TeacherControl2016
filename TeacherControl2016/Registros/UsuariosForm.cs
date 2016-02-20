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
        private bool Validar(TextBox tb, string mensaje)
        {
            bool retorno = false;
            if (tb.Text.Equals(""))
            {
                UsuariosErrorProvider.SetError(tb, mensaje);
                tb.Focus();
            }
            else
            {
                UsuariosErrorProvider.Clear();
                retorno = true;
            }
            return retorno;
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar(UsuIdtextBox, "") == false && Validar(NombreTextBox,"Introduzca El Nombre del Usuario!")== true && Validar(PassTextBox,"Introduzca La Contraseña")==true )
                {
                    if (usuario.BuscarNombre(NombreTextBox.Text) )
                    {
                        MessageBox.Show(NombreTextBox.Text+"Es Un Usuario \n Intenete Nuevamene!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                Mensajes(1, "Usuarios Guardado Correctamente");
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

                    if (Validar(NombreTextBox, "Introduzca El Nombre del Usuario!") == true && Validar(PassTextBox, "Introduzca La Contraseña")==true)
                    {
                        if (PassTextBox.Text.Length >= 6)
                        {
                            if (usuario.Insertar())
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
                            Mensajes(2, "La Contraseña debe de contener mas de 5 digitos");
                        }
                    }
                }
            }
            catch ( Exception ex )
            {

                throw ex;
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
