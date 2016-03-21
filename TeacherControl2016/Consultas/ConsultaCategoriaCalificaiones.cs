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
    public partial class ConsultaCategoriaCalificaiones : Form
    {
        public ConsultaCategoriaCalificaiones()
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
            }
        }
        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void Mostrar()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            string filtro = "1=1";
            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            CursoEstDataGridView.DataSource = cCalificaciones.Listado("CategoriaCalificacionesId as Id ,Descripcion as Descripción", filtro, "");

            TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            int id = 0;
            try
            {
                if (FiltrocomboBox.SelectedIndex == 0 && !BuscartextBox.Text.Equals(""))
                {
                    id = Utility.ConvierteEntero(BuscartextBox.Text);
                    if (cCalificaciones.Buscar(id))
                    {
                        Mostrar();
                    }
                    else
                    {
                        Utility.Mensajes(3, "Id no Encontrado!");
                        BuscartextBox.Clear();
                    }
                }
                else
                {
                    Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
            
           
        }

    }
}
