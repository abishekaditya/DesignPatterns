using System;

namespace StatePattern
{
    public class WinnerState : IState
    {
        private GumballMachine Machine { get; }

        public WinnerState(GumballMachine gumballMachine)
        {
            Machine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, already in progress");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Can't eject, already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice achieves nothing");
        }


        public void Dispense()
        {
            Console.WriteLine("You Won!! 2 gumballs for the price of one");
            Machine.ReleaseBall();
            if (Machine.Count == 0)
            {
                Machine.State = Machine.SoldOutState;
                Console.WriteLine("Oops! No more gumballs");
            }
            else
            {
                Machine.ReleaseBall();
                Machine.State = Machine.NoQuarterState;
            }
        }
    }
}