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
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
