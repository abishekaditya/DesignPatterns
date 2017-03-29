using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var item in commands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            foreach (var item in commands)
            {
                item.Undo();
            }
        }
    }
}
