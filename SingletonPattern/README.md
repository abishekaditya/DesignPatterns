# Singleton Pattern

This folder implements the Singleton design pattern in C# using a `ChocolateBoiler` example.

## Pattern overview

Singleton ensures a class has only one instance and provides a global point of access to it.

Key characteristics:

- single instance is created
- controlled access through a static method
- private constructor prevents external instantiation
- thread-safe lazy initialization using `Lazy<T>`

## Implementation details

- `ChocolateBoiler` class is the singleton.
- The instance is stored in a private static field:
  - `private static readonly Lazy<ChocolateBoiler> _singleton`
- Access is through:
  - `public static ChocolateBoiler GetInstance()`
- Constructor is private:
  - `private ChocolateBoiler()`

State machine:

- `Status.Empty`
- `Status.InProgress`
- `Status.Boiled`

Methods enforce state transition rules:

- `Fill()` → from Empty to InProgress
- `Boil()` → from InProgress to Boiled
- `Drain()` → from Boiled to Empty

## Usage

In `Program.Main()`:

```csharp
var chocoEggs = ChocolateBoiler.GetInstance();
chocoEggs.Fill();
chocoEggs.Boil();
chocoEggs.Drain();
```

The same instance is returned on subsequent `GetInstance()` calls.

## Why use Singleton?

- ensures consistent object state across the app
- avoids repeated expensive initialization
- useful for shared services or resources (config, logger, connection pools)

## Notes

- In multithreaded contexts, `Lazy<T>` makes initialization thread-safe by default.
- Avoid overuse, as Singleton can introduce hidden global state and tight coupling.
