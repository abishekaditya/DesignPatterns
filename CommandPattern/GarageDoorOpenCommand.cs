using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GarageDoorOpenCommand : Command
    {
        Garage garage;

        public GarageDoorOpenCommand(Garage g)
        {
            garage = g;
        }
        public void Execute()
        {
            garage.Open();            
        }

        public void Undo()
        {
            garage.Close();
        }
    }
}
