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
       public string pass { get; set; }
       public string tipoUsuario { get; set; }
        ConexionDb conexion = new ConexionDb();
        public Usuarios() {
            this.usuarioId = 0;
            this.nombre = "";
            this.pass = "";
            this.tipoUsuario = "";

        }
        public Usuarios(int id, string nombre, string pass, string tipoUsuario) {
            this.usuarioId = id;
            this.nombre = nombre;
            this.pass = pass;
            this.tipoUsuario = tipoUsuario;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("insert into Usuario (nombre,clave,tipoUsuario) Values('{0}','{1}','{2}')", this.nombre, this.pass, this.tipoUsuario));
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
                retorno = conexion.Ejecutar(string.Format("update Usuario set nombre= '{0}', clave='{1}', tipoUsuario='{2}' where usuarioId= {3}",this.nombre, this.pass, this.tipoUsuario, this.usuarioId));
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
                    this.pass = dt.Rows[0]["clave"].ToString();
                    this.tipoUsuario = dt.Rows[0]["tipoUsuario"].ToString();
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
                dt = conexion.ObtenerDatos(string.Format("select * from Usuario where nombre= '"+nombre+"'" ));
                if (dt.Rows.Count > 0)
                {
                    this.usuarioId = (int)dt.Rows[0]["usuarioId"];
                    this.nombre = dt.Rows[0]["nombre"].ToString();
                    this.pass = dt.Rows[0]["clave"].ToString();
                    this.tipoUsuario = dt.Rows[0]["tipoUsuario"].ToString();
                }
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
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Usuario where " + Condicion + Orden));
        }
    }
}
