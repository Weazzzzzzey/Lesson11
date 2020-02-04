using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibrary
{
    public class Identify
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public DateTime BDay { get; private set; }

        public Identify(string vardas, string pavarde, DateTime bday)
        {
            this.Vardas = vardas;
            this.Pavarde = pavarde;
            this.BDay = bday.Date;
        }

        public int getAge()
        {
            int age = 0;

            age = DateTime.Now.Year - BDay.Year;

            return age;
        }
    }
}
