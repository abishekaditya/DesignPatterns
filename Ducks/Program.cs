using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace Ducks
{
    class Duck
    {
        private IQuackBehaviour _quacker;
        private IFlyBehaviour _flyer;


        public IQuackBehaviour Quacker {
            set
            {
                this._quacker = value;
            }
        }

        public IFlyBehaviour Flyer
        {
            set
            {
                this._flyer = value;
            }
        }



        public void PerformQuack()
        {
            _quacker.quack();
        }

        public void PerformFly()
        {
            _flyer.fly();
        }
    }

    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyer = new FlyNope();
            Quacker = new QuackNope();
        }

        public void Display()
        {
            this.PerformFly();
            this.PerformQuack();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.Quacker = new QuackNormal();
            mallard.Display();
            mallard.Flyer = new FlyWings();
            mallard.Display();

        }
    }
}
