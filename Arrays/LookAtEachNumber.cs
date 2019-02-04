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
        //string msg; //defined in ternary operator
        int[] bowlingScores = { 22, 13, 28, 7, 23, 16, 20, 19, 26, 3 };
        //int totalScore; //class level variables will be be init with default values, but better to do yourself
        int[] grades = { 86, 97, 82, 91, 97, 82, 96, 81, 86, 97, 75, 99 };

        public void TotalSales()
        {
            double[] sales = { 428.14, 635.15, 923.60, 400.95, 823.50, 434.65, 911.34, 759.36 };
            double total = 0;
            double Max = 0;

            foreach (double i in sales)
            {
                if(i > Max)
                {
                    Max = i;
                }

                total += i;
            }
            Console.WriteLine($"Total sales is {total} \nMax is {Max}");

        }

        public void Squares()
        {
            int[] squares = { 12, 9, 2, 3, 13, 6, 10, 12, 14 };
            int total = 0;
            //int s = 0;

            foreach (int i in squares)
            {
                //s = i * i;
                //total += s;
                total += (i * i);
            }
            Console.WriteLine($"The square total is {total}");
        }

        public void RandomNumber()
        {
            int[] rndNbrs = { 77, 85, 43, 69, 99, 50, 24, 23, 76, 62, 58, 70, 47, 87, 22, 20, 52, 6, 34, 92 };
            int total = 0;

            foreach (int x in rndNbrs)
            {
                if(x % 3 == 0) //checking if divisible by 3
                {
                    total += x;
                }
            }
            Console.WriteLine($"Total is {total}");
        }

        public void Grades()
        {
            int total = 0;
            int i = 0;
            int avg = 0;

            foreach (int x in grades)
            {
                total += x;
                i++;
            }
            avg = total / i;
            Console.WriteLine($"Total is: {total}");
            Console.WriteLine($"Average grade is: {avg}");
            Console.WriteLine($"Average grade is: {total / i}"); //can do this instead of last statement, wouldnt need 'int avg'
        }


        public void BowlingGameScore()
        {
            int totalScore = 0;

            foreach (var x in bowlingScores)
            {
                //totalScore = x + totalScore;
                totalScore += x;
            }
            Console.WriteLine($"Total score: {totalScore}");
        }

        public void CheckNumbers()
        {
            foreach (var i in numbers) //'var' can be 'int?'
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
