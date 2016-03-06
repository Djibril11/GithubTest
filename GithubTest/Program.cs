using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im goint to demonstrate a addition program");

            Console.WriteLine("choose first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("choose second number");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("The answer is {0}", result);
            
            
            bool mother = false;
            bool fucked = true;
            if (mother!= fucked)
            {
                mother = fucked
            }
            

            Console.ReadKey();
        }
    }
}
