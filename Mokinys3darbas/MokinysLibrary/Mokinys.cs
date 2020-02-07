using System;
using System.Collections.Generic;

namespace MokinysLibrary
{
    public class Mokinys
    {
        public int ID { get; private set; }
        public string Vardas { get; private set; }
        public List<int> Pazymiai { get; set; }
        public bool OlyNugaletjoas { get; private set; }

        public Mokinys(int id, string vardas, bool olyWin)
        {
            this.ID = id;
            this.Vardas = vardas;
            this.OlyNugaletjoas = olyWin;
            this.Pazymiai = new List<int>();
        }

        public decimal getVidurkis()
        {
            decimal sum = 0;
            
            if (Pazymiai.Count >= 1)
            {
                foreach (var item in Pazymiai)
                {
                    sum = sum + item;
                }
                decimal vidurkis = sum / Pazymiai.Count;

                return vidurkis;

            }
            else return 0;
        }
    }
}
