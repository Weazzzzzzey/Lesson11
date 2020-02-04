using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class ReportGenerator
    {
        private List<User> _userList;

        public ReportGenerator(List<User> useriai)
        {
            this._userList = useriai;
        }

        public List<ReportItem> Generate()
        {
            List<ReportItem> ataskaitosEilutes = new List<ReportItem>();
            
            for (int i = 0; i < _userList.Count(); i++)
            {
                ReportItem ri = new ReportItem(_userList[i].UserId, _userList[i].UserName, _userList[i].GetRightsCode());
                ataskaitosEilutes.Add(ri);
            }

            return ataskaitosEilutes;
        }

        public List<ReportItem> Generate(int rightID)
        {
            List<ReportItem> ataskaitosEilutes = new List<ReportItem>();
            
            for (int i = 0; i < _userList.Count(); i++)
            {
                if (rightID == _userList[i].getRightID())
                {
                    ReportItem ri = new ReportItem(_userList[i].UserId, _userList[i].UserName, _userList[i].GetRightsCode());
                    ataskaitosEilutes.Add(ri);
                }
            }

            return ataskaitosEilutes;
        }

    }
}
