using System;

namespace StatePattern
{
    public class NoQuarterState : IState
    {
        public GumballMachine Machine { get; }

        public NoQuarterState(GumballMachine machine)
        {
            Machine = machine;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("Inserted a quarter");
            Machine.State = Machine.HasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.Write("Can't eject anything");
        }

        public void TurnCrank()
        {
           Console.WriteLine("Can't turn crank without a quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("Can't dispense");
        }
    }
}