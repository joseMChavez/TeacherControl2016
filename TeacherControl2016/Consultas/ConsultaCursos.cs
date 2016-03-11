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
    public partial class ConsultaCursos : Form
    {
        public ConsultaCursos()
        {
            InitializeComponent();
            DesactivarMenuContextual();

        }
        public void DesactivarMenuContextual()
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
            Cursos curso = new Cursos();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            CursoEstDataGridView.DataSource = curso.Listado("CursoId,Descripcion", filtro, "");

            TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
        }
    }
}
