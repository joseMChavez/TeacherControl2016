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
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int CursoId { get; set; }
        public string Grupo { get; set; }
        public string NombrePadre { get; set; }
        public string TelefonoPadre { get; set; }

        public List<CursosDetalle> cursosDetalle { get; set; }
        public Estudiantes()
        {
            this.EstudianteId = 0;
            this.Matricula = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.Genero = "";
            this.FechaNacimiento = "";
            this.Edad = 0;
            this.Celular = "";
            this.Email = "";
            this.Direccion = "";
            this.CursoId = 0;
            this.Grupo = "";
            this.NombrePadre = "";
            this.TelefonoPadre = "";
            this.cursosDetalle = new List<CursosDetalle>();
           
        }
        public Estudiantes(int Id, int Matricula, string Nombre, string Apellido, string Genero, string FechaNacimiento,int Edad, string Email, string Celular,  string Direcion,int CursoId, string Grupo, string Padre,string TellPadre)
        {
            this.EstudianteId = Id;
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.Apellidos = Apellido;
            this.Genero = Genero;
            this.FechaNacimiento = FechaNacimiento;
            this.Edad = Edad;
            this.Celular = Celular;
            this.Email = Email;
            this.Direccion = Direcion;
            this.CursoId = CursoId;
            this.Grupo = Grupo;
            this.NombrePadre = Padre;
            this.TelefonoPadre = TellPadre;
            
        }

        public override bool Insertar()
        {
            bool retorno = false;
            Cursos curso = new Cursos();
            
            try
            {

                   retorno= conexion.Ejecutar(string.Format("insert into Estudiante(Matricula,Nombre,Apellido,Genero,FechaNacimiento,Edad,Celular,Email, Direccion,CursoId,Grupo,NombrePadre,TelefonoPadre) values({0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}',{9},'{10}','{11}','{12}')select @@Identity", this.Matricula, this.Nombre, this.Apellidos, this.Genero, this.FechaNacimiento, this.Edad, this.Celular, this.Email, this.Direccion, this.CursoId, this.Grupo, this.NombrePadre, this.TelefonoPadre));

                if (retorno)
                {
                    conexion.Ejecutar(string.Format("insert into CursosDetalle(Descripcion,Curso,Nombre,Apellidos,Matricula) values('{0}',{1},'{2}','{3}',{4})", curso.Descripcion, this.CursoId, this.Nombre,this.Apellidos, this.Matricula));
                }
                   
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Editar()
        {
            bool retorno = false;
            Cursos curso = new Cursos();
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Estudiante set Matricula= {0}, Nombre= '{1}', Apellido='{2}', Genero= '{3}' , FechaNacimiento='{4}',Edad= {5}, Celular='{6}',Email='{7}',Direccion='{8}', CursoId={9}, Grupo='{10}', NombrePadre='{11}', TelefonoPadre='{12}' where EstudianteId= {13}", this.Matricula, this.Nombre, this.Apellidos, this.Genero, this.FechaNacimiento,this.Edad, this.Celular, this.Email, this.Direccion, this.CursoId, this.Grupo, this.NombrePadre, this.TelefonoPadre,this.EstudianteId));

                if (retorno)
                {
                    conexion.Ejecutar(string.Format("update CursosDetalle set Descripcion= '{0}', Curso={1},Nombre='{2}', Apellidos='{3}',Matricula={4} where Curso={5} where Id ={6}", curso.Descripcion, this.CursoId, this.Nombre, this.Apellidos, this.Matricula, this.EstudianteId));
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
                retorno = conexion.Ejecutar(string.Format("delete from Estudiante where EstudianteId= {0}", this.EstudianteId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("delete from CursosDetalle where Id={0}", this.EstudianteId));
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
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * From Estudiante where EstudianteId="+ IdBuscado));
                if (dt.Rows.Count>0)
                {
                    this.EstudianteId = (int)dt.Rows[0]["EstudianteId"];
                    this.Matricula = (int)dt.Rows[0]["Matricula"];
                    this.Nombre = dt.Rows[0]["Nombre"].ToString();
                    this.Apellidos = dt.Rows[0]["Apellido"].ToString();
                    this.Genero = dt.Rows[0]["Genero"].ToString();
                    this.FechaNacimiento = dt.Rows[0]["FechaNacimiento"].ToString();
                    this.Edad = (int)dt.Rows[0]["Edad"];
                    this.Celular = dt.Rows[0]["Celular"].ToString();
                    this.Email = dt.Rows[0]["Email"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();
                    this.CursoId = (int)dt.Rows[0]["CursoId"];
                    this.Grupo = dt.Rows[0]["Grupo"].ToString();
                    this.NombrePadre = dt.Rows[0]["NombrePadre"].ToString();
                    this.TelefonoPadre = dt.Rows[0]["TelefonoPadre"].ToString();

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
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Estudiante Where " + Condicion + ordenFinal);
        }
    }
}
