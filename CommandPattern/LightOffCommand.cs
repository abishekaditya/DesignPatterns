namespace CommandPattern
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light l)
        {
            _light = l;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}