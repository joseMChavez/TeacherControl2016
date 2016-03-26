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
            ImprimirButton.Enabled = false;

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
        private void Mostrar(Cursos curso)
        {
          
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex==0)
                {
                    filtro = "Curso" + FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else
                {
                    filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                
            }

            CursoEstDataGridView.DataSource = curso.Listado("CursoId as Id ,Descripcion as Descripción", filtro, "");

            TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            int id = 0;
            try
            {
                if (FiltrocomboBox.SelectedIndex == 0 && !BuscartextBox.Text.Equals(""))
                {
                    id = Utility.ConvierteEntero(BuscartextBox.Text);
                    if (curso.Buscar(id))
                    {
                        Mostrar(curso);
                        ImprimirButton.Enabled = true;
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
                    Mostrar(curso);
                    ImprimirButton.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteForm.CursosReportes reporte = new ReporteForm.CursosReportes();
           
            reporte.ShowDialog();
        }
    }
}
