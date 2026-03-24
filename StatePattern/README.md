# State Pattern

## Overview

The **State Pattern** is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. The object will appear to change its class. This pattern is particularly useful when an object's behavior depends on its state, and it must change its behavior at runtime depending on that state.

## Project Structure

This project demonstrates the State Pattern using a Gumball Machine example. The project contains:

- `GumballMachine.cs` - The context class that maintains a reference to the current state
- `IState.cs` - The state interface defining the contract for all concrete states
- `NoQuarterState.cs` - State when no quarter is inserted
- `HasQuarterState.cs` - State when a quarter is inserted
- `SoldState.cs` - State when the crank is turned and gumball is being dispensed
- `SoldOutState.cs` - State when the machine is out of gumballs
- `WinnerState.cs` - Special state for when the user wins an extra gumball
- `Program.cs` - Main program demonstrating the pattern usage
- `Legacy/` - Contains the legacy implementation using conditional statements for comparison

## How It Works

### Context (GumballMachine)
The `GumballMachine` class acts as the context. It:
- Maintains a reference to the current state (`IState State`)
- Defines all possible states as properties
- Delegates state-specific behavior to the current state object
- Provides methods that clients call (`InsertQuarter()`, `EjectQuarter()`, `TurnCrank()`)

### State Interface (IState)
The `IState` interface defines the contract that all concrete states must implement:
- `InsertQuarter()` - Handle quarter insertion
- `EjectQuarter()` - Handle quarter ejection
- `TurnCrank()` - Handle crank turning
- `Dispense()` - Handle gumball dispensing

### Concrete States
Each concrete state implements the `IState` interface and encapsulates the behavior for that specific state:

- **NoQuarterState**: Accepts quarter insertion, rejects other actions
- **HasQuarterState**: Accepts crank turning or quarter ejection, includes winner logic
- **SoldState**: Dispenses gumball and transitions to appropriate next state
- **SoldOutState**: Rejects all actions when machine is empty
- **WinnerState**: Dispenses two gumballs for the price of one

## Example Usage

```csharp
// Create a gumball machine with 5 gumballs
var gumballMachine = new GumballMachine(5);

// Insert quarter and turn crank
gumballMachine.InsertQuarter();  // "Inserted a quarter"
gumballMachine.TurnCrank();      // "You turned the crank" + "A ball comes rolling down"

// Try invalid operations
gumballMachine.TurnCrank();      // "Can't turn crank without a quarter"
gumballMachine.EjectQuarter();    // "Can't eject anything"
```

## Benefits

1. **Single Responsibility**: Each state class has a single responsibility - handling behavior for one state
2. **Open/Closed Principle**: Easy to add new states without modifying existing code
3. **Eliminates Conditional Complexity**: Replaces large switch/if-else statements with polymorphism
4. **State Transitions**: Clear and explicit state transitions
5. **Maintainability**: Changes to state behavior are localized to the specific state class

## When to Use

- When an object's behavior depends on its state and it must change behavior at runtime
- When operations have large, multipart conditional statements that depend on the object's state
- When you have many conditional branches that are difficult to maintain
- When state-specific behavior is complex and varies significantly between states

## Real-World Applications

- **Vending Machines**: Different behaviors based on inventory and payment state
- **Network Connections**: Connected, connecting, disconnected states with different behaviors
- **Document States**: Draft, review, published states with different editing permissions
- **Game Character States**: Idle, walking, running, jumping states
- **Order Processing**: Pending, processing, shipped, delivered states
- **Media Players**: Playing, paused, stopped states with different control behaviors

## Comparison with Legacy Implementation

The `Legacy` folder contains an implementation using conditional statements instead of the State pattern. Compare the differences:

**State Pattern Benefits:**
- Cleaner code with no large switch statements
- Easy to add new states (just create new class)
- State-specific behavior is encapsulated
- Better testability of individual states

**Legacy Drawbacks:**
- Large conditional blocks that are hard to maintain
- Adding new states requires modifying existing code
- Mixed concerns in a single class
- Harder to test individual state behaviors

## Implementation Considerations

- Define a clear state interface that all states implement
- The context should delegate state-specific behavior to the current state
- States can have references back to the context for state transitions
- Consider using the State pattern when you have more than 2-3 states
- States should be immutable where possible
- Consider thread-safety if states can be accessed concurrently</content>
<parameter name="filePath">c:\Repos\DesignPatterns\StatePattern\README.md