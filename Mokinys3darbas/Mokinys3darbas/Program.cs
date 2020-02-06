using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysLibrary;

namespace Mokinys3darbas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mokinys D11 = new Mokinys(11,"Dominykas");
            D11.Pazymiai.Add(10);
            D11.Pazymiai.Add(8);
            D11.Pazymiai.Add(8);
            D11.Pazymiai.Add(9);
            D11.Pazymiai.Add(9);

            foreach (var item in D11.Pazymiai)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(D11.getVidurkis());

            Console.ReadLine();
        }
    }
}
