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

namespace TeacherControl2016.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
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
        private void BuscartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 0)
            {
                Utility.TextBoxNuemericos(e);
                BuscartextBox.MaxLength = 5;
            }
            else
            {
                Utility.TextboxAlfaNumerico(e);
                BuscartextBox.MaxLength = 45;
            }
        }
        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void Mostrar(Usuarios usuario)
        {
            string filtro = "1=1";
           
            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex==0)
                {
                    filtro = "usuario"+FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex==1)
                {
                    filtro = "nombre  like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex == 2)
                {
                    filtro = "apellido  like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex == 3)
                {
                    filtro = "userName  like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex == 4)
                {
                    filtro = "tipoUsuario  like '%" + BuscartextBox.Text + "%'";
                }

            }
            UsuariosDataGridView.DataSource = usuario.Listado("usuarioId as Id,nombre as Nombres, apellido as Apellidos,userName as Usuario,telefono as Telefono ,email as Email, direccion as Dirección, tipoUsuario as Tipo_de_Usuario", filtro, "");
            TotaltextBox.Text = UsuariosDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            int id = 0;
            try
            {
                if (FiltrocomboBox.SelectedIndex==0 && !BuscartextBox.Text.Equals(""))
                {
                    id = Utility.ConvierteEntero(BuscartextBox.Text);
                    if (usuario.Buscar(id))
                    {
                        Mostrar(usuario);
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id No Encontrado!");
                        BuscartextBox.Clear();
                        BuscartextBox.Focus();
                    }
                }
                else
                {
                    Mostrar(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
