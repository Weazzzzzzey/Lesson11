using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class ReportItem
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string RightCode { get; private set; }

        public ReportItem(int id, string name, string rightcode)
        {
            this.ID = Convert.ToString(id);
            this.Name = name;
            this.RightCode = rightcode;
        }

    }
}
