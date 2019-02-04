using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LookAtEachNumber
    {
        int?[] numbers = { 1, 2, 3, null, 4, 5 };
        //string msg;

        public void CheckNumbers()
        {
            foreach (var i in numbers) //var can be int?
            {
                if (i != null)
                {
                    var msg = (i % 2 == 0) ? "even" : "odd";
                    Console.WriteLine(msg);

                }
                else
                {
                    var msg = "null";
                    Console.WriteLine(msg);
                }
                    
            }

        }
    }
}
