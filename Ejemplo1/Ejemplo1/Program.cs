using System;

namespace Ejemplo1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			String text;
            HelloFromClass saludo = new HelloFromClass();
            Console.WriteLine("Hello give me your name");
            text = Console.ReadLine();
            Console.WriteLine(saludo.Greeting(text));
        }
    }
}
