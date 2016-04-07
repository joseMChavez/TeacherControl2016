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
    public class UsuariosTests
    {
        

        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.nombre = "Jose";
            usuario.apellido = "Garcia";
            usuario.telefono = "8094884848";
            usuario.userName = "Josead";
            usuario.email = "Joe@gmail.com";
            usuario.direccion = "Cenovi";
            usuario.pass = "1234";
            usuario.passConfir = "1234";
            usuario.TipoUsuario = "Administrador";

            bool prueba = usuario.Insertar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.nombre = "Jose";
            usuario.apellido = "Garcia";
            usuario.telefono = "8094884848";
            usuario.userName = "Josead";
            usuario.email = "Joe@gmail.com";
            usuario.direccion = "Cenovi";
            usuario.pass = "1234";
            usuario.passConfir = "1234";
            usuario.TipoUsuario = "Administrador";

            bool prueba = usuario.Editar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.nombre = "Jose";
            usuario.apellido = "Garcia";
            usuario.telefono = "8094884848";
            usuario.userName = "Josead";
            usuario.email = "Joe@gmail.com";
            usuario.direccion = "Cenovi";
            usuario.pass = "1234";
            usuario.passConfir = "1234";
            usuario.TipoUsuario = "Administrador";
            usuario.Insertar();
            bool prueba = usuario.Eliminar();

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuario = new Usuarios();
            usuario.nombre = "Jose";
          
            usuario.Insertar();
            bool prueba = usuario.Buscar(1);

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarNombreTest()
        {
            Usuarios usuario = new Usuarios();
         
            usuario.userName = "Josead";

            usuario.Insertar();
            bool prueba = usuario.BuscarNombre("Josead");

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarAdministradorTest()
        {
            Usuarios usuario = new Usuarios();
          
            usuario.userName = "Josead";
            
            usuario.pass = "1234";
            
            usuario.TipoUsuario = "Administrador";
            usuario.Insertar();
            bool prueba = usuario.BuscarAdministrador("Josead", "1234");

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarPassTest()
        {
            Usuarios usuario = new Usuarios();
            
            usuario.pass = "1234";
            
            usuario.Insertar();
            bool prueba = usuario.BuscarPass("1234");

            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Usuarios usuario = new Usuarios();
            DataTable dt = new DataTable();
            usuario.userName = "Josead";

            usuario.pass = "1234";

            usuario.TipoUsuario = "Administrador";
            usuario.Insertar();
            dt = usuario.Listado("*","1=1","");
           

            Assert.IsTrue(dt.Rows.Count>0);
        }
    }
}