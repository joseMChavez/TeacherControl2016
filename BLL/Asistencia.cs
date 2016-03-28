using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Asistencia : ClaseMaestra
    {
        
        public int AsistenciaId { get; set; }
        public string CursoId { get; set; }
        public string EstudianteId { get; set; }
        public string CursoGrupo { get; set; }
        public string Activo { get; set; }
        public string Fecha { get; set; }
        public List<AsistenciaDetalle> aDetalle { get; set; }

        public Asistencia()
        {
            this.AsistenciaId = 0;
            this.CursoId = "";
            this.EstudianteId = "";
            this.CursoGrupo = "";
            this.Activo = "";
            this.Fecha = "";
            aDetalle = new List<AsistenciaDetalle>();
        }
        public Asistencia(int Id,string CursoId, string EstudianteId,string CursoGrupo, string Activo, string Fecha)
        {
            this.AsistenciaId = Id;
            this.CursoId = CursoId;
            this.EstudianteId = EstudianteId;
            this.CursoGrupo = CursoGrupo;
            this.Activo = Activo;
            this.Fecha = Fecha;
        }

        public void AgregarAsistencia(string estudiante,string Activo)
        {
            aDetalle.Add(new AsistenciaDetalle(estudiante, Activo));
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            object identity;
            int retorno = 0;
            try
            {
                identity = conexion.ObtenerValor(string.Format("Insert Into Asistencias(Curso,CursoGrupo,Fecha) values('{0}','{1}','{2}') select @@Identity", this.CursoId,this.CursoGrupo,this.Fecha));
                retorno = Utility.ConvierteEntero(identity.ToString());
                this.AsistenciaId = retorno;
                if (retorno>0)
                {
                    foreach (AsistenciaDetalle asistenciaD in aDetalle)
                    {
                        conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},'{1}','{2}')", retorno, this.EstudianteId, this.Activo));
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno > 0;
        }
       
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Asistencias set Curso='{0}', CursoGrupo='{1}', Fecha='{2}' where AsistenciaId={3}", this.CursoId, this.CursoGrupo, this.Fecha,this.AsistenciaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete  from AsistenciaDetalle where AsistenciaId={0}", this.AsistenciaId));
                    foreach (AsistenciaDetalle asistenciaD in aDetalle)
                    {
                        conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},'{1}','{2}')",this.AsistenciaId, this.EstudianteId, this.Activo));
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
               retorno = conexion.Ejecutar(string.Format("Delete  from AsistenciaDetalle where AsistenciaId={0};"+
                                                "Delete  from Asistencias where AsistenciaId={0}", this.AsistenciaId));
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
            DataTable detalle = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("Select * from Asistencias where AsistenciaId={0}", IdBuscado));
                if (dt.Rows.Count> 0)
                {
                    CursoId = dt.Rows[0]["Curso"].ToString();
                    CursoGrupo= dt.Rows[0]["CursoGrupo"].ToString();
                    detalle = conexion.ObtenerDatos(string.Format("Select * from AsistenciaDetalle where AsistenciaId={0}", IdBuscado));
                    detalle.Clear();
                    if (detalle.Rows.Count > 0)
                    {
                        foreach (DataRow row in detalle.Rows)
                        {
                            this.EstudianteId = row["EstudianteId"].ToString();
                            this.Activo = row["Activo"].ToString();
                            AgregarAsistencia(row["EstudianteId"].ToString(), row["Activo"].ToString());
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }
        public DataTable ListadoUnido(string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            string ordenFinal = "";
            if (!Orden.Equals(""))
            {
                ordenFinal = "order by " + Orden;
            }
            return dt = conexion.ObtenerDatos(string.Format("select A.Curso, A.CursoGrupo as Grupo,AD.EstudianteId as Estudiante,AD.Activo as Estado, A.Fecha from Asistencias as  A Inner join AsistenciaDetalle as AD ON A.AsistenciaId=AD.AsistenciaId where " + Condicion + ordenFinal));

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
            return dt = conexion.ObtenerDatos(string.Format("select "+Campos+" from Asistencias where "+Condicion+ordenFinal));

        }
    }
}
