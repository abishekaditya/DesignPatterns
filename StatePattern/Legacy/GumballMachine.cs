using System;

namespace StatePattern.Legacy
{
    public class GumballMachine
    {
        private int _count;
        private State _state = State.NoQuarters;

        public GumballMachine(int count)
        {
            _count = count;
        }

        public void InsertQuarter()
        {
            switch (_state)
            {
                case State.NoQuarters:
                    _state = State.HasQuarters;
                    Console.WriteLine("Inserted a quarter");
                    break;
                case State.Sold:
                    Console.WriteLine("Please wait for current gumball to come out");
                    break;
                case State.HasQuarters:
                    Console.WriteLine("Can't add more quarters");
                    break;
                case State.NoGumballs:
                    Console.WriteLine("Out of Stock");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void EjectQuarter()
        {
            switch (_state)
            {
                case State.NoQuarters:
                    Console.WriteLine("Nothing to eject");
                    break;
                case State.Sold:
                    Console.WriteLine("Sorry, you have already turned the crank");
                    break;
                case State.HasQuarters:
                    Console.WriteLine("Ejecting..");
                    _state = State.NoQuarters;
                    break;
                case State.NoGumballs:
                    Console.WriteLine("Can't eject, never accepted quarters");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void TurnCrank()
        {
            switch (_state)
            {
                case State.NoQuarters:
                    Console.WriteLine("Insert quarter First");
                    break;
                case State.Sold:
                    Console.WriteLine("Turning twice won't get you a gumball");
                    break;
                case State.HasQuarters:
                    Console.WriteLine("Getting gumball...");
                    _state = State.Sold;
                    Dispense();
                    break;
                case State.NoGumballs:
                    Console.WriteLine("Out of Stock");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void Dispense()
        {
            switch (_state)
            {
                case State.NoQuarters:
                    Console.WriteLine("You need to pay first");
                    break;
                case State.Sold:
                    Console.WriteLine("A Gumball comes rolling out");
                    _count--;
                    _state = _count == 0 ? _state = State.NoGumballs : State.NoQuarters;
                    break;
                case State.HasQuarters:
                case State.NoGumballs:
                    Console.WriteLine("Can't dispense");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}