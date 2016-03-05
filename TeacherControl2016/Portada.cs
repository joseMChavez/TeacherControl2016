﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherControl2016
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm usuarios = new Registros.UsuariosForm();
            usuarios.Show();

        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registros.EstudiantesForm estudiantes = new Registros.EstudiantesForm();
            estudiantes.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.EstudiantesForm estudiantes = new Registros.EstudiantesForm();
            estudiantes.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CursosForm cursos = new Registros.CursosForm();
            cursos.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Registros.CursosForm cursos = new Registros.CursosForm();
            cursos.Show();
        }

        private void cursosPorEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEstudianteCursos cEstudiante = new Consultas.ConsultaEstudianteCursos();
            cEstudiante.Show();
        }
    }
}
