using System;

namespace Ejemplo2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string val1, val2;
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter the first number");
            val1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            val2 = Console.ReadLine();
            Operations myOperations = new Operations(Int32.Parse(val1), Int32.Parse(val2));
            Console.WriteLine("La suma es:" + myOperations.Adition());
            Console.WriteLine("La resta es:" + myOperations.Substraction());
        }
    }
}
