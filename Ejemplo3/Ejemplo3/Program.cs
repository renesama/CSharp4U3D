using System;

namespace Ejemplo3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Suma miSuma = new Suma();
            Console.WriteLine("Ingresa 2 numeros");
            Console.WriteLine("Ingrea el valor 1");
            miSuma.setVal1(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrea el valor 2");
            miSuma.setVal2(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("La suma de " + miSuma.getVal1() + " mas " + miSuma.getVal2() + " es:  " + miSuma.suma());
        }
    }
}
