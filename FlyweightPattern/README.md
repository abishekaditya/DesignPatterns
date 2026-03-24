# Flyweight Pattern

This project demonstrates the **Flyweight** design pattern, a structural pattern that focuses on sharing objects to support large numbers of fine-grained objects efficiently.

## Overview

The Flyweight pattern uses sharing to support large numbers of fine-grained objects efficiently. It separates intrinsic state (shared among all instances) from extrinsic state (unique to each instance) to minimize memory usage.

In this implementation, a bubble tea shop uses the Flyweight pattern to share beverage objects. Instead of creating a new beverage instance for each order, the same beverage object is reused for multiple orders of the same type, significantly reducing memory consumption.

## Project Structure

### Core Classes
- `IBeverage.cs` - Interface defining the beverage contract
- `BeverageFlyweightFactory.cs` - Factory that manages and shares flyweight objects
- `BeverageType.cs` - Enum defining available beverage types

### Concrete Flyweights
- `BubbleMilkTea.cs` - Bubble milk tea implementation
- `FoamMilkTea.cs` - Foam milk tea implementation
- `OolingMilkTea.cs` - Oolong milk tea implementation
- `CoconutMilkTea.cs` - Coconut milk tea implementation

### Client Classes
- `BubbleTeaShop.cs` - Client that uses the flyweight factory to create orders
- `Program.cs` - Main entry point demonstrating the pattern

## How It Works

1. **Flyweight Factory**: `BeverageFlyweightFactory` maintains a dictionary cache of created beverage objects
2. **Object Creation**: When a beverage is requested, the factory checks if an instance already exists
3. **Sharing**: If the beverage type exists in cache, the cached instance is returned; otherwise, a new instance is created and cached
4. **Usage**: Multiple orders of the same beverage type share the same object instance

### Example Output

When running the program, you'll see initialization messages only for the first instance of each beverage type:

```
Initializing a Bubble Milk Tea instance
Initializing a Coconut Milk Tea instance
Initializing a Foam Milk Tea instance
Initializing an Oolong Milk Tea instance

Enumerating take away orders

hmmm... this is bubble milk tea
hmmm... this is bubble milk tea  // Same instance reused
hmmm... this is coconut milk tea
hmmm... this is foam milk tea
hmmm... this is oolong milk tea
hmmm... this is oolong milk tea  // Same instance reused
```

Notice that "Initializing" messages appear only once per beverage type, even though Bubble Milk Tea and Oolong Milk Tea are ordered twice each.

## Key Components

### Intrinsic State
- Beverage type and behavior (shared across all instances of the same type)
- Stored within the flyweight object itself

### Extrinsic State
- Order-specific information (not implemented in this example, but would be passed to the `Drink()` method)
- Managed by client code and passed to flyweight methods as needed

### Flyweight Factory
- Manages the pool of flyweight objects
- Ensures sharing by returning cached instances
- Creates new instances only when necessary

## Benefits

1. **Memory Efficiency**: Reduces memory usage by sharing objects instead of creating duplicates
2. **Performance**: Faster object creation and reduced garbage collection pressure
3. **Scalability**: Can handle large numbers of similar objects without memory issues
4. **Consistency**: Ensures all instances of the same type behave identically

## When to Use

- When an application uses a large number of objects
- When storage costs are high due to the sheer quantity of objects
- When most object state can be made extrinsic
- When many groups of objects can be replaced by relatively few shared objects
- When object identity is not important to the application

## Real-World Applications

- Text editors (sharing character objects)
- Graphics systems (sharing glyph objects)
- Game development (sharing texture/sprite objects)
- Database connection pooling
- String interning in programming languages</content>
<parameter name="filePath">c:\Repos\DesignPatterns\FlyweightPattern\README.md