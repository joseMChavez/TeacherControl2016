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
    public class GruposTests
    {
       

        [TestMethod()]
        public void InsertarTest()
        {
            Grupos grupo = new Grupos();
           
            grupo.Descripcion = "A";
            bool prueba = grupo.Insertar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Grupos grupo = new Grupos();
            grupo.Descripcion = "A";
            bool prueba = grupo.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Grupos grupo = new Grupos();
          
            bool prueba = grupo.Eliminar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Grupos grupo = new Grupos();

            grupo.Descripcion = "A";
            grupo.Insertar();
            bool prueba = grupo.Buscar(1);

            Assert.IsTrue(prueba);
           
        }

        [TestMethod()]
        public void BuscarDescripcionTest()
        {
            Grupos grupo = new Grupos();

            grupo.Descripcion = "A";
            grupo.Insertar();
            bool prueba = grupo.BuscarDescripcion("A");

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Grupos grupo = new Grupos();
            DataTable dt = new DataTable();
            grupo.Descripcion = "A";
            grupo.Insertar();
            dt = grupo.Listado("*", "1=1", "");

            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}