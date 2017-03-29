using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl(3);


            var bike = new Garage("Bike");
            var bikeDoorClose = new GarageDoorCloseCommand(bike);
            var bikeDoorOpen = new GarageDoorOpenCommand(bike);

            var car = new Garage("Car");
            var carDoorClose = new GarageDoorCloseCommand(car);
            var carDoorOpen = new GarageDoorOpenCommand(car);

            var garage_button = new OnOffStruct();
            garage_button.On = bikeDoorOpen;
            garage_button.Off = bikeDoorClose;

            remote[0] = garage_button;
            remote.PushOn(0);
            remote.PushUndo();
            remote.PushUndo();
            remote.PushOff(0);


            Console.WriteLine();
            var light = new Light("Hall");

            Command[] partyOn = { new LightOffCommand(light) , bikeDoorOpen , carDoorOpen };
            Command[] partyOff = { new LightOnCommand(light), bikeDoorClose, carDoorClose };


            remote[2] = new OnOffStruct { On = new MacroCommand(partyOn), Off = new MacroCommand(partyOff) };

            try
            {
                remote.PushOn(2);
                Console.WriteLine();
                remote.PushOff(2);
            } catch (Exception)
            {
                Console.WriteLine("Oops");
            }
        }
    }
}
