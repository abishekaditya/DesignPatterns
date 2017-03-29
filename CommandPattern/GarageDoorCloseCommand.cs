using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GarageDoorCloseCommand : Command
    {
        Garage garage;

        public GarageDoorCloseCommand(Garage g)
        {
            garage = g;
        }
        public void Execute()
        {
            garage.Close();
        }

        public void Undo()
        {
            garage.Open();
        }
    }
}
