# Template Method Pattern

## Overview

The **Template Method Pattern** is a behavioral design pattern that defines the skeleton of an algorithm in a method, deferring some steps to subclasses. It lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. This pattern is particularly useful when you have a multi-step algorithm where some steps are fixed while others vary.

## Project Structure

This project demonstrates the Template Method Pattern using two examples:

- **Beverage Preparation**: Abstract `Beverage` class with template method for preparing hot beverages
- **Sorting**: `Person` class implementing `IComparable` for custom sorting logic

### Beverage Classes
- `Beverage.cs` - Abstract base class defining the template method `Prepare()`
- `Coffee.cs` - Concrete class implementing coffee-specific brewing and condiment steps
- `Tea.cs` - Concrete class implementing tea-specific brewing and condiment steps

### Comparable Classes
- `Person.cs` - Implements `IComparable` interface for custom sorting by name and age

- `Program.cs` - Main program demonstrating both template method examples

## How It Works

### Beverage Template Method
The `Beverage` abstract class defines the `Prepare()` template method that outlines the algorithm:

```csharp
public void Prepare()
{
    Boil();        // Fixed step
    Brew();        // Abstract step - implemented by subclasses
    Pour();        // Fixed step
    if (WantsCondiments)
        AddCondiments();  // Abstract step - implemented by subclasses
}
```

**Abstract Steps (Implemented by Subclasses):**
- `Brew()` - How to brew the beverage (coffee grounds vs tea leaves)
- `AddCondiments()` - What condiments to add (milk/sugar vs lemon/sugar)

**Concrete Steps (Fixed in Base Class):**
- `Boil()` - Always boils water
- `Pour()` - Always pours into cup

### IComparable Template Method
The `Person` class implements `IComparable.CompareTo()` which serves as a template method:

```csharp
public int CompareTo(object obj)
{
    var other = (Person)obj;
    if (String.Compare(Name, other.Name, StringComparison.Ordinal) == 0)
    {
        return Age.CompareTo(other.Age);  // Secondary sort by age
    }
    return String.Compare(Name, other.Name, StringComparison.Ordinal);  // Primary sort by name
}
```

## Example Usage

### Beverage Preparation
```csharp
// Prepare tea with condiments
var tea = new Tea();
tea.WantsCondiments = true;
tea.AddSugar = 5;
tea.Prepare();
// Output:
// Boling Water
// Adding tea leaves to water and boil
// Pouring in Cup
// Adding Lemon and Sugar
// adding 5 spoons of sugar

// Prepare coffee with condiments
var coffee = new Coffee();
coffee.WantsCondiments = true;
coffee.Prepare();
// Output:
// Boling Water
// Add Coffee Grounds to water and boil
// Pouring in Cup
// Add Milk and Sugar
```

### Custom Sorting
```csharp
var people = new List<Person> {
    new Person("Ram", 25),
    new Person("Abishek", 12),
    new Person("Ram", 18),
    new Person("Abishek", 18)
};

// Before sorting: Ram:25, Abishek:12, Ram:18, Abishek:18
people.Sort();
// After sorting: Abishek:12, Abishek:18, Ram:18, Ram:25 (name first, then age)
```

## Benefits

1. **Code Reuse**: Common algorithm structure is defined once in the base class
2. **Inversion of Control**: Base class controls the algorithm flow, subclasses provide specific implementations
3. **Consistency**: Ensures all subclasses follow the same algorithm structure
4. **Extensibility**: Easy to add new variations by creating new subclasses
5. **Maintainability**: Changes to the algorithm structure only need to be made in one place

## When to Use

- When you have an algorithm with invariant parts that should be in a base class
- When you want to allow subclasses to redefine certain steps of an algorithm
- When you have common behavior among subclasses that can be factored into a common base class
- When you want to control the points of extension in an algorithm
- When implementing frameworks or libraries where users need to customize specific steps

## Real-World Applications

- **Framework Development**: Base framework classes with customizable hooks
- **Data Processing Pipelines**: ETL processes with customizable transformation steps
- **UI Frameworks**: Window creation with customizable initialization steps
- **Game Development**: Character creation with customizable ability assignment
- **Document Processing**: File parsing with customizable validation and processing steps
- **Authentication Flows**: Login process with customizable credential validation
- **Build Systems**: Compilation process with customizable pre/post build steps
- **Sorting and Comparison**: Custom comparison logic for different data types

## Implementation Considerations

- **Hook Methods**: Consider providing hook methods (like `WantsCondiments`) that subclasses can override to customize behavior
- **Abstract vs Virtual**: Use abstract methods for required customizations, virtual methods for optional ones
- **Template Method Naming**: Template methods are usually final (not overridable) to preserve algorithm structure
- **Primitive Operations**: The varying steps are called "primitive operations" or "hook operations"
- **Hollywood Principle**: "Don't call us, we'll call you" - base class controls when to call subclass methods

## Comparison with Other Patterns

**Template Method vs Strategy:**
- Template Method: Inheritance-based, algorithm structure is fixed
- Strategy: Composition-based, entire algorithm can be swapped

**Template Method vs Factory Method:**
- Template Method: Defines algorithm skeleton with varying steps
- Factory Method: Creates objects, often used within template methods

**Template Method vs Command:**
- Template Method: Defines how a multi-step process works
- Command: Encapsulates a single action or request

This implementation demonstrates how the Template Method pattern provides a powerful way to define algorithm skeletons while allowing customization through inheritance.</content>
<parameter name="filePath">c:\Repos\DesignPatterns\TemplatePattern\README.md