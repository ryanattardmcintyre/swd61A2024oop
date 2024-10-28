using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Aggregation
{
    public class ShoppingCart
    {
        public string Username { get; set; }

        public string Coupon { get; set; }

        public List<Item> Items { get; set; }

        public void AddToCart(Item i, int amount)
        {
            bool flag = false;
            foreach(var item in Items)
            {
                if(item.Id == i.Id)
                {
                    item.Count += amount;
                    flag = true;
                }
            }

            if (!flag)
            {
                i.Count = amount;
                Items.Add(i);
            }
        }
    }
}
