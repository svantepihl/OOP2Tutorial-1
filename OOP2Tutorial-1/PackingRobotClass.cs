/*Task 6 Create the PackingRobot class
 Add a new class named PackingRobot that inherits from the WarehouseRobot
class. This class will also need to have a constructor that takes a name, and
it will pass this name on to its base class’ constructor.This is called Constructor chaining, and it should look like as given in the Figure 2.
Now you need to override the ProcessOrder method and give it a body.
The body will consist of simply setting the Status property of the order
object to "Packed". Just a single line.
Now you have completed the PackingRobot class. Even though this class
    inherits from an abstract class, it is not an abstract class itself, because it
provides a body for the ProcessOrder method. Classes that provide bodies to each of their methods are concrete classes, as opposed to abstract classes,
which lack the body to one or more of their methods*/

namespace OOP2Tutorial_1
{
    public class PackingRobot:WarehouseRobot
    {
        public PackingRobot(string name) : base(name)
        {
        }

        public override void ProcessOrder(Order order)
        {
            order.State = "Packed";
        }
    }
}