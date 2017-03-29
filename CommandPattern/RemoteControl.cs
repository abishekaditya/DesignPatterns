using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RemoteControl
    {
        Command[] OnCommand;
        Command[] OffCommand;
        Command UndoCommand;


        public OnOffStruct this[int i]
        {
            get
            {
                OnOffStruct struc;
                struc.On = OnCommand[i];
                struc.Off = OffCommand[i];
                return struc;
            }

            set
            { 
                OnCommand[i] = value.On;
                OffCommand[i] = value.Off;
            }
        }

        public RemoteControl(int slots)
        {
            OnCommand = new Command[slots];
            OffCommand = new Command[slots];

            var none = new NoCommand();
            UndoCommand = none;
            for (int i = 0; i < slots; i++)
            {
                OnCommand[i] = none;
                OffCommand[i] = none;
            }

        }

        public void PushOn(int slot)
        {
            OnCommand[slot].Execute();
            UndoCommand = OffCommand[slot];
        }

        public void PushOff(int slot)
        {
            OffCommand[slot].Execute();
            UndoCommand = OnCommand[slot];
        }

        public void PushUndo()
        {
            UndoCommand.Execute();
        }
    }
}
