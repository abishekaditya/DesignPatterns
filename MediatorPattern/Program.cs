using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ManagerMediator();
            var customer = new Customer(mediator);
            var programmer = new Programmer(mediator);
            var tester = new Tester(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send("We have an order, need to make a program");
            programmer.Send("I have done program, need to test it");
            tester.Send("I have done testing, here is ready program for you");
        }
    }
}