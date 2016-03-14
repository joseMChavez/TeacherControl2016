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
            Utility.TextboxAlfaNumerico(e);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string filtro = "1=1";
            Usuarios usuario = new Usuarios();

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text +"like '%"+BuscartextBox+"%'";
            }
            UsuariosDataGridView.DataSource = usuario.Listado("usuarioId as Id,nombre as Nombres, apellido as Apellidos, email as Email, direccion as Dirección, clave as Contraseña",filtro,"");
            TotaltextBox.Text = UsuariosDataGridView.RowCount.ToString(); 
        }
    }
}
