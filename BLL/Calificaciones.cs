using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Calificaciones : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int CalificacionId { get; set; }
        public string Estudiante { get; set; }
        public string Materia { get; set; }
        public string Curso { get; set; }
        public string CursoGrupo { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public float Puntuacion { get; set; }
        public List<CalificacionesDetalle> CalificaionesD { get; set; }
        public Calificaciones()
        {
            this.CalificacionId = 0;
            this.Estudiante = "";
            this.Materia = "";
            this.Curso = "";
            this.CursoGrupo = "";
            this.Fecha = "";
            this.Descripcion = "";
            this.Puntuacion = 0;
            this.CalificaionesD = new List<CalificacionesDetalle>();
        }
        public Calificaciones(int CalificacionId,string Estudiante, string MateriaId, string CursoId, string CursoGrupo,string Fecha)
        {
            this.CalificacionId = CalificacionId;
            this.Estudiante = Estudiante;
            this.Materia = MateriaId;
            this.Curso = CursoId;
            this.CursoGrupo = CursoGrupo;
            this.Fecha = Fecha;
        }

        public void AgregarCalificaiones(string Descripcion, float Puntos)
        {
            CalificaionesD.Add(new CalificacionesDetalle(Descripcion, Puntos));
        }
       
        public override bool Insertar()
        {
            throw new NotImplementedException();
        }
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Calificaciones set Estudiante='{0}', Materia='{1}',Curso='{2}', Cursogrupo='{3}', Fecha='{4}' where CalificacionId={5}",this.Estudiante,this.Materia, this.Curso, this.CursoGrupo, this.Fecha, this.CalificacionId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete  from CalificacionDetalle where AsistenciaId={0}", this.CalificacionId));
                    foreach (CalificacionesDetalle detalle in CalificaionesD)
                    {
                        conexion.Ejecutar(string.Format("Insert into CalificacionDetalle(CalificacionId,Descripcion,Puntuacion) Values({0},'{1}',{2})",this.CalificacionId,this.Descripcion,this.Puntuacion));
                    }

                }
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
                retorno = conexion.Ejecutar(string.Format("Delete  from CalificacionDetalle where CalificacionId={0};" +
                                                 "Delete  from Calificaciones where CalificacionId={0}", this.CalificacionId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            string ordenFinal = "";
            if (!Orden.Equals(""))
            {
                ordenFinal = "order by " + Orden;
            }
            return dt = conexion.ObtenerDatos(string.Format("select " + Campos + " from Calificaciones where " + Condicion + ordenFinal));

        }
    }
}
