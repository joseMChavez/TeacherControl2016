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
    public partial class ConsultaEvaluacion : Form
    {
        public ConsultaEvaluacion()
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
        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void BuscartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 0)
            {
                Utility.TextBoxNuemericos(e);
            }
            else
            {
                Utility.TextboxAlfaNumerico(e);
            }
        }
        private void ActivarcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivarcheckBox.Checked)
            {
                FiltrocomboBox.Enabled = false;
            }
            else
            {
                FiltrocomboBox.Enabled = true;
            }
        }
        private void MostrarxFecha(Calificaciones calificacion)
        {
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    filtro = "A.Fecha between" + DesdedateTimePicker.Text + " and " + HastadateTimePicker.Text;
                }
            }
            EvaluacionDataGridView.DataSource = calificacion.Listado("",filtro,"");

            TotaltextBox.Text = EvaluacionDataGridView.RowCount.ToString();
        }
        private void Mostrar(Calificaciones calificacion)
        {

            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    filtro = "Calificacion" + FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else
                {
                    filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

            }

            EvaluacionDataGridView.DataSource = calificacion.Listado("CalificaonId as Id,Estudiante,Materia,Curso,Cursogrupo as Grupo,TotalPuntos as Puntos,Promedio,Fecha", filtro, "");

            TotaltextBox.Text = EvaluacionDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
