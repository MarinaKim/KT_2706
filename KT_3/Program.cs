using KT_3.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Human h = new Human();
            var t = p.Brain;
            p.month = 12;
            p.FullName = "Ivanov Ivan";
            Console.WriteLine(p.ShortName);
        }
    }
}
