using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();
        private Utility utility = new Utility();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise? GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                { return merchandise; }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Merchandise merchandise in merchandises)
            {
                total += utility.GetValueOfMerchandise(merchandise);
            }
            return total;
        }
    }
}

