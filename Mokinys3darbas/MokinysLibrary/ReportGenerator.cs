using System;
using System.Collections.Generic;
using System.Text;

namespace MokinysLibrary
{
    public class ReportGenerator
    {
        private MokinioRepositorija _mokinioRepositorija;

        public ReportGenerator(MokinioRepositorija mokinioRepositorija)
        {
            this._mokinioRepositorija = mokinioRepositorija;
        }
        
        public string GeneruotiMokiniuAtaskaita()
        {
            string result = "";

            List<Mokinys> visiMokiniai = _mokinioRepositorija.Retrieve();
            foreach (var item in visiMokiniai)
            {
                result = result + "Mokinio ID: " + item.ID + ", Vardas " + item.Vardas + Environment.NewLine;
            }
            return result;
        }
    }
}
