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
    public class EstudiantesTests
    {
        
        [TestMethod()]
        public void InsertarTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.Matricula = 1;
            estudiante.Nombre = "jose";
            estudiante.Apellidos = "Chavez";
            estudiante.Genero = "M";
            estudiante.FechaNacimiento = "21/02/2000";
            estudiante.Edad = 15;
            estudiante.Celular = "809-844-2216";
            estudiante.Email = "jose@gmail.com";
            estudiante.Direccion = "Cenovi";
            estudiante.Curso = "";
            estudiante.Grupo = "B";
            
            bool prueba = estudiante.Insertar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 1;
            estudiante.Matricula = 5;
            estudiante.Nombre = "jose";
            estudiante.Apellidos = "Chavez";
            estudiante.Genero = "M";
            estudiante.FechaNacimiento = "21/02/2000";
            estudiante.Edad = 15;
            estudiante.Celular = "809-844-2216";
            estudiante.Email = "jose@gmail.com";
            estudiante.Direccion = "Cenovi";
            estudiante.Curso = "H34";
            estudiante.Grupo = "B";
        
            bool prueba = estudiante.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 1;
         
            bool prueba= estudiante.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Estudiantes estudiante = new Estudiantes();
          
            estudiante.Curso = "H45";
            estudiante.Grupo = "B";
            estudiante.Insertar();
            bool prueba = estudiante.Buscar(1);

            Assert.IsTrue(prueba);
        }
        [TestMethod()]
        public void BuscarMatriculaTest() {
            Estudiantes estudiante = new Estudiantes();
          
            estudiante.Matricula = 5;
       
            estudiante.Curso = "H45";
            estudiante.Grupo = "B";
            estudiante.Insertar();

            bool prueba = estudiante.BuscarMatricula(5, "H45", "B");

            Assert.IsTrue(prueba);
        }
        [TestMethod()]
        public void ListadoTest()
        {
            Estudiantes estudiante = new Estudiantes();
            DataTable dt = new DataTable();
           
            estudiante.Matricula = 1;
            estudiante.Nombre = "jose";
          
            estudiante.Insertar();

            dt = estudiante.Listado("*", "1=1", "");
            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}