using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayOfInteger
    {
        //data
        private int[] integers = new int[10];   //array

        //methods
        public void Add(int index, int value)
        {
            integers[index] = value;
        }

        public int Get(int index)
        {
            return integers[index];
        }


        public void Print()
        {
            int total = 0; 
            var comma = ""; //added just to not have extra comma at the end
            foreach(var i in integers)
            {
                total += i;
                Console.Write($"{comma}{i}");
                comma = ", ";
                
            }
            
            Console.WriteLine($" Total is {total}"); //moving press any key down a line
        }
    }
}
