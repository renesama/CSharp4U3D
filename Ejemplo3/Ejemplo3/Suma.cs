using System;
namespace Ejemplo3
{
	public class Suma{
        int val1;
        int val2;
        public Suma()
        {

        }
        public Suma(int i)
        {

        }

        public Suma(int a, int b)
        {

        }
        public int getVal1()
        {
            return val1;
        }
        public int getVal2()
        {
            return val2;
        }
        public void setVal1(int val1)
        {
            this.val1 = val1;
        }
        public void setVal2(int val2)
        {
            this.val2 = val2;
        }
        public int suma(int val1, int val2)
        {
            return val1 + val2;
        }
        public int suma()
        {
            return val1 + val2;
        }
        public int resta()
        {
            return val1 - val2;
        }

    }
}
