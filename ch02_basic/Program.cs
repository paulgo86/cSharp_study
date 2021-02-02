using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch02_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // String
            Console.WriteLine("Hello C# Programming ... ! >_< ");

            // Process Order
            Console.WriteLine(5 + 3 * 2);

            // Rest
            Console.WriteLine(10 % 3);

            // Divide
            Console.WriteLine(5 / 3);

            // RealNumber
            Console.WriteLine(5.0 / 3);
            Console.WriteLine(5 / 3.0);

            // Character
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('ㄱ');

            // EscapeCharacter \
            Console.WriteLine("tab\ttab");
            Console.WriteLine("nextLine\nnextLine");
            Console.WriteLine("backSlash = \\");
            Console.WriteLine("doubleQoute = \"");

            // String index
            string myStr = "영일이삼사오육칠팔구십";
            Console.WriteLine("myStr[0]" + myStr[0]);
            Console.WriteLine("myStr[4]" + myStr[4]);
            Console.WriteLine("myStr[7]" + myStr[7]);
            Console.WriteLine("myStr[10]" + myStr[10]);

            // Get Type            
            Console.WriteLine("(2.5).GetType() = " + (2.5).GetType());

            // ReadLine
            // Console.Write("글자 입력 : ");
            // string input = Console.ReadLine();
            // Console.WriteLine("input : " + input);

            // Parse string to number
            float fVar = float.Parse("12.0");
            double dVar = double.Parse("12.0");
            Console.WriteLine(fVar + " : " + fVar.GetType());
            Console.WriteLine(dVar + " : " + dVar.GetType());

            // ToString number to string
            double number = 52.123123;
            Console.WriteLine(number.ToString());
            Console.WriteLine(number.ToString("0.0"));

            Console.WriteLine("\n======================\n");
            Console.WriteLine(" Practice ");
            Console.WriteLine("\n======================\n");

            // ex_1. return cm when input inch
            Console.WriteLine("ex_1. return cm when input inch\n");
            Console.Write("input inch : ");
            string input = Console.ReadLine();
            double inch = double.Parse(input);
            Console.WriteLine(inch + " inch = " + inch * 2.54 + "cm\n\n");

            // ex_2. return pound when input kg
            Console.WriteLine("ex_2. return pound when input kg\n");
            Console.Write("input pound : ");
            input = Console.ReadLine();
            double kg = double.Parse(input);
            Console.WriteLine(kg + " kg = " + kg * 2.20462262 + " pound\n\n");

            // ex_3. return circle's circumference and area when input radius
            Console.WriteLine("ex_3. return circle's circumference and area when input radius\n");
            Console.Write("input radius : ");
            input = Console.ReadLine();
            double radius = double.Parse(input);
            Console.WriteLine("r = " + radius + ", circumference = " + radius * 2 * Math.PI + ", area = " + radius * radius * Math.PI);


        }
    }
}
