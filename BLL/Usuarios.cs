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
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string pass { get; set; }
        public string passConfir { get; set; }
     
        ConexionDb conexion = new ConexionDb();
        public Usuarios() {
            this.usuarioId = 0;
            this.nombre = "";
            this.apellido = "";
            this.email = "";
            this.telefono = "";
            this.direccion = "";
            this.pass = "";

          

        }
        public Usuarios(int id, string nombre, string pass) {
            this.usuarioId = id;
            this.nombre = nombre;
            this.pass = pass;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Usuario(nombre,apellido,email,direccion,telefono,clave,confirmarClave) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nombre, this.apellido,this.email,this.direccion,this.telefono, this.pass,this.passConfir));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
      
        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update Usuario set nombre= '{0}',apellido = '{1}' ,email='{2}',direccion='{3}',telefono = '{4}',clave='{5}', confirmarClave='{6}' where usuarioId= {7}",this.nombre, this.apellido, this.email, this.direccion, this.telefono,this.pass, this.passConfir, this.usuarioId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Buscar(int IdBuscado)
        {

            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where  usuarioId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.usuarioId = (int)dt.Rows[0]["usuarioId"];
                    this.nombre = dt.Rows[0]["nombre"].ToString();
                    this.apellido = dt.Rows[0]["apellido"].ToString();
                    this.email = dt.Rows[0]["email"].ToString();
                    this.direccion = dt.Rows[0]["direccion"].ToString();
                    this.telefono = dt.Rows[0]["telefono"].ToString();
                    this.pass = dt.Rows[0]["clave"].ToString();
                    this.passConfir = dt.Rows[0]["ConfirClave"].ToString();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count>0;

        }
        public  bool BuscarNombre(string nombre)
        {

            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where nombre= '{0}'",nombre ));
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public bool BuscarPass(string clave)
        {

            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where clave= '{0}'", clave));

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;

        }
        public override bool Eliminar()
        {
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

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " order by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Usuario where " + Condicion + ordenFinal));
        }
    }
}
