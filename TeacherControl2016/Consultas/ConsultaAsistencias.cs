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
    public partial class ConsultaAsistencias : Form
    {
        public ConsultaAsistencias()
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
            if (FiltrocomboBox.SelectedIndex==0)
            {
                Utility.TextBoxNuemericos(e);
                BuscartextBox.MaxLength = 5;
            }
            else
            {
                Utility.TextBoxSoloTexto(e);
                BuscartextBox.MaxLength = 45;
            }
            Utility.Enter(e, BuscarButton);
        }

        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void MostrarxFecha(Asistencia asistencia)
        {
            string filtro = "A.Fecha between " + DesdedateTimePicker.Text + " and " + HastadateTimePicker.Text;

            AsistenciaDataGridView.DataSource = asistencia.Listado("", filtro, "");

            TotaltextBox.Text = AsistenciaDataGridView.RowCount.ToString();
        }
        private void Mostrar(Asistencia asistencia)
        {
            
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    filtro = "A.AsistenciaId like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex == 1)
                {
                    filtro = "AD.Estudiante like '%" + BuscartextBox.Text + "%'";
                }
                else
                {
                    filtro ="A."+ FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

            }

            AsistenciaDataGridView.DataSource = asistencia.Listado("", filtro, "");
          

            TotaltextBox.Text = AsistenciaDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            int id = 0;
            if (ActivarcheckBox.Checked)
            {
                MostrarxFecha(asistencia);
                ImprimirButton.Enabled = true;
            }
            else
            {
                if (FiltrocomboBox.SelectedIndex == 0 && !BuscartextBox.Text.Equals(""))
                {
                   id= Utility.ConvierteEntero(BuscartextBox.Text);
                    if (asistencia.Buscar(id))
                    {
                        Mostrar(asistencia);
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
                    Mostrar(asistencia);
                    ImprimirButton.Enabled = true;
                }
            } 
        }

        private void ActivarcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            if (ActivarcheckBox.Checked)
            {
                FiltrocomboBox.Enabled = false;
            }
            else
                FiltrocomboBox.Enabled = true;

        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReporteForm.ReportViewGenerico reporte = new ReporteForm.ReportViewGenerico();
            DataTable dt = new DataTable();
            dt = (DataTable)AsistenciaDataGridView.DataSource;
            dt.TableName = "Asistencias";

            reporte.reporte = "AsistenciaReport.rdlc";
            reporte.data = dt;

            reporte.ShowDialog();

        }
    }
}
