using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_PC_builder_system
{
    class Item
    {
        private string ProductName;
        private int Quantity;
        private double Price;

        public Item(string productname, int quantity, double price)
        {
            ProductName = productname;
            Quantity = quantity;
            Price = price;
        }

        //Accessors
        public string Getproductname()
        {
            return ProductName;
        }

        public int Getquantity()
        {
            return Quantity;
        }

        public double Getprice()
        {
            return Price;
        }
    }
}
