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
       
        public int EstudianteId { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Curso { get; set; }
        public string Grupo { get; set; }
    

        public List<CursosDetalle> cursosDetalle { get; set; }
        public Estudiantes()
        {
            this.EstudianteId = 0;
            this.Matricula = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.Genero = "";
            this.NombreCompleto = "";
            this.FechaNacimiento = "";
            this.Edad = 0;
            this.Celular = "";
            this.Email = "";
            this.Direccion = "";
            this.Curso = "";
            this.Grupo = "";
          
            this.cursosDetalle = new List<CursosDetalle>();
           
        }
        public Estudiantes(int Id, int Matricula, string Nombre, string Apellido, string Genero, string FechaNacimiento,int Edad, string Email, string Celular,  string Direcion,string CursoId, string Grupo)
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
            this.Curso = CursoId;
            this.Grupo = Grupo;
          
            
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            Cursos curso = new Cursos();
            
            try
            {
                   retorno= conexion.Ejecutar(string.Format("insert into Estudiante(Matricula,Nombre,Apellido,NombreCompleto,Genero,FechaNacimiento,Edad,Celular,Email, Direccion,CursoId,Grupo) values({0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}')", this.Matricula, this.Nombre, this.Apellidos, this.NombreCompleto,this.Genero, this.FechaNacimiento, this.Edad, this.Celular, this.Email, this.Direccion, this.Curso, this.Grupo));

                if (retorno)
                {
                    conexion.Ejecutar(string.Format("insert into CursosDetalle(Grupo,Curso,Nombre,Apellidos,Matricula) values('{0}','{1}','{2}','{3}',{4})", this.Grupo, this.Curso, this.Nombre,this.Apellidos, this.Matricula));
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
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            Cursos curso = new Cursos();
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Estudiante set Matricula= {0}, Nombre= '{1}', Apellido='{2}',NombreCompleto='{3}', Genero= '{4}' , FechaNacimiento='{5}',Edad= {6}, Celular='{7}',Email='{8}',Direccion='{9}', CursoId='{10}', Grupo='{11}' where EstudianteId= {12}", this.Matricula, this.Nombre, this.Apellidos,this.NombreCompleto, this.Genero, this.FechaNacimiento,this.Edad, this.Celular, this.Email, this.Direccion, this.Curso, this.Grupo,this.EstudianteId));

                if (retorno)
                {
                    conexion.Ejecutar(string.Format("delete from CursosDetalle where Id={0}", this.EstudianteId));
                    conexion.Ejecutar(string.Format("insert into CursosDetalle(Grupo,Curso,Nombre,Apellidos,Matricula) values('{0}','{1}','{2}','{3}',{4})", this.Grupo, this.Curso, this.Nombre, this.Apellidos, this.Matricula));
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
            ConexionDb conexion = new ConexionDb();
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
                    this.Curso = dt.Rows[0]["CursoId"].ToString();
                    this.Grupo = dt.Rows[0]["Grupo"].ToString();
                  

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }
        public bool BuscarMatricula(int IdBuscado,string curso, string grupo)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * From Estudiante where Matricula={0} and CursoId='{1}' and Grupo='{2}'",IdBuscado,curso,grupo));
             
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
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Estudiante Where " + Condicion + ordenFinal);
        }
    }
}
