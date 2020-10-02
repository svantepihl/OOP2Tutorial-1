/*Task 8 Add the DispatchRobot and DeliveryRobot classes
Add the DispatchRobot and DeliveryRobot classes just like you did with
the PackingRobot. They will set the Status property of the order to
"Dispatched" and "Delivered", respectively, as a part of their ProcessOrder
methods.
Note that even though these objects are all inheriting from the WarehouseRobot
class, their ProcessOrder methods are doing different things. This is polymorphism.*/

namespace OOP2Tutorial_1
{
    public class DeliveryRobot:WarehouseRobot
    {
        public DeliveryRobot(string name) : base(name)
        {
        }

        public override void ProcessOrder(Order order)
        {
            order.State = "Delivered";
        }
    }
}