using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL.Tests
{
    [TestClass()]
    public class CalificacionesTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Calificaciones calificacion = new Calificaciones();
            CalificacionesDetalle calificacionD = new CalificacionesDetalle();
            
            calificacion.Curso = "Prueba";
            calificacion.CursoGrupo = "1";
            calificacion.Estudiante = "Jose";
            calificacion.Materia = "Math";
            calificacion.Matricula = 9;

            calificacionD.Descripcion = "Asistencia";
            calificacionD.Puntuacion = 10;
            bool prueba= calificacion.Insertar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Calificaciones calificacion = new Calificaciones();
            CalificacionesDetalle calificacionD = new CalificacionesDetalle();
            calificacion.CalificacionId = 1;
            calificacion.Curso = "Prueba";
            calificacion.CursoGrupo = "1";
            calificacion.Estudiante = "Jose";
            calificacion.Materia = "Math";
            calificacion.Matricula = 9;

            calificacionD.Descripcion = "Asistencia";
            calificacionD.Puntuacion = 10;
            bool prueba = calificacion.Editar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Calificaciones calificacion = new Calificaciones();
            
            bool prueba = calificacion.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Calificaciones calificacion = new Calificaciones();
            CalificacionesDetalle calificacionD = new CalificacionesDetalle();

            calificacion.Curso = "Prueba";
            calificacion.CursoGrupo = "1";
            calificacion.Estudiante = "Jose";
            calificacion.Materia = "Math";
            calificacion.Matricula = 9;

            calificacionD.Descripcion = "Asistencia";
            calificacionD.Puntuacion = 10;
            calificacion.Insertar();
            bool prueba = calificacion.Buscar(1);
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Calificaciones calificacion = new Calificaciones();
            CalificacionesDetalle calificacionD = new CalificacionesDetalle();
            DataTable dt = new DataTable();


            calificacion.CalificacionId = 1;
            calificacion.Curso = "Prueba";
            calificacion.CursoGrupo = "1";
            calificacion.Estudiante = "Jose";
            calificacion.Materia = "Math";
            calificacion.Matricula = 9;

            calificacionD.CalificacionesId = 1;
            calificacionD.Descripcion = "Asistencia";
            calificacionD.Puntuacion = 10;
            calificacion.Insertar();

            dt = calificacion.Listado("*", "1=1", "");

            Assert.IsTrue(dt.Rows.Count >= 0);
        }
    }
}