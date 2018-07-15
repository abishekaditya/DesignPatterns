namespace CommandPattern
{
    internal class RemoteControl
    {
        private readonly ICommand[] _offCommand;
        private readonly ICommand[] _onCommand;
        private ICommand _undoCommand;

        public RemoteControl(int slots)
        {
            _onCommand = new ICommand[slots];
            _offCommand = new ICommand[slots];

            var none = new NoCommand();
            _undoCommand = none;
            for (var i = 0; i < slots; i++)
            {
                _onCommand[i] = none;
                _offCommand[i] = none;
            }
        }


        public OnOffStruct this[int i]
        {
            set
            {
                _onCommand[i] = value.On;
                _offCommand[i] = value.Off;
            }
        }

        public void PushOn(int slot)
        {
            _onCommand[slot].Execute();
            _undoCommand = _offCommand[slot];
        }

        public void PushOff(int slot)
        {
            _offCommand[slot].Execute();
            _undoCommand = _onCommand[slot];
        }

        public void PushUndo()
        {
            _undoCommand.Execute();
        }
    }
}