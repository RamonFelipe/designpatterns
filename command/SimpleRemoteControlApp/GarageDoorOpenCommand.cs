public class GarageDoorOpenCommand : ICommand
{
    private readonly GarageDoor garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }
    public void Execute()
    {
        this.garageDoor.Up();
    }

    public void Undo()
    {
        this.garageDoor.Down();
    }
}
