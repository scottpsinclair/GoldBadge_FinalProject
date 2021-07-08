using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge
{
    public class Badge
    {
        static void Main(string[] args)
        {
            List<string> lstBadges = new List<string>();
            lstBadges.Add("A1");
            lstBadges.Add("A2");
            lstBadges.Add("A3");
            lstBadges.Add("B1");
            lstBadges.Add("B2");
            lstBadges.Add("B3");
        }

        public int BadgeID
        {
            get; set;
        }

        public string DoorName
        {
            get; set;
        }

        

        public Badge() { }
        public Badge(int badgeID, string doorName)
        {
            BadgeID = badgeID;
            DoorName = doorName;
        }
    }
}
