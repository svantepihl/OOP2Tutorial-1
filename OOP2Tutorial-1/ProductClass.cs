using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP2Tutorial_1
{
    class Product
    {
        // Constructor that takes name as argument
        public Product(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        private string Name;

        // Getter for name
        public string getName()
        {
            return Name;
        }

    }
}
