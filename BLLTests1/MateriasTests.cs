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
    public class MateriasTests
    {
      

        [TestMethod()]
        public void InsertarTest()
        {
            Materias materias = new Materias();
            materias.Descripcion = "Sociales";
            bool prueba = materias.Insertar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Materias materias= new Materias();
            materias.MateriaId = 1;
            materias.Descripcion = "Sociales";
            bool prueba = materias.Editar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Materias materias = new Materias();
         
            bool prueba = materias.Eliminar();
            Assert.IsTrue(prueba); ;
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Materias materias = new Materias();
            
            materias.Descripcion = "Sociales";
            materias.Insertar();

            bool prueba = materias.Buscar(1);
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarDescripcionTest()
        {
            Materias materias = new Materias();
            
            materias.Descripcion = "Sociales";
            materias.Insertar();

            bool prueba = materias.BuscarDescripcion("Sociales");
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Materias materia = new Materias();
            DataTable dt = new DataTable();
            materia.Descripcion = "Sociales";
            materia.Insertar();

            dt = materia.Listado("*", "1=1", "");
            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}