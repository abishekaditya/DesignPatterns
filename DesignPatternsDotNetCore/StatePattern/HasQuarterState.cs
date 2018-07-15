using System;

namespace StatePattern
{
    public class HasQuarterState : IState
    {
        private GumballMachine Machine { get; }
        readonly Random _random = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            Machine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Can't insert more than one");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            Machine.State = Machine.NoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank");
            var winner = _random.Next(10);
            if ((winner == 5) && (Machine.Count > 1))
                Machine.State = Machine.WinnerState;
            else
            {
                Machine.State = Machine.SoldState;
            }
                            }

        public void Dispense()
        {
            Console.WriteLine("Can't do that");
        }
    }
}