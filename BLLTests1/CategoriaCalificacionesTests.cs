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
    public class CategoriaCalificacionesTests
    {
       

        [TestMethod()]
        public void InsertarTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            cCalificaciones.Descripcion = "Participar";
             bool prueba=cCalificaciones.Insertar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            cCalificaciones.CategoriaCalificacionesId = 1;
            cCalificaciones.Descripcion = "Participar";
            bool prueba = cCalificaciones.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();

            cCalificaciones.Descripcion = "Participar";
             cCalificaciones.Insertar();
            bool prueba = cCalificaciones.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();

            cCalificaciones.Descripcion = "Participar";
            cCalificaciones.Insertar();
            bool prueba = cCalificaciones.Buscar(1);
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarDescripcionTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();

            cCalificaciones.Descripcion = "Participar";
            cCalificaciones.Insertar();
            bool prueba = cCalificaciones.BuscarDescripcion("Participar");
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            CategoriaCalificaciones cCalificaciones = new CategoriaCalificaciones();
            DataTable dt = new DataTable();
            cCalificaciones.Descripcion = "Participar";
            cCalificaciones.Insertar();
            dt = cCalificaciones.Listado("*","1=1","");
            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}