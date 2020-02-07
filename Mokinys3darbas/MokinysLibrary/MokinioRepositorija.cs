using System;
using System.Collections.Generic;
using System.Text;

namespace MokinysLibrary
{
    public class MokinioRepositorija
    {
        private List<Mokinys> mokiniai;

        public MokinioRepositorija()
        {
            mokiniai = new List<Mokinys>();
            mokiniai.Add(new Mokinys(01,"Tom",false));
            mokiniai.Add(new Mokinys(02,"John",false));
            mokiniai.Add(new Mokinys(03,"Jack",false));
            mokiniai.Add(new Mokinys(04,"Dome",true));
            mokiniai.Add(new Mokinys(05,"Tim",false));
            
        }

        public List<Mokinys> Retrieve()
        {
            return mokiniai;
        }

        public Mokinys Retrieve(int mokID)
        {
            foreach (var item in mokiniai)
            {
                if (mokID == item.ID)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
