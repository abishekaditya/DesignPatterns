namespace CommandPattern
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}