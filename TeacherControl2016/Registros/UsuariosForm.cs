using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;

namespace TeacherControl2016.Registros
{
    public partial class UsuariosForm : Form
    {
        
        public UsuariosForm()
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
        public void Limpiar()
        {
            UsuIdtextBox.Clear();
            NombreTextBox.Clear();
            ApellidotextBox.Clear();
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
       
            PassTextBox.Clear();
            ConfirPasstextBox.Clear();
            
            UsuariosErrorProvider.Clear();
            NombreTextBox.Focus();

        }
      
        //Este metodo es para Validar los Textbox
        private bool ValidarTodo()
        {
          
            //Textbox Nombre
            if (NombreTextBox.Text.Equals("") && ApellidotextBox.Text.Equals("") && (EmailtextBox.Text.Equals("") || Utility.ComprobarFormatoEmail(EmailtextBox.Text)==false )&& DirecciontextBox.Text.Equals("") && (PassTextBox.Text.Equals("") || PassTextBox.Text.Length < 6) && ConfirPasstextBox.Text.Equals(""))
            {
                UsuariosErrorProvider.SetError(NombreTextBox, "Digite el nombre de Usuario!");
                UsuariosErrorProvider.SetError(ApellidotextBox, "Digite el apellido de Usuario!");
                UsuariosErrorProvider.SetError(EmailtextBox, "Digite un Email del Usuario que sea del Formato ejemplo@ejemail.eje!");
               
                UsuariosErrorProvider.SetError(DirecciontextBox, "Digite un Direccion!");
                UsuariosErrorProvider.SetError(PassTextBox, "Digite Una Contarseña con mas de 6 Caracteres!");
                UsuariosErrorProvider.SetError(ConfirPasstextBox, "Confirme la Contraseña!");
               

                NombreTextBox.Focus();
                return false;
            }
            else
            {
                UsuariosErrorProvider.Clear();
                return true;
            }
        }
     
        public void ActivarBotones( bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        public void LlenarDatos(Usuarios usuario)
        {
            int id = Utility.ConvierteEntero(UsuIdtextBox.Text);
            usuario.usuarioId = id;
            usuario.nombre = NombreTextBox.Text;
            usuario.apellido = ApellidotextBox.Text;
            usuario.email = EmailtextBox.Text;
            usuario.direccion = DirecciontextBox.Text;
            
            usuario.pass = PassTextBox.Text;
            usuario.passConfir = ConfirPasstextBox.Text;
            
        }
        private void ObtenerDatos( Usuarios usuario) {

            NombreTextBox.Text = usuario.nombre;
            ApellidotextBox.Text = usuario.apellido;
            EmailtextBox.Text = usuario.email;
            DirecciontextBox.Text = usuario.direccion;

            PassTextBox.Text = usuario.pass;
            ConfirPasstextBox.Text = usuario.passConfir;
        }


        
        private void UsuIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           Utility.TextBoxNuemericos(e);
            if (e.KeyChar == 13)
                NombreTextBox.Focus();
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            Utility.TextBoxSoloTexto(e);
            if (e.KeyChar == 13)
                ApellidotextBox.Focus();

        }
        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxSoloTexto(e);
            if (e.KeyChar == 13)
                EmailtextBox.Focus();
        }
        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);

            if (e.KeyChar == 13)
                DirecciontextBox.Focus();
        }
    
        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
                PassTextBox.Focus();
        }

        
        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);

            if (e.KeyChar == 13)
                ConfirPasstextBox.Focus();
        }

        private void ConfirPasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);

            if (e.KeyChar == 13)
                NombreTextBox.Focus();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            int id = Utility.ConvierteEntero(UsuIdtextBox.Text);
            try
            {
                Utility.Validar(UsuIdtextBox, UsuariosErrorProvider, "Digite el Id a Buscar!");
                if (!UsuIdtextBox.Text.Equals("") && usuario.Buscar(id))
                {

                    ObtenerDatos(usuario);
                    NombreTextBox.Focus();
                    ActivarBotones(true);

                }
                else
                {
                    Utility.Mensajes(2, "El Id: " + UsuIdtextBox.Text + " NO existe!");

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
            GuardarButton.Enabled = true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool Validacion = ValidarTodo();
            Usuarios usuario = new Usuarios();
            try
            {
                if (UsuIdtextBox.Text.Equals(""))
                {
                    if (Validacion)
                    {
                        if (usuario.BuscarNombre(NombreTextBox.Text))
                        {
                            Utility.Mensajes(1, NombreTextBox.Text + "Es Un Usuario \n Intenete Nuevamene!");

                            Limpiar();
                            NombreTextBox.Focus();
                        }
                        else
                        {
                            LlenarDatos(usuario);
                            if (PassTextBox.Text.Equals(ConfirPasstextBox.Text))
                            {
                                if (usuario.Insertar())
                                {
                                    Utility.Mensajes(1, "El Usuarios " + NombreTextBox.Text + " A sido Guardado Correctamente!");
                                    Limpiar();
                                    ActivarBotones(false);
                                }
                                else
                                {
                                    Utility.Mensajes(2, "Error en Guardar Usuario!");
                                    ActivarBotones(false);
                                }
                            }
                            else
                            {
                                Utility.Mensajes(3, "La Contraseñas No Coinsiden!");
                                PassTextBox.Focus();
                            }

                        }
                    }
                    else
                    {
                        NombreTextBox.Focus();
                    }

                }
                else
                {

                    if (Validacion)
                    {
                        if (usuario.BuscarNombre(NombreTextBox.Text) && PassTextBox.Text.Length >= 6)
                        {
                            if (PassTextBox.Text.Equals(ConfirPasstextBox.Text))
                            {
                                if (usuario.Editar())
                                {
                                    Utility.Mensajes(1, "Usuarios Modificado Correctamente");
                                    Limpiar();
                                }
                                else
                                {
                                    Utility.Mensajes(2, "Error en Modifica Usuario!");
                                }
                            }
                            else
                            {
                                Utility.Mensajes(3, "La Contraseña no coincide!");
                                PassTextBox.Focus();
                            }

                        }
                        else
                        {
                            Utility.Mensajes(3, "La Contraseña debe de contener mas de 5 digitos \no\n " + NombreTextBox.Text + " Ya existe!");
                            PassTextBox.Focus();
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
            DialogResult resut;
            //Dialogo para confirmar que se desea Eliminar...
            Usuarios usuario = new Usuarios();
            int id = Utility.ConvierteEntero(UsuIdtextBox.Text);
            try
            {
                if (usuario.Buscar(id))
                {
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar al Usuario " + NombreTextBox.Text + "?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (usuario.Eliminar())
                        {
                            Utility.Mensajes(1, "Usuario "+NombreTextBox.Text + " \nEliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Utility.Mensajes(2, "No se Pudo Eliminar a" + NombreTextBox.Text);
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    Utility.Mensajes(2, " NO Existe el Usuario " + NombreTextBox.Text);
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
