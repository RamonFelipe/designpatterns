using System;

public class LightOnCommand : ICommand
{
    private readonly Light light;
    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        this.light.On();
    }

    public void Undo()
    {
        this.light.Off();
    }
}