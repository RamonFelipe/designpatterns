using System;

namespace SimpleRemoteControlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();

            var light = new Light();

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            remote.SetOnCommand(lightOnCommand);
            remote.ButtonOnWasPressed();
            remote.Undo();

            remote.SetOffCommand(lightOffCommand);
            remote.ButtonOffWasPressed();
            remote.Undo();
        }
    }
}