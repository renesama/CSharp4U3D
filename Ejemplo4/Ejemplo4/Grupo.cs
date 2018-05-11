using System;
namespace Ejemplo4
{
	public class Grupo
    {
        Int32 Matricula = 20180012;
        Alumno[] array = new Alumno[5];

        public void ingresaAlumnos()
        {
            String nombre;
            String apePat;
            String apeMat;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa Nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa Apellido Paterno");
                apePat = Console.ReadLine();
                Console.WriteLine("Ingresa Apellido Materno");
                apeMat = Console.ReadLine();
                Alumno k = new Alumno(Matricula + i)
                {
                    Nombre = nombre,
                    ApePat = apePat,
                    ApeMat = apeMat
                };
                array[i] = k;


            }
        }

        public void mustraAlumnos()
        {
            foreach (Alumno actual in array)
            {
                Console.WriteLine(actual.Nombre + " " + actual.ApePat + " " + actual.ApeMat);
            }
        }
    }
}
