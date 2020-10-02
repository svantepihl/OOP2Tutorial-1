/*Task 2 Create a Product class
    In the solution(find the Solution explorer window), create a new class named
Product.This class should have one property with the name Name, and the
type string. It also should have a constructor that takes in a name parameter, and assigns the Name property using the parameter.
    Make sure to encapsulate the Name property. You can do this by having
    a private field of the same type, and implementing the get and set methods
of the property.
*/
namespace OOP2Tutorial_1
{
    public class Product
    { 
        public string Name { get; }

        // Constructor with name as argument
        public Product(string name)
        {
            Name = name;
        }
    }
}
