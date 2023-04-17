using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Loops
namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
             int sum;
             sum = 0;
             double avg;
             int i = 0;
             int n = 0;
            //For loop to compute the sum and verage of 6 numbers
            Console.WriteLine("***The For loop***");
            Console.WriteLine("Enter 6 Numbers : ");
             for (i = 1; i <= 6; i++)
             {
                 Console.Write("Number-{0} :", i);

                 n = int.Parse(Console.ReadLine());
                 sum += n;
             }
             avg = sum / 6.0;
             Console.Write("The sum of 6 numbers is : {0}\nThe Average is : {1}\n", sum, avg);



            //While loop to calculate the aregae and the sum of 5 numbers
            
            int total = 0;
            int count = 0;
            int num = 0;
            double average = 0.0;
            Console.WriteLine("***The While loop***");
            Console.WriteLine("Enter 5 Numbers");
            while(count<5)
            {
                count++;
                Console.Write("Number-{0}:", count);
                num = int.Parse(Console.ReadLine());
                total += num;
            }
            average = total / 5.0;
            Console.WriteLine("The total of this numbers are:{0}\n The average is :{1}\n", total,average);
        }
    }
}
