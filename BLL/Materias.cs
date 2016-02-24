using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Materias : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int MatediaId { get; set; }
        public string Descripcion { get; set; }
        public Materias()
        {
            this.MatediaId = 0;
            this.Descripcion = "";
        }
        public Materias(int MateriaId, string Descripcion)
        {
            this.MatediaId = MatediaId;
            this.Descripcion = Descripcion;
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
