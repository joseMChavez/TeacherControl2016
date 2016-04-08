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
            Utility.Enter(e, BuscarButton);
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
            string filtro = filtro = "C.Fecha between " + DesdedateTimePicker.Text + " and " + HastadateTimePicker.Text;

            EvaluacionDataGridView.DataSource = calificacion.Listado("", filtro, "");

            TotaltextBox.Text = EvaluacionDataGridView.RowCount.ToString();
        }
        private void Mostrar(Calificaciones calificacion)
        {

            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    filtro = "C.Calificacion" + FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else
                {
                    filtro = "C."+FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

            }

            EvaluacionDataGridView.DataSource = calificacion.Listado("", filtro, "");

            TotaltextBox.Text = EvaluacionDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Calificaciones calificacion = new Calificaciones();
            int id = 0;
            if (ActivarcheckBox.Checked)
            {
                MostrarxFecha(calificacion);
                ImprimirButton.Enabled = true;
            }
            else
            {
                if (FiltrocomboBox.SelectedIndex == 0 && !BuscartextBox.Text.Equals(""))
                {
                    id = Utility.ConvierteEntero(BuscartextBox.Text);
                    if (calificacion.Buscar(id))
                    {
                        Mostrar(calificacion);
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
                    Mostrar(calificacion);
                    ImprimirButton.Enabled = true;
                }
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteForm.ReportViewGenerico reporte = new ReporteForm.ReportViewGenerico();
            DataTable dt = new DataTable();

            dt = (DataTable)EvaluacionDataGridView.DataSource;
            dt.TableName = "Calificaciones";

            reporte.reporte = "EvaluacionesReport.rdlc";
            reporte.data = dt;

            reporte.ShowDialog();
        }
    }
}
