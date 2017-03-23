using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IngredientsFactory
    {
        Dough CreateDough();
        Veggies[] CreateVeggies();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Clam CreateClam();
    }
}
