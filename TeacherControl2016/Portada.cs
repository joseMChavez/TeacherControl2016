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
using DAL;

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
            FechaLabel.Text = DateTime.Now.ToShortDateString();
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

        private void categoriaDeCalificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCategoriaCalificaiones cCCalificaciones = new Consultas.ConsultaCategoriaCalificaiones();
            cCCalificaciones.Show();
        }

        private void AsistenciatoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.AsistenciasForm asistencia = new Registros.AsistenciasForm();
            asistencia.Show();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.AsistenciasForm asistencia = new Registros.AsistenciasForm();
            asistencia.Show();
        }


        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CalificacionesForm calificaciones = new Registros.CalificacionesForm();
            calificaciones.Show();
        }

        private void CalificacionestoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.CalificacionesForm calificaciones = new Registros.CalificacionesForm();
            calificaciones.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("¿Esta Seguro que Desea Salir?", "Teacher Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void asistenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaAsistencias asistencia = new Consultas.ConsultaAsistencias();

            asistencia.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
            login.Limpiar();
        }

        private void evaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaEvaluacion evaluacion = new Consultas.ConsultaEvaluacion();

            evaluacion.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.Mensajes(1, "Teacher Control Fue Creado por Jose M. Chavez Ortiz \nPara Mas Informaciòn llamar al 809-844-2216");
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteForm.ReporteUsuarios usuarios = new ReporteForm.ReporteUsuarios();
            usuarios.Show();
        }

        private void estudiantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteForm.EstudiantesReport estudiante = new ReporteForm.EstudiantesReport();
            estudiante.Show();
        }

        private void cursosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteForm.CursosReportes curso = new ReporteForm.CursosReportes();
            curso.Show();
        }

        private void estudiantePorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteForm.EstudianteCursoReporte EstCurso = new ReporteForm.EstudianteCursoReporte();
            EstCurso.Show();
        }

        private void asistenciasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteForm.AsistenciaReporForm asistencia = new ReporteForm.AsistenciaReporForm();
            asistencia.Show();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteForm.EvaluacionesReporForm evaluacion = new ReporteForm.EvaluacionesReporForm();
            evaluacion.Show();
        }
    }
}
