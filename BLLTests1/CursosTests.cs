using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class CursosTests
    {
       

        [TestMethod()]
        public void InsertarTest()
        {
            Cursos curso = new Cursos();
            curso.Descripcion = "Primero";
            bool prueba = curso.Insertar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Cursos curso = new Cursos();
            curso.CursoId = 1;
            curso.Descripcion = "Primero";
            bool prueba = curso.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Cursos curso = new Cursos();
         
            bool prueba = curso.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Cursos curso = new Cursos();
          
            curso.Descripcion = "Primero";
            curso.Insertar();
            bool prueba = curso.Buscar(1);
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarDescripcionTest()
        {
            Cursos curso = new Cursos();
            string Descripcion = "Primero";
            curso.Descripcion = "Primero";
            curso.Insertar();
            bool prueba = curso.BuscarDescripcion(Descripcion);
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Cursos curso = new Cursos();
            DataTable dt = new DataTable();
            curso.Descripcion = "Primero";
            curso.Insertar();
            dt = curso.Listado("*", "1=1", "");
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}