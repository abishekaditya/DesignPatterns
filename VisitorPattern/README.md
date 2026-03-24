# Visitor Pattern

## Overview

The **Visitor Pattern** is a behavioral design pattern that lets you define a new operation without changing the classes of the elements on which it operates. This pattern allows you to separate algorithms from the objects on which they operate, making it easy to add new operations without modifying existing code.

## Project Structure

This project demonstrates the Visitor Pattern using a housing unit example. The project contains:

- `Unit.cs` - Abstract base class for all housing units (composite structure)
- `Apartment.cs` - Concrete apartment element
- `Studio.cs` - Concrete studio element
- `Bedroom.cs` - Concrete bedroom element
- `LivingRoom.cs` - Concrete living room element
- `IUnitVisitor.cs` - Visitor interface defining operations for each element type
- `ApartmentVisitor.cs` - Concrete visitor that operates on apartments
- `StudioVisitor.cs` - Concrete visitor that operates on studios
- `BedroomVisitor.cs` - Concrete visitor that operates on bedrooms
- `LivingRoomVisitor.cs` - Concrete visitor that operates on living rooms
- `Program.cs` - Main program demonstrating the pattern usage

## How It Works

### Element Hierarchy (Unit Classes)
The `Unit` abstract class represents elements in a composite structure:

```csharp
public abstract class Unit
{
    public virtual void Accept(IUnitVisitor visitor)
    {
        // Visit child units recursively
        foreach (var unit in _units)
        {
            unit.Accept(visitor);
        }
    }
}
```

**Concrete Elements:**
- `Apartment` - Contains multiple rooms, calls `visitor.VisitApartment(this)`
- `Studio` - Contains rooms, calls `visitor.VisitStudio(this)`
- `Bedroom` - Leaf element, calls `visitor.VisitBedroom(this)`
- `LivingRoom` - Leaf element, calls `visitor.VisitLivingRoom(this)`

### Visitor Interface
`IUnitVisitor` defines the contract that all concrete visitors must implement:

```csharp
public interface IUnitVisitor
{
    void VisitApartment(Apartment apartment);
    void VisitStudio(Studio studio);
    void VisitBedroom(Bedroom bedroom);
    void VisitLivingRoom(LivingRoom livingRoom);
}
```

### Concrete Visitors
Each concrete visitor implements operations for specific element types:

- **ApartmentVisitor**: Only responds to apartments (`VisitApartment`)
- **StudioVisitor**: Only responds to studios (`VisitStudio`)
- **BedroomVisitor**: Only responds to bedrooms (`VisitBedroom`)
- **LivingRoomVisitor**: Only responds to living rooms (`VisitLivingRoom`)

## Example Usage

```csharp
// Create housing units
var apartment = new Apartment(new LivingRoom(), new Bedroom(), new Bedroom());
var studio = new Studio(new LivingRoom(), new Bedroom());

// Visit apartment with different visitors
Console.WriteLine("Visiting an Apartment");
apartment.Accept(new ApartmentVisitor());    // "This is an apartment"
apartment.Accept(new LivingRoomVisitor());   // "This is the living room"
apartment.Accept(new BedroomVisitor());      // "Here is a bedroom" (twice)

// Visit studio with different visitors
Console.WriteLine("Visiting a Studio");
studio.Accept(new StudioVisitor());          // "This is a studio"
studio.Accept(new LivingRoomVisitor());      // "This is the living room"
studio.Accept(new BedroomVisitor());         // "Here is a bedroom"
```

## Benefits

1. **Open/Closed Principle**: Easy to add new operations without modifying element classes
2. **Single Responsibility**: Each visitor encapsulates one operation
3. **Separation of Concerns**: Algorithms are separated from object structure
4. **Extensibility**: New visitors can be added without changing existing code
5. **Double Dispatch**: Correct method called based on both visitor and element types
6. **Clean Interfaces**: Element classes don't need to know about all possible operations

## When to Use

- When you have a complex object structure and need to perform operations on elements
- When you need to add new operations to existing classes without modifying them
- When operations depend on the concrete types of objects in a structure
- When you want to avoid polluting element classes with operation-specific code
- When you have operations that require access to private members of elements
- When the object structure rarely changes but operations are added frequently

## Real-World Applications

- **Document Processing**: Different visitors for rendering (HTML, PDF, XML), validation, or analysis
- **Abstract Syntax Trees**: Compiler operations like type checking, code generation, optimization
- **GUI Frameworks**: Different visitors for layout, rendering, event handling
- **File System Operations**: Visitors for file compression, encryption, backup
- **Database Operations**: Visitors for query optimization, schema validation, migration
- **Shopping Cart**: Visitors for tax calculation, discount application, inventory checking
- **Game Development**: Visitors for AI behavior, physics simulation, rendering
- **XML/HTML Processing**: Visitors for parsing, validation, transformation
- **Report Generation**: Visitors for different report formats (PDF, Excel, CSV)

## Implementation Considerations

- **Double Dispatch**: The pattern relies on method overloading to achieve double dispatch
- **Visitor Interface**: Must have a method for each concrete element type
- **Element Modification**: Elements must accept visitors and call the appropriate visit method
- **Circular Dependencies**: Visitors depend on element classes, elements depend on visitor interface
- **Adding Elements**: Requires updating all existing visitors when new element types are added
- **Composite Pattern**: Often used together with Composite pattern for tree structures
- **Performance**: Method dispatch overhead, but usually acceptable

## Comparison with Other Patterns

**Visitor vs Strategy:**
- Visitor: Defines operations on elements without changing them
- Strategy: Allows interchangeable algorithms for a single operation

**Visitor vs Command:**
- Visitor: Defines what to do with each element type
- Command: Encapsulates a single action or request

**Visitor vs Iterator:**
- Visitor: Performs operations on elements during traversal
- Iterator: Provides access to elements without exposing structure

This implementation demonstrates how the Visitor pattern enables clean separation of algorithms from data structures, making systems more maintainable and extensible.</content>
<parameter name="filePath">c:\Repos\DesignPatterns\VisitorPattern\README.md