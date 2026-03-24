# Builder Pattern

This folder implements the Builder design pattern in C# using hamburger construction examples.

## Pattern overview

Builder decouples the construction of a complex object from its representation, allowing the same construction process to create different representations.

- `IBuilder` defines steps for building a product.
- `Hamburger` is the product being created.
- `MyHamburgerBuilder` and `WifesHamburgerBuilder` are concrete builders with different configurations.
- `Cook` acts as the director and executes build steps in a fixed order.

## How it works

1. `Cook` is initialized with an `IBuilder`.
2. `Cook.Build()` calls:
   - `AddIngredients()`
   - `AddShape()`
   - `AddSize()`
3. After steps complete, `Cook` returns `builder.Build()`.
4. `Cook.ChangeBuilder()` switches builder implementations at runtime.

## Project files

- `IBuilder.cs`: builder interface.
- `Hamburger.cs`: product class.
- `Cook.cs`: director.
- `MyHamburgerBuilder.cs` / `WifesHamburgerBuilder.cs`: concrete builders.
- `Program.cs`: sample usage.

## Usage

```csharp
var builder = new MyHamburgerBuilder();
var cook = new Cook(builder);
var myHamburger = cook.Build();

cook.ChangeBuilder(new WifesHamburgerBuilder());
var wifesHamburger = cook.Build();

Console.WriteLine($"My Hamburger: {myHamburger}");
Console.WriteLine($"My Wife's Hamburger: {wifesHamburger}");
```

## Benefits

- Builds different product variants with shared construction logic.
- Improves code reuse and maintainability.
- Changes to builder steps do not affect director logic.
