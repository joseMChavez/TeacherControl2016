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
        Usuarios usuario = new Usuarios();
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
            Utility.Enter(e, PasstextBox);
        }

        private void PasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.TextBoxEspecial(e);
            Utility.Enter(e, Aceptarbutton);
        }
        public void Limpiar()
        {
            UsuarioNametextBox.Clear();
            PasstextBox.Clear();
            UsuarioNametextBox.Focus();
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            
            Portada portada = new Portada();
            Registros.EstudiantesForm estudiante = new Registros.EstudiantesForm();
            Registros.AsistenciasForm asistencia = new Registros.AsistenciasForm();
            Utility.Validar(UsuarioNametextBox, LoginerrorProvider, "Digite un Nombre de Usurio!");
            Utility.Validar(PasstextBox, LoginerrorProvider, "Digite una Contrseña!");
            if ( !UsuarioNametextBox.Text.Equals("") && !PasstextBox.Text.Equals(""))
            {
                if ( usuario.BuscarNombre(UsuarioNametextBox.Text) && usuario.BuscarPass(PasstextBox.Text))
                {
                    if (usuario.BuscarAdministrador(UsuarioNametextBox.Text, PasstextBox.Text))
                    {
                        portada.Show();
                        portada.UsuariotSSLabel.Text = UsuarioNametextBox.Text;
                        Hide();
                    }
                    else
                    {
                        portada.Show();
                        portada.UsuariotSSLabel.Text = UsuarioNametextBox.Text;
                        Hide();
                        portada.usuarioToolStripMenuItem.Visible = false;
                        portada.consultasToolStripMenuItem.Visible = false;
                        portada.reportesToolStripMenuItem.Visible = false;
                       

                    }
                    
                    
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
