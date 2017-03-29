namespace CommandPattern
{
    internal class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light l)
        {
            _light = l;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}