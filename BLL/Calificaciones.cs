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
        public int MateriaId { get; set; }
        public int CursoId { get; set; }
        public string CursoGrupo { get; set; }
        public string Fecha { get; set; }

        public Calificaciones()
        {
            this.CalificacionId = 0;
            this.MateriaId = 0;
            this.CursoId = 0;
            this.CursoGrupo = "";
            this.Fecha = "";
        }
        public Calificaciones(int CalificacionId, int MateriaId, int CursoId, string CursoGrupo,string Fecha)
        {
            this.CalificacionId = CalificacionId;
            this.MateriaId = MateriaId;
            this.CursoId = CursoId;
            this.CursoGrupo = CursoGrupo;
            this.Fecha = Fecha;
        }
        public override bool Insertar()
        {
            throw new NotImplementedException();
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
