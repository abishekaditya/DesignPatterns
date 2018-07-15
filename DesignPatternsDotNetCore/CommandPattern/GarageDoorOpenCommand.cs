namespace CommandPattern
{
    internal class GarageDoorOpenCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorOpenCommand(Garage g)
        {
            _garage = g;
        }

        public void Execute()
        {
            _garage.Open();
        }

        public void Undo()
        {
            _garage.Close();
        }
    }
}