using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsLibrary;

namespace NamuDarbasUzuodis11
{
    class Program
    {
        static void Main(string[] args)
        {
            Identify I = new Identify("Dee","Bost", new DateTime(1996,12,12));
            Console.WriteLine(I.Vardas);
            Console.WriteLine(I.Pavarde);
            Console.WriteLine(I.BDay.Date);
            Console.WriteLine(I.getAge()); ;
            Console.ReadLine();
        }
    }
}
