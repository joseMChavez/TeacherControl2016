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
        public string Curso { get; set; }
        public string EstudianteId { get; set; }
        public string CursoGrupo { get; set; }
        public int CantidadEst { get; set; }
        public string Activo { get; set; }
        public string Fecha { get; set; }
        public List<AsistenciaDetalle> aDetalle { get; set; }
        AsistenciaDetalle AsisDetalle = new AsistenciaDetalle();
        public Asistencia()
        {
            this.AsistenciaId = 0;
            this.Curso = "";
            this.EstudianteId = "";
            this.CursoGrupo = "";
            this.Activo = "";
            this.Fecha = "";
            aDetalle = new List<AsistenciaDetalle>();
        }
        public Asistencia(int Id, string Curso, string EstudianteId, string CursoGrupo, string Activo, string Fecha)
        {
            this.AsistenciaId = Id;
            this.Curso = Curso;
            this.EstudianteId = EstudianteId;
            this.CursoGrupo = CursoGrupo;
            this.Activo = Activo;
            this.Fecha = Fecha;
        }

        public void AgregarAsistencia(string estudiante, string Activo)
        {
            aDetalle.Add(new AsistenciaDetalle(estudiante, Activo));
        }
        public void LimpiarLista() {
            aDetalle.Clear();
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            object identity;
            int retorno = 0;
            try
            {
                identity = conexion.ObtenerValor(string.Format("Insert Into Asistencias(Curso,CursoGrupo,CantidaEst,Fecha) values('{0}','{1}',{2},'{3}') select @@Identity", this.Curso, this.CursoGrupo, this.CantidadEst, this.Fecha));
                retorno = Utility.ConvierteEntero(identity.ToString());
                this.AsistenciaId = retorno;

                foreach (AsistenciaDetalle asistenciaD in aDetalle)
                {
                    conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},'{1}','{2}')", retorno, asistenciaD.EstudianteId, asistenciaD.Activo));
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
                retorno = conexion.Ejecutar(string.Format("update Asistencias set Curso='{0}', CursoGrupo='{1}',CantidaEst={2}, Fecha='{3}' where AsistenciaId={4}", this.Curso, this.CursoGrupo, this.CantidadEst, this.Fecha, this.AsistenciaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete  from AsistenciaDetalle where AsistenciaId={0}", this.AsistenciaId));
                    foreach (AsistenciaDetalle asistenciaD in aDetalle)
                    {
                        conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},'{1}','{2}')", this.AsistenciaId, asistenciaD.EstudianteId, asistenciaD.Activo));
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
                retorno = conexion.Ejecutar(string.Format("Delete  from AsistenciaDetalle where AsistenciaId={0};" +
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
                dt = conexion.ObtenerDatos(string.Format("Select * from Asistencias where AsistenciaId = {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    AsistenciaId = (int)dt.Rows[0]["AsistenciaId"];
                    Curso = dt.Rows[0]["Curso"].ToString();
                    CursoGrupo = dt.Rows[0]["CursoGrupo"].ToString();
                    CantidadEst = (int)dt.Rows[0]["CantidaEst"];

                    detalle = conexion.ObtenerDatos(string.Format("Select * from AsistenciaDetalle where AsistenciaId={0}", IdBuscado));

                    detalle.Clear();
                    foreach (DataRow row in detalle.Rows)
                    {
                        AgregarAsistencia(row["EstudianteId"].ToString(), row["Activo"].ToString());
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
            return dt = conexion.ObtenerDatos(string.Format("" + Condicion + ordenFinal));

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
            return dt = conexion.ObtenerDatos(string.Format("select  A.AsistenciaId as Id,A.Curso, A.CursoGrupo as Grupo,AD.EstudianteId as Estudiante,AD.Activo as Estado,A.CantidaEst as Cantidad, A.Fecha from Asistencias as  A Inner join AsistenciaDetalle as AD ON A.AsistenciaId=AD.AsistenciaId where " + Condicion + ordenFinal));

        }
    }
}
