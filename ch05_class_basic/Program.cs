using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ch05_class_basic
{
    class Car
    {
        string carNumber;
        DateTime inTime;
        DateTime outTime;

        public void setInTime(string carNumber)
        {
            this.carNumber = carNumber;
            this.inTime = DateTime.Now; 
        }
        public void setOutTime()
        {
            this.outTime = DateTime.Now;
        }
        public void checkTime()
        {
            string info = "carNumber : " + this.carNumber;
            info += "\ninTime : " + this.inTime.ToString();
            info += "\noutTime : " + this.outTime.ToString();
            Console.WriteLine(info);
        }
    }

    class Book
    {
        public string name;
        public DateTime initialRelease;
        public string author;
        public string publisher;
        public string publishCompany;
        public string producer;
        public string planner;
        public string editor;
        public string designer;
    }

    class Program
    {
        static void Main(string[] args)
        {
            RapidClass rc = new RapidClass();
            Random r = new Random();
            Car[] cars = new Car[10];
            cars[0] = new Car();
            string randomNumber = r.Next(1,9).ToString();
            randomNumber += r.Next(0, 9).ToString();
            randomNumber += r.Next(0, 9).ToString();
            randomNumber += r.Next(0, 9).ToString();
            cars[0].setInTime("12가 " + randomNumber);
            
            cars[0].setOutTime();
            cars[0].checkTime();

            List<RapidClass> list = new List<RapidClass>();
            rc.name = "Rapid Man";
            rc.age = 13;
            list.Add(rc);
            list.ForEach(Print);
            
            void Print(RapidClass item)
            {
                Console.WriteLine(item.name + " ( " + item.age + " ) ");
            }

            // Form1 myForm = new Form1();
            // myForm.ShowDialog();

            Book book = new Book();
            book.name = "PHP 프로그래밍 입문";
            book.initialRelease = new DateTime(2013, 5, 20);
            book.author = "황재호";
            book.publisher = "김태헌";
            book.publishCompany = "한빛아카데미(주)";
            book.producer = "김현용";
            book.planner = "김이화";
            book.editor = "김이화";
            book.designer = "여동일";

            Console.WriteLine(
                "도서명     : " + book.name + "\n" +
                "초판발행일 : " + book.initialRelease + "\n" +
                "지은이     : " + book.author + "\n" +
                "펴낸이     : " + book.publisher + "\n" +
                "펴낸곳     : " + book.publishCompany + "\n" +
                "책임편집   : " + book.producer + "\n" +
                "기획       : " + book.planner + "\n" +
                "편집       : " + book.editor + "\n" +
                "디자인     : " + book.designer + "\n"
                );
        }

       
    }
}
