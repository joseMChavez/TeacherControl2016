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
    public class UsuariosTests
    {
       

        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios usuario = new Usuarios();

            usuario.nombre = "jose";
            usuario.apellido = "Cha";
            usuario.direccion = "Cenovi";
            usuario.email = "Ejem@gmail.com";
           // usuario.telefono = "123456789";
            usuario.pass = "99990000";
            usuario.passConfir = "99990000";
            bool prueba = usuario.Insertar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarNombreTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarPassTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
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