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

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEstudiantes estudiante = new Consultas.ConsultaEstudiantes();
            estudiante.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios usuarios = new Consultas.ConsultaUsuarios();
            usuarios.Show();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCursos cursos = new Consultas.ConsultaCursos();
            cursos.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.MateriasForm materia = new Registros.MateriasForm();
            materia.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Registros.MateriasForm materia = new Registros.MateriasForm();
            materia.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Registros.CategoriaCalificacionesForm cCalificaciones = new Registros.CategoriaCalificacionesForm();
            cCalificaciones.Show();
        }

        private void categoriaDeCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CategoriaCalificacionesForm cCalificaciones = new Registros.CategoriaCalificacionesForm();
            cCalificaciones.Show();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaMaterias cMaterias = new Consultas.ConsultaMaterias();
            cMaterias.Show();
        }
    }
}
