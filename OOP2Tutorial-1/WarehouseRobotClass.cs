/*Task 5 Create a WarehouseRobot class
    Create a new class named WarehouseRobot.This robot class will have a
Name property, passed into its constructor as a parameter, and encapsulated just like the Product class.
Moreover, the robot should have a method called ProcessOrder that
takes in a parameter of the Order type.
We will make this method abstract, so we don’t have to implement it
by giving it a body in brackets. This is because implementing a general
warehouse robot does not make sense, we want to implement the specific
robots only. And because the method is abstract, the class needs to be
marked abstract as well.*/

namespace OOP2Tutorial_1
{
    public abstract class WarehouseRobot
    {
        public WarehouseRobot(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void ProcessOrder(Order order);
    }
}