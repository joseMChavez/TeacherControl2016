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
        }
        Usuarios usuario = new Usuarios();
        public void Limpiar()
        {
            UsuIdtextBox.Clear();
            NombreTextBox.Clear();
            ApellidotextBox.Clear();
            EmailtextBox.Clear();
            DirecciontextBox.Clear();
            TellMaskedTextBox.Clear();
            TellMaskedTextBox.Mask = "###-###-####";
            PassTextBox.Clear();
            ConfirPasstextBox.Clear();
            
            UsuariosErrorProvider.Clear();
            NombreTextBox.Focus();

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
        private bool ValidarTodo()
        {
          
            //Textbox Nombre
            if (NombreTextBox.Text.Equals("") && ApellidotextBox.Text.Equals("") && (EmailtextBox.Text.Equals("") || ComprobarFormatoEmail(EmailtextBox.Text) )&& DirecciontextBox.Text.Equals("") && TellMaskedTextBox.MaskCompleted && (PassTextBox.Text.Equals("") || PassTextBox.Text.Length < 6) && ConfirPasstextBox.Text.Equals(""))
            {
                UsuariosErrorProvider.SetError(NombreTextBox, "Digite el nombre de Usuario!");
                UsuariosErrorProvider.SetError(ApellidotextBox, "Digite el apellido de Usuario!");
                UsuariosErrorProvider.SetError(EmailtextBox, "Digite un Email del Usuario que sea del Formato ejemplo@ejemail.eje!");
                UsuariosErrorProvider.SetError(TellMaskedTextBox, "Digite un Numero de Telefono!");
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
        public void LlenarDatos()
        {
            int id;
            int.TryParse(UsuIdtextBox.Text, out id);
            usuario.usuarioId = id;
            usuario.nombre = NombreTextBox.Text;
            usuario.apellido = ApellidotextBox.Text;
            usuario.email = EmailtextBox.Text;
            usuario.direccion = DirecciontextBox.Text;
            usuario.telefono = TellMaskedTextBox.Text;
            usuario.pass = PassTextBox.Text;
            usuario.passConfir = ConfirPasstextBox.Text;
            
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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) )
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
        private void UsuIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNuemericos(e);
            if (e.KeyChar == 13)
                NombreTextBox.Focus();

            
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
                ApellidotextBox.Focus();

        }
        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
                EmailtextBox.Focus();
        }
        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEspecial(e);

            if (e.KeyChar == 13)
                DirecciontextBox.Focus();
        }
    
        private void DirecciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxAlfaNumerico(e);


            if (e.KeyChar == 13)
                TellMaskedTextBox.Focus();
        }

        private void TellMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                PassTextBox.Focus();
        }
        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEspecial(e);

            if (e.KeyChar == 13)
                ConfirPasstextBox.Focus();
        }

        private void ConfirPasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxEspecial(e);

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
                    ApellidotextBox.Text = usuario.apellido;
                    EmailtextBox.Text = usuario.email;
                    DirecciontextBox.Text = usuario.direccion;
                    TellMaskedTextBox.Text = usuario.telefono;
                    PassTextBox.Text = usuario.pass;
                    ConfirPasstextBox.Text = usuario.passConfir;

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
            bool Validacion = ValidarTodo();
            try
            {
                
               
                if (UsuIdtextBox.Text.Equals(""))
                {
                    if (Validacion)
                    {
                        if (usuario.BuscarNombre(NombreTextBox.Text) )
                        {
                            MessageBox.Show(NombreTextBox.Text + "Es Un Usuario \n Intenete Nuevamene!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Limpiar();
                            NombreTextBox.Focus();
                        }
                        else
                        {
                            LlenarDatos();
                            if (PassTextBox.Text.Equals(ConfirPasstextBox.Text))
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
                                Mensajes(3, "La Contraseñas No Coinsiden!");
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
                            PassTextBox.Focus();
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
            try
            {
                if (usuario.Buscar(id))
                {
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar al Usuario " + NombreTextBox.Text + "?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (usuario.Eliminar())
                        {
                            Mensajes(1, "Usuario "+NombreTextBox.Text + " \nEliminado Correctamente!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            
        }

       
    }
}
