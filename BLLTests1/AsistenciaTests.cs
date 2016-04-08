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
    public class AsistenciaTests
    {
      

       

        [TestMethod()]
        public void InsertarTest()
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDetalle asistenciaD = new AsistenciaDetalle();

            asistencia.Curso = "prueba";
            asistencia.CursoGrupo = "1";
            asistencia.CantidadEst = 10;

            asistenciaD.EstudianteId = "Juan";
            asistenciaD.Matricula = 10;
            asistenciaD.Activo = "P";

            bool prueba = asistencia.Insertar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDetalle asistenciaD = new AsistenciaDetalle();
            asistencia.AsistenciaId = 1;
            asistencia.Curso = "prueba";
            asistencia.CursoGrupo = "1";
            asistencia.CantidadEst = 10;

            asistenciaD.EstudianteId = "Juan";
            asistenciaD.Matricula = 10;
            asistenciaD.Activo = "A";

            bool prueba = asistencia.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDetalle asistenciaD = new AsistenciaDetalle();
            asistencia.AsistenciaId = 1;
            asistencia.Curso = "prueba";
            asistencia.CursoGrupo = "1";
            asistencia.CantidadEst = 10;

            asistenciaD.EstudianteId = "Juan";
            asistenciaD.Matricula = 10;
            asistenciaD.Activo = "A";
           
            bool prueba = asistencia.Eliminar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDetalle asistenciaD = new AsistenciaDetalle();
         
            asistencia.Curso = "prueba";
            asistencia.CursoGrupo = "1";
            asistencia.CantidadEst = 10;

            asistenciaD.EstudianteId = "Juan";
            asistenciaD.Matricula = 10;
            asistenciaD.Activo = "A";
            asistencia.Insertar();
            bool prueba = asistencia.Buscar(1);

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Asistencia asistencia = new Asistencia();
            AsistenciaDetalle asistenciaD = new AsistenciaDetalle();
            DataTable dt = new DataTable();
            asistencia.Curso = "prueba";
            asistencia.CursoGrupo = "1";
            asistencia.CantidadEst = 1;

            asistenciaD.EstudianteId = "Juan";
            asistenciaD.Matricula = 10;
            asistenciaD.Activo = "A";
            asistencia.Insertar();

            dt = asistencia.Listado("*","1=1","");

            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}