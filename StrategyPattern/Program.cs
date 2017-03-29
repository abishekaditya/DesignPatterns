namespace Ducks
{
    internal class Duck
    {
        private IQuackBehaviour _quacker;
        private IFlyBehaviour _flyer;


        public IQuackBehaviour Quacker {
            set
            {
                _quacker = value;
            }
        }

        public IFlyBehaviour Flyer
        {
            set
            {
                _flyer = value;
            }
        }


        protected void PerformQuack()
        {
            _quacker.Quack();
        }

        protected void PerformFly()
        {
            _flyer.Fly();
        }
    }

    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyer = new FlyNope();
            Quacker = new QuackNope();
        }

        public void Display()
        {
            PerformFly();
            PerformQuack();
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            var mallard = new MallardDuck {Quacker = new QuackNormal()};
            mallard.Display();
            mallard.Flyer = new FlyWings();
            mallard.Display();

        }
    }
}
