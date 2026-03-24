# Mediator Pattern

This project demonstrates the **Mediator** design pattern, a behavioral pattern that defines how a set of objects interact with each other. Instead of objects communicating directly, they communicate through a mediator object.

## Overview

The Mediator pattern promotes loose coupling by keeping objects from referring to each other explicitly and lets you vary their interaction independently. It encapsulates how objects interact and makes the interaction changeable.

In this implementation, a software development team (Customer, Programmer, Tester) communicates through a Manager mediator. Instead of team members talking directly to each other, they send messages through the manager who routes them appropriately.

## Project Structure

### Core Classes
- `Mediator.cs` - Abstract mediator class defining the communication contract
- `Colleague.cs` - Abstract colleague class that all participants inherit from

### Concrete Classes
- `ManagerMediator.cs` - Concrete mediator that coordinates communication between team members
- `Customer.cs` - Represents the customer/client in the development process
- `Programmer.cs` - Represents the developer/programmer
- `Tester.cs` - Represents the quality assurance tester

### Client Code
- `Program.cs` - Demonstrates the mediator pattern in action

## How It Works

1. **Mediator Setup**: A `ManagerMediator` is created and all colleagues (Customer, Programmer, Tester) are registered with it
2. **Message Sending**: When a colleague calls `Send()`, it delegates to the mediator
3. **Message Routing**: The mediator receives the message and routes it to the appropriate recipient based on the sender
4. **Message Delivery**: The target colleague's `Notify()` method is called to receive the message

### Communication Flow

```
Customer → ManagerMediator → Programmer → ManagerMediator → Tester → ManagerMediator → Customer
```

The mediator defines the workflow:
- Customer sends message → Programmer receives it
- Programmer sends message → Tester receives it  
- Tester sends message → Customer receives it

### Example Output

```
Message to programmer: We have an order, need to make a program
Message to tester: I have done program, need to test it
Message to customer: I have done testing, here is ready program for you
```

## Benefits

1. **Reduced Coupling**: Colleagues don't need to know about each other directly
2. **Centralized Control**: All communication logic is in one place
3. **Easy Maintenance**: Changes to communication rules only affect the mediator
4. **Extensibility**: New colleagues can be added without changing existing code
5. **Reusability**: Colleagues can be reused with different mediators

## Key Design Principles Demonstrated

- **Single Responsibility**: Each colleague focuses on its own work, mediator handles communication
- **Open/Closed Principle**: New colleagues can be added without modifying existing ones
- **Dependency Inversion**: Colleagues depend on the mediator abstraction, not concrete implementations

## When to Use

- When objects communicate in complex but well-defined ways
- When reusing objects is difficult due to tight coupling
- When behavior distributed among several classes should be customizable
- When you want to centralize complex communications and control logic

## Real-World Applications

- **Air Traffic Control**: Planes communicate through control tower instead of directly
- **Chat Applications**: Users send messages through chat server/room
- **GUI Dialog Boxes**: UI components communicate through dialog controller
- **Workflow Systems**: Tasks communicate through workflow engine
- **Event Buses**: Components publish/subscribe through central event bus

## Comparison with Other Patterns

- **Mediator vs. Observer**: Mediator centralizes communication logic, Observer distributes it
- **Mediator vs. Facade**: Facade simplifies interface, Mediator manages object interactions
- **Mediator vs. Command**: Command encapsulates requests, Mediator routes them

## Implementation Notes

This implementation shows a simple mediator that routes messages in a linear workflow. In real applications, mediators can be more complex with:
- Multiple recipients for a single message
- Conditional routing based on message content
- Asynchronous communication
- Message queuing and persistence</content>
<parameter name="filePath">c:\Repos\DesignPatterns\MediatorPattern\README.md