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

namespace TeacherControl2016
{
    public partial class Login : Form
    {
        public Login()
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
       
        

        private void UsuarioNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextboxAlfaNumerico(e);
            if (e.KeyChar == 13)
            {
                PasstextBox.Focus();
            }
        }

        private void PasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                UsuarioNametextBox.Focus();
            }
        }
        private void Limpiar()
        {
            UsuarioNametextBox.Clear();
            PasstextBox.Clear();
            UsuarioNametextBox.Focus();
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            Portada portada = new Portada();
            Utility.Validar(UsuarioNametextBox, LoginerrorProvider, "Digite un Nombre de Usurio!");
            Utility.Validar(PasstextBox, LoginerrorProvider, "Digite una Contrseña!");
            if ( !UsuarioNametextBox.Text.Equals("") && !PasstextBox.Text.Equals(""))
            {
                if ( usuario.BuscarNombre(UsuarioNametextBox.Text) && usuario.BuscarPass(PasstextBox.Text))
                {
                    portada.Show();
                    Limpiar();
                    Hide();
                }
                else
                {
                    Utility.Mensajes(3, "El Usuario o La Contraseña Son Incorrectos!");
                    Limpiar();
                }


            }
            
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
