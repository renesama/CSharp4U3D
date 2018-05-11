using System;
namespace Ejemplo2
{
    public class Operations
    {
		private int val1;
        private int val2;
        public Operations(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public int Adition()
        {
            return val1 + val2;
        }

        public int Substraction()
        {
            return val1 - val2;
        }
    }
}
