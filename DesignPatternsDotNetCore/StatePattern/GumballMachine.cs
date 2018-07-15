using System;

namespace StatePattern
{
    public class GumballMachine
    {
        public int Count { get; private set; }

        public IState SoldOutState;
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;
        public IState WinnerState;

        public IState State { get; set; }

        public GumballMachine(int count)
        {
            Count = count;
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            if (Count > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A ball comes rolling down");
            if (Count == 0) return;
            Count--;
        }
    }
}