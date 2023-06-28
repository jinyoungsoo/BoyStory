using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
