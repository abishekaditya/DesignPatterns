namespace MediatorPattern
{
    class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Customer)
            {
                Programmer.Notify(message);
            }
            else if (colleague == Programmer)
            {
                Tester.Notify(message);
            }
            else Customer.Notify(message);
        }
    }
}