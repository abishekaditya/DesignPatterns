# Observer Pattern

This project demonstrates the **Observer** design pattern, a behavioral pattern that defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Overview

The Observer pattern allows objects to subscribe to events and get notified when the state of another object changes. It establishes a relationship where the subject maintains a list of observers and notifies them of any state changes.

In this implementation, a weather monitoring system uses the Observer pattern. Weather monitors subscribe to a weather supplier and receive notifications when weather conditions change, displaying relevant data based on their monitoring focus.

## Project Structure

### Core Classes
- `IObservable<Weather>` / `IObserver<Weather>` - .NET interfaces for the observer pattern
- `Weather.cs` - Data class representing weather conditions (temperature, humidity, pressure)

### Subject (Observable)
- `WeatherSupplier.cs` - The subject that maintains weather data and notifies observers

### Observers
- `WeatherMonitor.cs` - Concrete observer that displays weather information
- `Unsubscriber.cs` - Helper class for managing observer unsubscriptions

### Client
- `Program.cs` - Demonstrates the observer pattern in action

## How It Works

1. **Subscription**: Observers call `Subscribe()` on the weather supplier to register for notifications
2. **State Change**: When `WeatherConditions()` is called on the supplier, it creates a new Weather object
3. **Notification**: The supplier iterates through all registered observers and calls `OnNext()` on each
4. **Update**: Each observer receives the weather data and displays relevant information based on its configuration

### Observer Types

The implementation includes different types of weather monitors:
- **TP Monitor**: Displays Temperature and Pressure data
- **H Monitor**: Displays Humidity data

### Example Output

```
TP
| Temperature : 32 Celsius || Pressure : 1.5 atm |
TP
| Temperature : 33.5 Celsius || Pressure : 1.7 atm |
H
| Humidity : 4 % |
TP
| Temperature : 37.5 Celsius || Pressure : 1.2 atm |
H
| Humidity : 7 % |
```

## Key Components

### Subject (WeatherSupplier)
- Maintains a list of observers
- Provides `Subscribe()` method for observers to register
- Implements `WeatherConditions()` to update state and notify observers
- Returns `Unsubscriber` object for clean unsubscription

### Observer (WeatherMonitor)
- Implements `IObserver<Weather>` interface
- Provides `OnNext()`, `OnError()`, `OnCompleted()` methods
- Displays weather data based on monitor type (TP, H)
- Can unsubscribe using the returned `IDisposable`

### Weather Data
- Immutable data class with temperature, humidity, and pressure
- Passed to observers when state changes

## Benefits

1. **Loose Coupling**: Subject and observers are loosely coupled - subject doesn't need to know concrete observer classes
2. **Dynamic Relationships**: Observers can be added or removed at runtime
3. **Broadcast Communication**: Changes are automatically broadcast to all interested observers
4. **Extensibility**: New observer types can be added without modifying the subject
5. **Separation of Concerns**: Subject focuses on its domain logic, observers handle their own display logic

## Key Design Principles Demonstrated

- **Open/Closed Principle**: New observers can be added without changing existing code
- **Single Responsibility**: Each class has a single, well-defined responsibility
- **Dependency Inversion**: High-level modules don't depend on low-level modules

## When to Use

- When changes to one object require changing others, and you don't know how many objects need to be changed
- When an object should be able to notify other objects without making assumptions about who these objects are
- When you need to maintain consistency between related objects
- When you want to broadcast information to multiple receivers

## Real-World Applications

- **GUI Systems**: UI components subscribe to model changes
- **News/Magazine Subscriptions**: Readers subscribe to publications
- **Stock Market**: Investors subscribe to stock price changes
- **Social Media**: Followers subscribe to account updates
- **Event Systems**: Event listeners subscribe to event sources
- **Model-View Patterns**: Views subscribe to model changes

## Comparison with Other Patterns

- **Observer vs. Mediator**: Observer distributes communication, Mediator centralizes it
- **Observer vs. Publish-Subscribe**: Observer is a specific implementation of publish-subscribe
- **Observer vs. Command**: Observer reacts to state changes, Command encapsulates requests

## Implementation Notes

This implementation uses .NET's built-in `IObservable<T>` and `IObserver<T>` interfaces, which provide:
- Type safety through generics
- Standard contract for observer pattern implementation
- Built-in support for error handling and completion
- Automatic unsubscription management

The pattern demonstrates both push and pull models - the subject pushes weather data to observers, and observers pull specific data they need based on their configuration.</content>
<parameter name="filePath">c:\Repos\DesignPatterns\ObserverPattern\README.md