using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareTool.Models
{
    public class Product
    {

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public Product(string name,int quantity,int price)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}