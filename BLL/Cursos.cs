using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Cursos : ClaseMaestra
    {
       
        public int CursoId { get; set; }
        public string Descripcion { get; set; }

        public Cursos(int Id, string DescripcionCategoria)
        {
            this.CursoId = Id;
            this.Descripcion = DescripcionCategoria;
        }

        public Cursos()
        {
            this.CursoId = 0;
            this.Descripcion = "";
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Insert Into Curso(Descripcion) values('{0}')", this.Descripcion));
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

                retorno = conexion.Ejecutar(String.Format(" Update Curso set Descripcion = '{0}' where CursoId = {1} ", this.Descripcion, this.CursoId));

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

                retorno = conexion.Ejecutar(String.Format(" delete from Curso where CursoId = {0}  ", this.CursoId));

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
                datatable = conexion.ObtenerDatos(string.Format("select * from Curso where CursoId= {0}", IdBuscado));
                if (datatable.Rows.Count > 0)
                {
                    this.CursoId = (int)datatable.Rows[0]["CursoId"];
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
                datatable = conexion.ObtenerDatos(string.Format("select * from Curso where Descripcion= '" + DescripcionBuscada + "'"));
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

            return conexion.ObtenerDatos("Select " + Campos + " From Curso Where " + Condicion + Orden);
        }
    }
}
