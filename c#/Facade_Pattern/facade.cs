namespace Facade_Pattern
{
    public class Facade
    {
         private Kitchen kitchen;
         private Waiter waiter;

        public facade() 
        {
            this.kitchen = new Kitchen();
            this.waiter = new Waiter();
        }
         public string OrderFood()
         {
             string order = "Facae intializes subsystems:\n";
             order += this.waiter.WriteOrder();
             order += this.waiter.SendToKitchen();

             order += this.kitchen.PrepareFood();
             order += this.kitchen.CallWaiter();

             order += this.waiter.ServeCustomer();

             order += this.kitchen.WashDishes();

             return order;
         }
    }

    public class Kitchen
    {
        public string PrepareFood() { return "Cook\n food"; }
        public string CallWaiter() { return "Call Waiter\n"; }
        public string WashDishes() { return "Wash the dishes\n"; }

    }

    public class Waiter 
    {
        public string WriteOrder() { return "Waiter writes customer's order\n"; }
        public string SendToKitchen() { return "Send order to kitchen\n"; }
        public string ServeCustomer() { return "Customer is served\n"; }
    }
}