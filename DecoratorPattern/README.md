# Decorator Pattern

This folder implements the Decorator design pattern in C# using a coffee shop beverage example.

## Pattern overview

Decorator attaches additional responsibilities to an object dynamically. It provides a flexible alternative to subclassing for extending functionality.

In this example:

- `Beverage` is the component interface.
- `CondimentDecorator` is the decorator base.
- `Espresso`, `DarkRoast`, `HouseBlend` are concrete components.
- `MochaCondiment`, `WhipCondiment` are concrete decorators that wrap beverages.

## Project structure

- `Beverage.cs`: abstract component with `Description` and `Cost()`.
- `CondimentDecorator.cs`: abstract decorator extending `Beverage`.
- `Espresso.cs`, `DarkRoast.cs`, `HouseBlend.cs`: concrete beverages.
- `MochaCondiment.cs`, `WhipCondiment.cs`: concrete decorators adding condiments.
- `Program.cs`: demo wrapping beverages with multiple condiments.

## How it works

1. Decorators wrap components, delegating calls to the wrapped object.
2. Each decorator adds its own behavior (e.g., cost, description).
3. Multiple decorators can be stacked dynamically.
4. Clients treat decorated objects uniformly via the component interface.

## Usage

```csharp
Beverage beverage = new DarkRoast();
beverage = new MochaCondiment(beverage);
beverage = new WhipCondiment(beverage);
Console.WriteLine(beverage.Description + " $" + beverage.Cost());
```

## Why this pattern is useful

- Adds responsibilities without subclassing.
- Combines behaviors at runtime.
- Avoids class explosion from all possible combinations.
- Follows open-closed principle for extension.