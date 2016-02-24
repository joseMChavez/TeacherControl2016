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
        public string Accion { get; set; }//Esta Presente, Ausente o tiene Excusas
        public Asistencia()
        {
            this.AsistenciaId = 0;
            this.CursoId = 0;
            this.EstudianteId = 0;
            this.Accion = "";
        }


        public override bool Buscar(int IdBuscado)
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

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
