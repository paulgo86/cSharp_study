using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch06_method
{
    class Program
    {
        class Hoi
        {
            string name;
            public Hoi(string name)
            {
                this.name = name;
                Console.WriteLine(this.name + " 호이 생성~");
            }
            ~Hoi() {
                Console.WriteLine(this.name+" 호이 소멸~");
            }
        }

        static void Main(string[] args)
        {
            // Hoi h = new Hoi("호호호");
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
