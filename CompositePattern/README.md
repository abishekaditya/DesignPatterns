# Composite Pattern

This folder implements the Composite design pattern in C# using a restaurant menu example.

## Pattern overview

Composite lets clients treat individual objects and compositions of objects uniformly. It composes objects into tree structures to represent part-whole hierarchies.

In this example:

- `MenuComponent` is the component interface.
- `Menu` is the composite, containing child components.
- `MenuItem` is the leaf, with no children.
- Clients call `Print()` on the root menu, which recursively prints the hierarchy.

## Project structure

- `MenuComponent.cs`: abstract component with common interface.
- `Menu.cs`: composite that holds and manages child components.
- `MenuItem.cs`: leaf component representing individual items.
- `Program.cs`: demo building a menu hierarchy and printing it.

## How it works

1. `Menu` implements `Add()`, `Remove()`, `GetChild()` to manage children.
2. `MenuItem` implements leaf-specific properties (name, price, etc.).
3. `Print()` is implemented in both:
   - `Menu`: prints its name, then calls `Print()` on each child.
   - `MenuItem`: prints item details.
4. Clients treat menus and items uniformly via `MenuComponent`.

## Usage

```csharp
var menu = new Menu("All", "McDonalds");
var breakfast = new Menu("Breakfast", "Pancake House");
menu.Add(breakfast);
breakfast.Add(new MenuItem("Waffles", "Butterscotch waffles", 140, false));
menu.Print();  // Prints entire hierarchy
```

## Why this pattern is useful

- Simplifies client code by treating composites and leaves uniformly.
- Makes it easy to add new component types.
- Supports complex tree structures with recursive operations.
- Promotes code reuse and consistency.