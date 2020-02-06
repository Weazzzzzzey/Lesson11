using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLib
{
    public class Book
    {
        public int ID { get; private set; }
        public string Pavadinimas { get; private set; }
        public int PerKiekDienuGrazinti { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime PaemimoData { get; set; }

        public decimal Delspinigiai { get; private set; }
        public int lateDays { get; private set; }

        

        public Book(int id, string pavadinimas, int perkiekD, string sName, DateTime paemimoD)
        {
            this.ID = id;
            this.Pavadinimas = pavadinimas;
            this.PerKiekDienuGrazinti = perkiekD;
            this.SkaitytojoVardas = sName;
            this.PaemimoData = paemimoD;
            this.Delspinigiai = 0.5m;
        }

        public bool backOnTime()
        {
            int alreadydays = DateTime.Now.Subtract(PaemimoData).Days;

            lateDays = (PerKiekDienuGrazinti - alreadydays) * -1;

            if (PerKiekDienuGrazinti > alreadydays)
            {
                return true;
            }
            else
                return false;
        }

        public decimal delspiningiaiCount()
        {
            decimal lateSum = 0;
            if (backOnTime() == false) 
            {
                lateSum = lateDays * Delspinigiai;
                return lateSum;
            }
            else
            return 0;
        }
    }
}
