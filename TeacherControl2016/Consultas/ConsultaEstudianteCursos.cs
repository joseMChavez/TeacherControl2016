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
    public partial class ConsultaEstudianteCursos : Form
    {
        public ConsultaEstudianteCursos()
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
            
                CursosDetalle curso = new CursosDetalle();
                string filtro = "1=1";

                if (BuscartextBox.Text.Length > 0)
                {
                    filtro = FiltrocomboBox.Text + " like '%" + BuscartextBox.Text + "%'";
                }

                CursoEstDataGridView.DataSource = curso.Listado("Curso as Id ,Descripcion as Descripción ,Nombre as Nombres,Apellidos,Matricula", filtro, "");

                TotaltextBox.Text = CursoEstDataGridView.RowCount.ToString();
            
        }
    }
}
