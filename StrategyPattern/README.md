# Strategy Pattern

## Overview

The **Strategy Pattern** is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it. This pattern is particularly useful when you have multiple ways to perform the same task and want to be able to switch between them dynamically.

## Project Structure

This project demonstrates the Strategy Pattern using a Duck simulation example. The project contains:

- `Duck.cs` - The context class that maintains references to strategy objects
- `MallardDuck.cs` - A concrete duck implementation
- `IFlyBehaviour.cs` - Strategy interface for flying behavior
- `FlyWings.cs` - Concrete strategy for flying with wings
- `FlyNope.cs` - Concrete strategy for ducks that can't fly
- `IQuackBehaviour.cs` - Strategy interface for quacking behavior
- `QuackNormal.cs` - Concrete strategy for normal quacking
- `QuackNope.cs` - Concrete strategy for silent ducks
- `QuackSqueak.cs` - Concrete strategy for squeaking ducks
- `Program.cs` - Main program demonstrating the pattern usage

## How It Works

### Context (Duck)
The `Duck` class acts as the context. It:
- Maintains references to strategy objects (`IFlyBehaviour` and `IQuackBehaviour`)
- Provides setters to change strategies at runtime
- Delegates behavior execution to the current strategy objects
- Defines `PerformFly()` and `PerformQuack()` methods that call the strategies

### Strategy Interfaces
- `IFlyBehaviour` - Defines the contract for flying algorithms
- `IQuackBehaviour` - Defines the contract for quacking algorithms

### Concrete Strategies
Each concrete strategy implements one of the strategy interfaces:

**Fly Behaviors:**
- `FlyWings` - Implements flying by flapping wings
- `FlyNope` - Implements inability to fly

**Quack Behaviors:**
- `QuackNormal` - Implements standard duck quacking
- `QuackNope` - Implements silence (no quacking)
- `QuackSqueak` - Implements squeaking instead of quacking

### Concrete Context (MallardDuck)
`MallardDuck` extends `Duck` and:
- Sets default behaviors in its constructor
- Can have its behaviors changed dynamically at runtime
- Calls `PerformFly()` and `PerformQuack()` to execute current strategies

## Example Usage

```csharp
// Create a mallard duck with default behaviors
var mallard = new MallardDuck();

// Change quack behavior at runtime
mallard.Quacker = new QuackNormal();

// Display current behavior
mallard.Display();  // Output: "I can't fly" + "Quack Quack"

// Change fly behavior at runtime
mallard.Flyer = new FlyWings();

// Display new behavior
mallard.Display();  // Output: "Flap Flap" + "Quack Quack"
```

## Benefits

1. **Open/Closed Principle**: New strategies can be added without modifying existing code
2. **Composition over Inheritance**: Behaviors are composed rather than inherited
3. **Runtime Flexibility**: Strategies can be changed dynamically
4. **Single Responsibility**: Each strategy class has one responsibility
5. **Testability**: Individual strategies can be tested in isolation
6. **Eliminates Conditional Logic**: No need for switch statements or if-else chains

## When to Use

- When you have multiple algorithms for the same task and want to switch between them dynamically
- When you want to avoid exposing complex, algorithm-specific data structures
- When a class has many conditional statements that switch between different behaviors
- When you need different variants of an algorithm (e.g., different sorting algorithms)
- When you want to isolate algorithm implementation from the code that uses it

## Real-World Applications

- **Payment Processing**: Different payment strategies (credit card, PayPal, bank transfer)
- **Sorting Algorithms**: QuickSort, MergeSort, BubbleSort strategies
- **Compression Algorithms**: ZIP, RAR, GZIP compression strategies
- **Authentication**: Different authentication methods (password, OAuth, biometric)
- **Navigation**: Different routing algorithms (fastest, shortest, scenic routes)
- **Logging**: Different logging strategies (console, file, database, remote server)
- **Image Processing**: Different filter strategies (blur, sharpen, edge detection)
- **Data Validation**: Different validation strategies (strict, lenient, custom rules)

## Implementation Considerations

- Define a clear strategy interface that all concrete strategies implement
- The context should work with strategies through the interface, not concrete classes
- Consider making strategies stateless if possible (no instance variables)
- Strategies should be interchangeable - clients shouldn't know the difference
- Consider using the Strategy pattern when you have more than 2-3 algorithm variants
- For simple cases with few algorithms, inheritance might be simpler
- Strategies can be shared across different contexts if they're stateless

## Comparison with Other Patterns

**Strategy vs State:**
- Strategy: Client chooses algorithm explicitly
- State: Object changes behavior based on internal state

**Strategy vs Template Method:**
- Strategy: Composition-based, algorithms can be changed at runtime
- Template Method: Inheritance-based, algorithm structure is fixed

**Strategy vs Command:**
- Strategy: Defines how something is done
- Command: Defines what to do and when

This implementation demonstrates how the Strategy pattern enables flexible, maintainable code by separating algorithms from the objects that use them.</content>
<parameter name="filePath">c:\Repos\DesignPatterns\StrategyPattern\README.md