using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginner
{
    class Program
    {
        static void writeStep(string step)
        {
            Console.WriteLine("\n\n==============\n");
            Console.WriteLine(" [  "+ step +"  ] ");
            Console.WriteLine("\n==============\n");
        }
        static void Main(string[] args)
        {
            // # hello world
            Program.writeStep("hello world");
            Console.WriteLine("Hello World .. !");


            // # Differnece between Console.Write and Console.WriteLine
            Program.writeStep("difference 'Write' with 'WriteLine'");
            Console.Write("Write");
            Console.WriteLine("WriteLine");

            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");

            Console.WriteLine("WriteLine");
            Console.Write("Write");
        }
    }
}
