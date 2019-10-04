using System.Collections.Generic;
using System.Linq;

public class SimpleRemoteControl
{
    private ICommand onCommand;
    private ICommand offCommand;
    private ICommand undoCommand;

    public void SetOnCommand(ICommand command)
    {
        this.onCommand = command;
    }

    public void SetOffCommand(ICommand command)
    {
        this.offCommand = command;
    }

    public void ButtonOnWasPressed()
    {
        this.onCommand.Execute();
        this.undoCommand = this.onCommand;
    }

    public void ButtonOffWasPressed()
    {
        this.offCommand.Execute();
        this.undoCommand = this.offCommand;
    }

    public void Undo()
    {
        this.undoCommand.Undo();
    }
}