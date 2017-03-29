using System;

namespace CommandPattern
{
    internal class NoCommand : Command
    {
        public NoCommand()
        {
        }

        public void Execute()
        {
            Console.WriteLine("No Command Assigned");
        }

        public void Undo()
        {
            Execute();
        }
    }
}