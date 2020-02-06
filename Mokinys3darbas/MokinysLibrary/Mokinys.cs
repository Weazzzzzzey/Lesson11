using System;
using System.Collections.Generic;

namespace MokinysLibrary
{
    public class Mokinys
    {
        public int ID { get; private set; }
        public string Vardas { get; private set; }
        public List<int> Pazymiai { get; set; }

        public Mokinys(int id, string vardas)
        {
            this.ID = id;
            this.Vardas = vardas;
            this.Pazymiai = new List<int>();
        }

        public decimal getVidurkis()
        {
            decimal sum = 0;

            foreach (var item in Pazymiai)
            {
                sum = sum + item;
            }
            decimal vidurkis = sum / Pazymiai.Count;

            return vidurkis;
        }

        
    }
}
