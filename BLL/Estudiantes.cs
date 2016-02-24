using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Estudiantes : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int EstudianteId { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int TutorId { get; set; }
        public Estudiantes()
        {
            this.EstudianteId = 0;
            this.Matricula = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.Genero = "";
            this.FechaNacimiento = "";
            this.Celular = "";
            this.Email = "";
            this.Direccion = "";
            this.TutorId = 0;
           
        }
        public Estudiantes(int Id, int Matricula, string Nombre, string Apellido, string Genero, string FechaNacimiento, string Email, string Celular,  string Direcion,int TutorId)
        {
            this.EstudianteId = Id;
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.Apellidos = Apellido;
            this.Genero = Genero;
            this.FechaNacimiento = FechaNacimiento;
            this.Celular = Celular;
            this.Email = Email;
            this.Direccion = Direcion;
            this.TutorId = TutorId;
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
