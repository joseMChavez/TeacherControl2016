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
    public partial class ConsultaMaterias : Form
    {
        public ConsultaMaterias()
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
            Materias materia = new Materias();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
            }

            CursoEstDataGridView.DataSource = materia.Listado("MateriaId,Descripcion", filtro, "");

            TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
        }
    }
}
