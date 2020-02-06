using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLibrary
{
    public class BooksLibrary
    {
        public int ID { get; private set; }
        public string Pavadinimas { get; private set; }
        public int PerKiekDienuGrazinti { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime PaemimoData { get; set; }

        public BooksLibrary(int id, string pavadinimas, int perkiekD,string sName, DateTime paemimoD)
        {
            this.ID = id;
            this.Pavadinimas = pavadinimas;
            this.PerKiekDienuGrazinti = perkiekD;
            this.SkaitytojoVardas = sName;
            this.PaemimoData = paemimoD;
        }

        public bool backOnTime()
        {
            int alreadydays = PaemimoData.Subtract(DateTime.Now).Days;

            if (PerKiekDienuGrazinti > alreadydays)
            {
                return true;
            }
            else
                return false;
        }
    }
}
