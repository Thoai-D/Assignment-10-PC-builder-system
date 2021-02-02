using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_PC_builder_system
{
    class Order
    {
        private Item[] Items = new Item[100];
        private int ItemCount;
        private int CustomerID;
        private DateTime OrderDate;

        public Order(int customerID)
        {
            ItemCount = 0;
            CustomerID = customerID;
            OrderDate = DateTime.Now;
        }

        public void AddItem(string ProductName, double Price, int Quantity)
        {
            Items[ItemCount] = new Item(ProductName, Quantity, Price);
            ItemCount++;
        }


        public Item GetItem(int index)
        {
            if (index < ItemCount)
            {
                return Items[index];
            }
            else
            {
                return;
            }
        }


    }


}
