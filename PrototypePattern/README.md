# Prototype Pattern

This project demonstrates the **Prototype** design pattern, a creational pattern that allows cloning objects without coupling to their specific classes.

## Overview

The Prototype pattern specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype. It allows you to create new instances by copying existing objects, which can be more efficient than creating objects from scratch.

In this implementation, geometric figures (Rectangle and Circle) can be cloned to create new instances with the same properties, demonstrating how the Prototype pattern enables object duplication.

## Project Structure

### Core Classes
- `IFigure.cs` - Interface extending `ICloneable` that defines the contract for clonable figures
- `ICloneable` - .NET interface providing the `Clone()` method

### Concrete Prototypes
- `Rectangle.cs` - Rectangle figure that can be cloned
- `Circle.cs` - Circle figure that can be cloned

### Client
- `Program.cs` - Demonstrates cloning figures using the prototype pattern

## How It Works

1. **Prototype Definition**: Classes implement `ICloneable` interface with a `Clone()` method
2. **Cloning**: When `Clone()` is called, the object creates a copy of itself
3. **Client Usage**: Client code can create new objects by cloning existing prototypes
4. **Independence**: Cloned objects are independent of their prototypes

### Example Usage

```csharp
// Create original rectangle
IFigure figure = new Rectangle(30, 40);

// Clone it to create a new instance
IFigure clonedFigure = (IFigure)figure.Clone();

// Both have the same properties but are different objects
figure.GetInfo();        // "Rectangle height 40 and width 30"
clonedFigure.GetInfo();  // "Rectangle height 40 and width 30"
```

### Example Output

```
Rectangle height 40 and width 30
Rectangle height 40 and width 30
Circle with radius 30
Circle with radius 30
```

## Key Components

### Prototype Interface
- Defines the contract for clonable objects
- Extends .NET's `ICloneable` interface
- Requires implementation of `Clone()` method

### Concrete Prototypes
- Implement the prototype interface
- Provide their own cloning logic
- Can have complex initialization that gets copied

### Client
- Uses prototypes to create new objects
- Doesn't need to know concrete classes
- Works with cloned objects as independent instances

## Benefits

1. **Reduced Subclassing**: Avoids creating subclasses for different object configurations
2. **Runtime Flexibility**: Add/remove prototypes at runtime
3. **Performance**: Cloning can be more efficient than complex construction
4. **Encapsulation**: Hides complex object creation logic
5. **Consistency**: Ensures cloned objects have same initial state

## Key Design Principles Demonstrated

- **Single Responsibility**: Each prototype handles its own cloning
- **Open/Closed Principle**: New prototypes can be added without changing existing code
- **Dependency Inversion**: Client depends on abstractions, not concrete classes

## When to Use

- When object creation is expensive or complex
- When you want to avoid subclasses for different configurations
- When you need to create objects at runtime with varying properties
- When you want to hide the complexity of object creation
- When the system needs to be independent of how its products are created

## Real-World Applications

- **Graphic Editors**: Clone shapes, brushes, or effects
- **Game Development**: Clone characters, weapons, or game objects
- **Document Systems**: Clone documents, pages, or templates
- **Configuration Objects**: Clone settings or preferences
- **Database Records**: Clone data objects for modification
- **UI Components**: Clone widgets or controls

## Implementation Considerations

### Shallow vs Deep Copy
- This implementation uses shallow copying (copying primitive values)
- For complex objects with references, deep copying may be needed
- Consider using serialization for deep cloning

### Prototype Registry
- For complex systems, maintain a registry of available prototypes
- Allows clients to specify prototypes by name or key
- Enables dynamic prototype management

### Clone Method Variations
- MemberwiseClone() for shallow copying
- Custom logic for selective copying
- Serialization/deserialization for deep copying

## Comparison with Other Patterns

- **Prototype vs. Factory**: Factory creates objects from scratch, Prototype clones existing objects
- **Prototype vs. Builder**: Builder constructs complex objects step-by-step, Prototype copies complete objects
- **Prototype vs. Singleton**: Singleton ensures one instance, Prototype allows multiple copies

## .NET Implementation Notes

This implementation uses .NET's `ICloneable` interface, which:
- Provides a standard way to implement cloning
- Returns `object` type (requires casting)
- Doesn't specify shallow vs. deep copying
- Is considered legacy; consider custom interfaces for new code

For modern .NET development, consider:
- Custom clone interfaces with generic return types
- Record types with built-in cloning
- Serialization-based deep cloning
- Immutable objects that don't need cloning</content>
<parameter name="filePath">c:\Repos\DesignPatterns\PrototypePattern\README.md