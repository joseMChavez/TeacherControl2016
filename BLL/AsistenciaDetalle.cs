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

        public AsistenciaDetalle()
        {
            this.Id = 0;
            this.EstudianteId = "";
            this.Activo = "";
        }
        public AsistenciaDetalle(string EstudianteId, string Activo)
        {
            this.EstudianteId = EstudianteId;
            this.Activo = Activo;
        }

    }
}
