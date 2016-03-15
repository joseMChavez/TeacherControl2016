﻿using System;
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
        ConexionDb conexion = new ConexionDb();
        public int AsistenciaId { get; set; }
        public int CursoId { get; set; }
        public int EstudianteId { get; set; }
        public string CursoGrupo { get; set; }
        public string Activo { get; set; }
        public List<AsistenciaDetalle> aDetalle { get; set; }
        public Asistencia()
        {
            this.AsistenciaId = 0;
            this.CursoId = 0;
            this.EstudianteId = 0;
            this.CursoGrupo = "";
            this.Activo = "";
            aDetalle = new List<AsistenciaDetalle>();
        }
        public Asistencia(int Id, int CursoId, int EstudianteId,string CursoGrupo, string Activo)
        {
            this.AsistenciaId = Id;
            this.CursoId = CursoId;
            this.EstudianteId = EstudianteId;
            this.CursoGrupo = CursoGrupo;
            this.Activo = Activo;
        }

        private void AgregarAsistencia(int estudianteId,string Activo)
        {
            aDetalle.Add(new AsistenciaDetalle(estudianteId, Activo));
        }
        public override bool Insertar()
        {
            object identity;
            int retorno = 0;
            try
            {
                identity = conexion.ObtenerValor(string.Format("Insert Into Asistencias(CursoId,CursoGrupo) values({0},'{1}') select @@Identity", this.CursoId,this.CursoGrupo));
                int.TryParse(identity.ToString(), out retorno);
                this.AsistenciaId = retorno;
                if (retorno>0)
                {
                    foreach (AsistenciaDetalle asistenciaD in aDetalle)
                    {
                        conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},{1},'{2}')", retorno, this.EstudianteId, this.Activo));
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
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Asistencias set CursoId={0}, CursoGrupo='{1}' where AsistenciaId={2}", this.CursoId, this.CursoGrupo, this.AsistenciaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete * from AsistenciaDetalle where AsistenciaId={0}", this.AsistenciaId));
                    foreach (AsistenciaDetalle asistenciaD in aDetalle)
                    {
                        conexion.Ejecutar(string.Format("Insert into AsistenciaDetalle(AsistenciaId,EstudianteId,Activo) Values({0},{1},'{2}')",this.AsistenciaId, this.EstudianteId, this.Activo));
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
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Delete * from Asistencias where AsistenciaId={0}", AsistenciaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete * from AsistenciaDetalle where AsistenciaId={0}", this.AsistenciaId));
                }
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
            DataTable detalle = new DataTable();
            AsistenciaDetalle asisDetalle = new AsistenciaDetalle();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("Select * from Asistencias where AsistenciaId={0}", this.AsistenciaId));
                if (dt.Rows.Count> 0)
                {
                    CursoId = (int)dt.Rows[0]["cursoId"];
                    CursoGrupo= dt.Rows[0]["CursoGrupo"].ToString();
                    detalle = conexion.ObtenerDatos(string.Format("Select * from AsistenciaDetalle where AsistenciaId={0}", this.AsistenciaId));
                    foreach  (DataRow row in dt.Rows)
                    {
                        asisDetalle.Id = (int)row["Id"];
                        asisDetalle.EstudianteId = (int)row["EstudianteId"];
                        asisDetalle.Activo = row["Activo"].ToString();
                        aDetalle.Add(asisDetalle);
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
