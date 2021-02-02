using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03_condition
{
    class Program
    {
        static void Main(string[] args)
        {

            // ConsoleKeyInfo - getKey Value
            /*
            bool flag = false;
            while (!flag)
            {
                ConsoleKeyInfo inputKey = Console.ReadKey();
                
                if(inputKey.KeyChar == 'q')
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine(inputKey.KeyChar);
                }
            }
            */

            // Year to Zodiac sign
            string[] signals= { "쥐","소","호랑이","토끼","용","뱀","말","양","원숭이","닭","개","돼지" };
            Console.Write("태어난 연도 입력 : ");
            int birthYear = int.Parse(Console.ReadLine());
            int signalYear = (birthYear - 4) % 12;
            Console.WriteLine(" [ " + birthYear + " ] " + signals[signalYear] + " 띠 입니다.");

            // get season in Korea with Month
            string[] seasons = { "봄", "여름", "가을", "겨울" };
            Console.Write("월 입력 : ");
            string input = Console.ReadLine();
            int month = int.Parse(input);
            if(month < 3)
            {
                month += 12;
            }
            month -= 2;
            month /= 3;

            Console.WriteLine(input + " 월은 " + seasons[month] + " 입니다.");

            // make switch
            Console.Write("input grade : ");
            int grade = int.Parse(Console.ReadLine());
            int credit = 0;
            switch (grade)
            {
                case 1:
                    credit = 12;
                    break;
                case 2:
                case 4:
                    credit = 18;
                    break;
                case 3:
                    credit = 10;
                    break;
                default:
                    Console.WriteLine("input grade ( 1 ~ 4 ) ");
                    break;
            }
            Console.WriteLine("Required Major Credit : " + credit);

        }
    }
}
