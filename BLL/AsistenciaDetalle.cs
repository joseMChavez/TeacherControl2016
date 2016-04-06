using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AsistenciaDetalle
    {
        public int Id { get; set; }
        public string EstudianteId { get; set; }
        public string Activo { get; set; }
        public int Matricula { get; set; }

        public AsistenciaDetalle()
        {
            this.Id = 0;
            this.EstudianteId = "";
            this.Activo = "";
            this.Matricula = 0;
        }
        public AsistenciaDetalle(string EstudianteId, string Activo,int Matricula)
        {
            this.EstudianteId = EstudianteId;
            this.Activo = Activo;
            this.Matricula = Matricula;
        }

    }
}
