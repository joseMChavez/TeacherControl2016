﻿using System;
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
        }

        private void FiltrocomboBox_TextChanged(object sender, EventArgs e)
        {
            BuscartextBox.ReadOnly = false;
        }
        private void Mostrar(Asistencia asistencia)
        {
            
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                if (FiltrocomboBox.SelectedIndex == 0)
                {
                    filtro = "Asistencia" + FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else if (FiltrocomboBox.SelectedIndex == 1)
                {
                    filtro = "Estudiante" + FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }
                else
                {
                    filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

            }

            AsistenciaDataGridView.DataSource = asistencia.ListadoUnido(filtro, "Id");

            TotaltextBox.Text = AsistenciaDataGridView.RowCount.ToString();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            int id = 0;
            if (FiltrocomboBox.SelectedIndex==0 && !BuscartextBox.Text.Equals(""))
            {
                id = Utility.ConvierteEntero(BuscartextBox.Text);
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
}
