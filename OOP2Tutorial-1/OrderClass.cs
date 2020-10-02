/*Task 3 Create an Order class
Create a new class named Order, with two properties, and a constructor:
• A property named OrderedProduct with the type Product
• A property named State with the type string
• A constructor that takes the product as a parameter and assignts the
OrderedProduct property to this parameter, and within its body sets
the State property to "Ordered".
The general idea is, the State of an order will change from "Ordered" to
"Packed", then to "Dispatched", and finally to "Delivered" by the corresponding robot. Therefore we set it to "Ordered" as its initial value in the
constructor and leave it like that for the time being.*/

namespace OOP2Tutorial_1
{
    public class Order
    {
        public Product OrderedProduct;
        public string State;

        public Order(Product orderedProduct)
        {
            OrderedProduct = orderedProduct;
            State = "Ordered";
        }
    }
}