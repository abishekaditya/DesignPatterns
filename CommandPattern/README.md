# Command Pattern

This folder implements the Command design pattern in C# using a remote control example with garage doors and lights.

## Pattern overview

Command encapsulates a request as an object, allowing parameterization of clients with queues, requests, and operations. It also supports undoable operations.

In this example:

- `ICommand` defines `Execute()` and `Undo()`.
- Concrete commands (e.g., `GarageDoorOpenCommand`) encapsulate receivers and actions.
- `RemoteControl` acts as the invoker, storing and executing commands.
- `MacroCommand` composes multiple commands for batch operations.

## Project structure

- `ICommand.cs`: command interface.
- `RemoteControl.cs`: invoker with slots for on/off commands and undo.
- `GarageDoorOpenCommand.cs`, `GarageDoorCloseCommand.cs`: concrete commands for garage.
- `LightOnCommand.cs`, `LightOffCommand.cs`: concrete commands for light.
- `MacroCommand.cs`: composite command for multiple actions.
- `NoCommand.cs`: null object for empty slots.
- `OnOffStruct.cs`: struct for on/off command pairs.
- `Garage.cs`, `Light.cs`: receivers.
- `Program.cs`: demo usage.

## How it works

1. Commands are assigned to remote slots (on/off pairs).
2. `PushOn(slot)` executes the on command and sets undo to off.
3. `PushOff(slot)` executes the off command and sets undo to on.
4. `PushUndo()` executes the last command's opposite.
5. Macro commands execute multiple commands in sequence.

## Usage

```csharp
var remote = new RemoteControl(3);
var garage = new Garage("Bike");
var openCmd = new GarageDoorOpenCommand(garage);
var closeCmd = new GarageDoorCloseCommand(garage);

remote[0] = new OnOffStruct { On = openCmd, Off = closeCmd };
remote.PushOn(0);  // Opens garage
remote.PushUndo(); // Closes garage
```

## Why this pattern is useful

- Decouples invoker from receiver.
- Supports undo, redo, and macro operations.
- Enables queuing and logging of requests.
- Promotes extensibility by adding new commands without changing existing code.