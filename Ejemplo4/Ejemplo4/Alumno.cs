using System;
namespace Ejemplo4
{
	public class Alumno
    {
        Int32 matricula;
        public Alumno(Int32 matricula)
        {
            this.matricula = matricula;
        }
        public String Nombre { get; set; }
        public String ApePat { get; set; }
        public String ApeMat { get; set; }
    }
}
