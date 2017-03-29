using System;

namespace CommandPattern
{
    internal class NoCommand : ICommand
    {
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