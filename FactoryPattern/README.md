# Factory Pattern

This project demonstrates the implementation of two creational design patterns: the **Factory Method** pattern and the **Abstract Factory** pattern. These patterns are used together to create a pizza ordering system that can produce different styles of pizzas (New York and Chicago) with their respective ingredients.

## Overview

The Factory Method pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

In this implementation:
- **Factory Method**: Creates different types of pizzas (Cheese, Clam, Veggie) in different styles (NY or Chicago)
- **Abstract Factory**: Creates the ingredients for each pizza style (dough, sauce, cheese, veggies, clams)

## Project Structure

### Core Classes
- `Pizza.cs` - Abstract base class for all pizzas with common preparation steps
- `PizzaFactory.cs` - Abstract factory method class that defines the pizza creation process
- `IIngredientsFactory.cs` - Abstract factory interface for creating pizza ingredients

### Concrete Factories
- `NyPizzaFactory.cs` - Creates New York-style pizzas
- `ChicagoPizzaFactory.cs` - Creates Chicago-style pizzas
- `NyIngredientsFactory.cs` - Creates New York-style ingredients
- `ChicagoIngredientsFactory.cs` - Creates Chicago-style ingredients

### Concrete Products
- `CheesePizza.cs`, `ClamPizza.cs`, `VeggiePizza.cs` - Different pizza types
- Various ingredient classes (`ThinCrust.cs`, `DeepDish.cs`, `Mozarella.cs`, `Parmesan.cs`, etc.)

## How It Works

1. **Pizza Ordering**: The client calls `Order()` on a concrete pizza factory (e.g., `NyPizzaFactory`)
2. **Factory Method**: The factory's `Order()` method calls the abstract `Create()` method, which is implemented by subclasses to create the appropriate pizza type
3. **Abstract Factory**: Each pizza constructor receives an `IIngredientsFactory` that creates the style-specific ingredients
4. **Preparation**: The pizza's `Prepare()` method uses the ingredients factory to get all necessary components

### Example Usage

```csharp
// Yankees fan orders NY-style pizza
var yankees = new NyPizzaFactory();
yankees.Order(PizzaType.Cheese);

// Cubs fan orders Chicago-style pizza
var cubs = new ChicagoPizzaFactory();
cubs.Order(PizzaType.Clam);
```

This results in:
- NY Cheese Pizza: Thin crust, Mozarella cheese, Cherry tomato sauce, Onion/Pepper/Olive veggies
- Chicago Clam Pizza: Deep dish, Parmesan cheese, Plum tomato sauce, Onion/Cucumber/Pepper veggies, Fresh clams

## Benefits

1. **Encapsulation**: Object creation is encapsulated within factory classes
2. **Flexibility**: Easy to add new pizza types or ingredient families without changing existing code
3. **Consistency**: Ensures that related objects (ingredients) are created together
4. **Maintainability**: Changes to ingredient creation are isolated to their respective factories
5. **Extensibility**: New pizza styles can be added by creating new factory classes

## Key Design Principles Demonstrated

- **Dependency Inversion**: High-level modules (pizza factories) don't depend on low-level modules (ingredients)
- **Single Responsibility**: Each factory is responsible for creating one family of products
- **Open/Closed Principle**: New pizza types can be added without modifying existing code</content>
<parameter name="filePath">c:\Repos\DesignPatterns\FactoryPattern\README.md