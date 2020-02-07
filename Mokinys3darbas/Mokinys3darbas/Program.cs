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
            Mokinys D11 = new Mokinys(11,"Dominykas",false);
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


            MokinioRepositorija repo = new MokinioRepositorija();

            List<Mokinys> daugMokiniu = repo.Retrieve();
            foreach (var item in daugMokiniu)
            {
                Console.WriteLine("{0} - {1} - OW - {2}",item.Vardas,item.ID,item.OlyNugaletjoas);
            }
            Console.WriteLine("{0} - {1} - OW - {2}", repo.Retrieve(03).ID, repo.Retrieve(03).Vardas, repo.Retrieve(03).OlyNugaletjoas);

            ReportGenerator RG = new ReportGenerator(repo);
            Console.WriteLine(RG.GeneruotiMokiniuAtaskaita());
            
            Console.ReadLine();
        }
    }
}
