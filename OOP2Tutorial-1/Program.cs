using System;

namespace OOP2Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product testProduct = new Product("Test");
            Console.WriteLine(testProduct.getName());
        }
    }
}
