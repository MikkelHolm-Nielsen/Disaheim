using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        private Utility utility = new Utility();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet? GetAmulet(string itemId)
        {
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                { return amulet; }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Amulet amulet in amulets)
            {
                total += utility.GetValueOfAmulet(amulet);
            }
            return total;
        }
    }
}

