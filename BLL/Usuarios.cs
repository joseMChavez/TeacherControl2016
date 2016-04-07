using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
       public int usuarioId { get; set; }
       public string nombre { get; set; }
        public string apellido { get; set; }
        public string userName { get; set; }
       
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string pass { get; set; }
        public string passConfir { get; set; }
        public string TipoUsuario { get; set; }

        public Usuarios() {
            this.usuarioId = 0;
            this.nombre = "";
            this.apellido = "";
            this.userName = "";
            this.email = "";
            this.telefono = "";
            this.direccion = "";
            this.pass = "";
            this.TipoUsuario = "";
          

        }
        public Usuarios(int id, string nombre, string pass) {
            this.usuarioId = id;
            this.nombre = nombre;
            this.pass = pass;
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("insert into Usuario(nombre,apellido,userName,telefono,email,direccion,clave,confirmarClave,tipoUsuario) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", nombre, this.apellido,this.userName,this.telefono,this.email,this.direccion, this.pass,this.passConfir,this.TipoUsuario));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
      
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Usuario set nombre= '{0}',apellido = '{1}' ,userName='{2}',telefono='{3}',email='{4}',direccion='{5}',clave='{6}', confirmarClave='{7}', tipoUsuario='{8}' where usuarioId= {9}",this.nombre, this.apellido,this.userName, this.telefono ,this.email, this.direccion,this.pass, this.passConfir,this.TipoUsuario ,this.usuarioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
       
        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("delete from Usuario where usuarioId= {0} ", this.usuarioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where  usuarioId= {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.usuarioId = (int)dt.Rows[0]["usuarioId"];
                    this.nombre = dt.Rows[0]["nombre"].ToString();
                    this.apellido = dt.Rows[0]["apellido"].ToString();
                    this.userName = dt.Rows[0]["userName"].ToString();
                    this.telefono = dt.Rows[0]["telefono"].ToString();
                    this.email = dt.Rows[0]["email"].ToString();
                    this.direccion = dt.Rows[0]["direccion"].ToString();
                    this.pass = dt.Rows[0]["clave"].ToString();
                    this.passConfir = dt.Rows[0]["confirmarClave"].ToString();
                    this.TipoUsuario = dt.Rows[0]["tipoUsuario"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public bool BuscarNombre(string nombre)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where UserName= '{0}'", nombre));
                if (dt.Rows.Count>0)
                {
                    this.TipoUsuario = dt.Rows[0]["tipoUsuario"].ToString();
                    this.userName = dt.Rows[0]["userName"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public bool BuscarAdministrador(string nombre, string clave)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where userName= '{0}' AND clave='{1}' AND tipoUsuario='Administrador'", nombre, clave));
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public bool BuscarPass(string clave)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where clave='{0}'", clave));

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " order by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Usuario where " + Condicion + ordenFinal));
        }
    }
}
