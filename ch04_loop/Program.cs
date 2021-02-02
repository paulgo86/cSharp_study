using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ch04_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            


            // move snail
            /*
            int x = 1;
            while (x < 50)
            {
                string snail = "";
                switch (x%3)
                {
                    case 0:
                        snail = "__@";
                        break;
                    case 1:
                        snail = "_^@";
                        break;
                    case 2:
                        snail = "^_@";
                        break;
                    default:
                        snail = "???";
                        break;
                }
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                Console.WriteLine(snail);
                Thread.Sleep(100);
                x++;
            }
            */

            // bidirection asterisk tree
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                int validCount = 0;
                for (int j = 0; j < length; j++)
                {

                    if ((length - i - 1) <= j)
                    {
                        validCount++;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = validCount - 1; 0 < j; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // ant number sequence
            string prevEl = "1";
            string nextEl = "";
            for (int i = 0; i < 20; i++)
            {                
                char current = prevEl[0];
                int count = 1;
                for( int j =1; j<prevEl.Length; j++)
                {
                    if(prevEl[j] == current)
                    {
                        count++;
                        continue;
                    }
                    else
                    {
                        nextEl += current.ToString() + count.ToString();
                        current = prevEl[j];
                        count = 1;
                    }                    
                }
                nextEl += current.ToString() + count.ToString();
                Console.WriteLine(nextEl);
                prevEl = nextEl;
                nextEl = "";
            }
        }
    }
}
