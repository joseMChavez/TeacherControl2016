using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
     public class CursosDetalle
    {
        public int CursosDetalleId { get; set; }
     
        public int CursoId { get; set; }
        public string Descripcion{ get; set; }
        public int EstudianteId { get; set; }
        public int Matricula{ get; set; }

        public CursosDetalle()
        {
            this.CursosDetalleId = 0;
            this.Descripcion = "";
            this.EstudianteId = 0;
            this.Matricula = 0;
        }
        public CursosDetalle( string Descripcion, int EstudianteId, int Matricula)
        {
        
            this.Descripcion = Descripcion;
            this.EstudianteId = EstudianteId;
            this.Matricula = Matricula;
        }
        public DataTable ListadoNormal(string campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + campos + " From CursosDetalle where " + Condicion + ordenFinal);
        }

        public DataTable Listado(string campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select "+campos+ " From CursosDetalle where " + Condicion + ordenFinal);
        }


    }
}
