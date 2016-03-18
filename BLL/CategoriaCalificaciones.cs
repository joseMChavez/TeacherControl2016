using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CategoriaCalificaciones : ClaseMaestra
    {
        
        public int CategoriaCalificacionesId { get; set; }
        public string Descripcion { get; set; }

        public CategoriaCalificaciones(int Id, string DescripcionCategoria)
        {
            this.CategoriaCalificacionesId = Id;
            this.Descripcion = DescripcionCategoria;
        }

        public CategoriaCalificaciones()
        {
            this.CategoriaCalificacionesId = 0;
            this.Descripcion = "";
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Insert Into CategoriaCalificaciones(Descripcion) values('{0}')", this.Descripcion));
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

                retorno = conexion.Ejecutar(String.Format(" Update CategoriaCalificaciones set Descripcion = '{0}' where CategoriaCalificacionesId = {1} ", this.Descripcion, this.CategoriaCalificacionesId));

            }
            catch (Exception exc)
            {
                throw exc;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {

                retorno = conexion.Ejecutar(String.Format(" delete from CategoriaCalificaciones where CategoriaCalificacionesId = {0}  ", this.CategoriaCalificacionesId));

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
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from CategoriaCalificaciones where CategoriaCalificacionesId= {0}", IdBuscado));
                if (datatable.Rows.Count > 0)
                {
                    this.CategoriaCalificacionesId = (int)datatable.Rows[0]["CategoriaCalificacionesId"];
                    this.Descripcion = datatable.Rows[0]["Descripcion"].ToString();
                }

            }
            catch (Exception exc)
            {

                throw exc;
            }
            return datatable.Rows.Count > 0;

        }
        public bool BuscarDescripcion(string DescripcionBuscada)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from CategoriaCalificaciones where Descripcion= '" + DescripcionBuscada + "'"));
              
            }
            catch (Exception exc)
            {

                throw exc;
            }
            return datatable.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From CategoriaCalificaciones Where " + Condicion + ordenFinal);
        }
    }
}
