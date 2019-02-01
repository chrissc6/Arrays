using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var pgm = new ArrayOfInteger();
            pgm.Add(0, 42);
            pgm.Add(1, 25);
            pgm.Add(2, 97);
            pgm.Print();
        }
    }
}
