﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherControl2016.ReporteForm
{
    public partial class CursosReportes : Form
    {
        public CursosReportes()
        {
            InitializeComponent();
        }

        private void CursosForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacherControlDbDataSetGenerico.Curso' table. You can move, or remove it, as needed.
            //this.cursoTableAdapter.Fill(this.teacherControlDbDataSetGenerico.Curso);

            this.CursosreportViewer.RefreshReport();
        }
    }
}
