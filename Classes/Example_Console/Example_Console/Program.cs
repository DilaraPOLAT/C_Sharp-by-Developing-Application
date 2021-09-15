using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Heloo");
             Console.Write("World");

            string word = "15 August 2021";
             Console.WriteLine(word);

            int age = 21;
            Console.WriteLine(age);
            Console.Read(); 

            Message ms = new Message();
            ms.text();
            Console.Read();

            Persons pr = new Persons();
            String ns;
            Console.Write("Name Surname Enter:");
            ns=Console.ReadLine();
            pr.personList(ns);
            Console.Read();

            Process prc = new Process();
            prc.sum(10, 20);
            prc.square(6);
            
            String value;
            Console.Write("Name-club:");
            value = Console.ReadLine();
            Student std = new Student(value);
            Console.Read();
            */
            identity idn = new identity();
            idn.NAME = "Dilara";
            idn.SURNAME = "Polat";
            idn.HOMETOWN = "Elazığ";

            Console.WriteLine(idn.NAME);
            Console.WriteLine(idn.SURNAME);
            Console.WriteLine(idn.HOMETOWN);
            Console.WriteLine(idn.AGE);
            Console.WriteLine(idn.GENDER);
            Console.Read();

        }
    }
}
