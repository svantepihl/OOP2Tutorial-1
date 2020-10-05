using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP2Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of orders
            List<Order> orderList = new List<Order>();

            // Create list of robots
            List<WarehouseRobot> robotList = new List<WarehouseRobot>();

            // Initalize one of each kind of robot
            robotList.Add(new PackingRobot("Packing"));
            robotList.Add(new DispatchRobot("Dispatch"));
            robotList.Add(new DeliveryRobot("Delivery"));

            // Menu
            bool close = false;
            while (!close)
            {
                int choice = 0;
                int ordersProcessed = 0; // Keeping track of processed orders
                bool validChoice;
                do
                {
                    Console.WriteLine("\n1. Add a new order.");
                    Console.WriteLine("2. Display status for all orders.");
                    Console.WriteLine("3. Process all un-processed orders.");
                    Console.WriteLine("4. Exit the program.");
                    if(!(int.TryParse(Console.ReadLine(), out choice) && choice < 5 && choice > 0))
                    {
                        Console.WriteLine("Invalid choice, try again!");
                        validChoice = false;
                    } else
                    {
                        validChoice = true;
                    }
                } while (!validChoice);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Type the name of the product you want to order:");
                        orderList.Add(new Order(new Product(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Printing status for all orders...");
                        foreach (Order order in orderList)
                        {
                            Console.WriteLine("Product: " order.OrderedProduct.Name + " Status: " + order.State);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Processing un-processed orders...");
                        foreach (WarehouseRobot robot in robotList)
                        {
                            // Foreach robot only processed the so-far unprocessed orders
                            for (int i = ordersProcessed; i < orderList.Count; i++)
                            {
                                robot.ProcessOrder(orderList[i]);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Closing...");
                        close = true;
                        break;
                }
            }
        }
    }
}
