using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person yannick = new Person();
            yannick.FirstName = "Yannick";
            yannick.LastName = "Beterams";
            Person.PeopleCount++;
            yannick.Show();

            Person yannick1 = new Person()
            {
                FirstName = "Yannick",
                LastName = "Beterams"
            };
            Person.PeopleCount++;
            yannick1.Show();

            var joeri = new Person();
            joeri.FirstName = "Joeri";
            joeri.LastName = "Pardon";
            Person.PeopleCount++;
            joeri.Show();

            var joeri1 = new Person()
            {
                FirstName = "Joeri",
                LastName = "Pardon"
            };
            Person.PeopleCount++;
            joeri1.Show();


        }
    }
    public class Person
    {
        public static int PeopleCount = 0;
        public string FirstName;
        public string LastName;

        public void Show()
        {
            Console.WriteLine($"Welcome tot the C# course {FirstName} {LastName}.");
        }
    }
}
