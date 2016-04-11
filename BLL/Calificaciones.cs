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
        
        public int CalificacionId { get; set; }
        public string Estudiante { get; set; }
        public string Materia { get; set; }
        public string Curso { get; set; }
        public string CursoGrupo { get; set; }
        public string Fecha { get; set; }
        public int Matricula { get; set; }

        public string Descripcion { get; set; }
        public float Puntuacion { get; set; }
        public float TotalPuntos { get; set; }
        public List<CalificacionesDetalle> CalificaionesD { get; set; }
        public Calificaciones()
        {
            this.CalificacionId = 0;
            this.Estudiante = "";
            this.Matricula = 0;
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
        public void LimpiarLista() {
            CalificaionesD.Clear();
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            int retorno = 0;
            object identity;
            try
            {
                identity = conexion.ObtenerValor(string.Format("Insert into Calificaciones(Estudiante,Matricula,Materia,Curso,Cursogrupo,TotalPuntos,Fecha) values('{0}',{1},'{2}','{3}','{4}',{5},'{6}') select @@Identity", this.Estudiante,this.Matricula ,this.Materia, this.Curso, this.CursoGrupo, this.TotalPuntos,this.Fecha));
                retorno=Utility.ConvierteEntero(identity.ToString());
                this.CalificacionId = retorno;
          
                    foreach (CalificacionesDetalle detalle in CalificaionesD)
                    {
                        conexion.Ejecutar(string.Format("Insert into CalificacionDetalle(CalificacionId,Descripcion,Puntuacion) Values({0},'{1}',{2})", retorno, detalle.Descripcion, detalle.Puntuacion));
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
                retorno = conexion.Ejecutar(string.Format("update Calificaciones set Estudiante='{0}',Matricula={1}, Materia='{2}',Curso='{3}', Cursogrupo='{4}', TotalPuntos={5},  Fecha='{6}' where CalificacionId={7}", this.Estudiante,this.Matricula,this.Materia, this.Curso, this.CursoGrupo, this.TotalPuntos, this.Fecha, this.CalificacionId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete  from CalificacionDetalle where CalificacionId={0}", this.CalificacionId));
                    foreach (CalificacionesDetalle detalle in CalificaionesD)
                    {
                        conexion.Ejecutar(string.Format("Insert into CalificacionDetalle(CalificacionId,Descripcion,Puntuacion) Values({0},'{1}',{2})",this.CalificacionId, detalle.Descripcion, detalle.Puntuacion));
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
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable detalle = new DataTable();
            CalificacionesDetalle calificaionDetalle = new CalificacionesDetalle();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Calificaciones where CalificacionId={0}",IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    Estudiante = dt.Rows[0]["Estudiante"].ToString();
                    Materia = dt.Rows[0]["Materia"].ToString();
                    Curso = dt.Rows[0]["Curso"].ToString();
                    CursoGrupo = dt.Rows[0]["Cursogrupo"].ToString();
                    TotalPuntos = (float)Convert.ToDecimal(dt.Rows[0]["TotalPuntos"]);
                    Matricula = (int)dt.Rows[0]["Matricula"];
                    Fecha = dt.Rows[0]["Fecha"].ToString();
                    detalle = conexion.ObtenerDatos(string.Format("select * from CalificacionDetalle where CalificacionId={0}", IdBuscado));
                    detalle.Clear();
                    foreach (DataRow row in detalle.Rows)
                    {
                        
                        AgregarCalificaiones(row["Descripcion"].ToString(), (float)Convert.ToDecimal(row["Puntuacion"].ToString()));
                    }
                }
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
            DataTable dt = new DataTable();
            string ordenFinal = "";
            if (!Orden.Equals(""))
            {
                ordenFinal = "order by " + Orden;
            }
            return dt = conexion.ObtenerDatos(string.Format("select C.CalificacionId as Id,C.Estudiante,C.Matricula,C.Materia,CD.Descripcion Categoria,CD.Puntuacion,C.Curso,C.Cursogrupo as Grupo,C.TotalPuntos as Puntos,C.Fecha from Calificaciones as C inner join CalificacionDetalle as CD on C.CalificacionId=CD.CalificacionId  where " + Condicion + ordenFinal));

        }
    }
}
