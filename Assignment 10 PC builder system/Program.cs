using System;

namespace Assignment_10_PC_builder_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[5];

            orders[0] = new Order(1);

            orders[0].AddItem("CPU", 99.99, 1);




        }
    }
}
