using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class IntNumber
    {
        private int d;
        public IntNumber(int _d)
        {
            d = _d;
        }

        public int Number
        {
            get
            {
                return d;
            }

            set
            {
                d = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("d = {0}", d);
        }
    }
}