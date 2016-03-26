using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            estudiante.CursoId = "";
            estudiante.Grupo = "B";
            estudiante.NombrePadre = "Juan";
            estudiante.TelefonoPadre = "809-844-2216";
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
            estudiante.CursoId = "";
            estudiante.Grupo = "B";
            estudiante.NombrePadre = "Juan";
            estudiante.TelefonoPadre = "809-844-2216";
            bool prueba = estudiante.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
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
            estudiante.CursoId = "";
            estudiante.Grupo = "B";
            estudiante.NombrePadre = "Juan";
            estudiante.TelefonoPadre = "809-844-2216";

            bool prueba= estudiante.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}