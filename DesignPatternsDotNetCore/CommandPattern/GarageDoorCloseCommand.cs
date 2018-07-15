namespace CommandPattern
{
    internal class GarageDoorCloseCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorCloseCommand(Garage g)
        {
            _garage = g;
        }

        public void Execute()
        {
            _garage.Close();
        }

        public void Undo()
        {
            _garage.Open();
        }
    }
}