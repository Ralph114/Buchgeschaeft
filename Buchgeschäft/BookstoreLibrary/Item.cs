using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary
{
    public abstract class Item
    {
        protected decimal Price;
        private int Stock;
        public string Title { get; }

        public Item(decimal price, int stock, string title)
        {
            Price = price;
            Stock = stock;
            Title = title;
        }

        public bool TryPurchase(int number)
        {
            if (number >0)
            {
                Stock += number;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TrySell(int number)
        {
            if (Stock>0 && number <= Stock)
            {
                Stock -= number;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
