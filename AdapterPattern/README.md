# Adapter Pattern

This folder demonstrates the Adapter design pattern in C# using a turkey-to-duck adapter example.

## Pattern overview

Adapter lets incompatible interfaces work together. It wraps one object with another adapter so it can be used as if it implemented a target interface.

In this example:

- `IDuck` is the target interface used by client code.
- `ITurkey` is the adaptee interface that has a different API.
- `TurkeyAdapter` converts `ITurkey` callbacks (`Gobble`, `Fly`) into `IDuck` actions (`Quack`, `Fly`).

## Project structure

- `IDuck.cs`: duck contract with `Quack()` and `Fly()`.
- `ITurkey.cs`: turkey contract with `Gobble()` and `Fly()`.
- `WildTurkey.cs`: concrete turkey implementation.
- `TurkeyAdapter.cs`: adapter implementing `IDuck` by delegating to `ITurkey`.
- `Program.cs`: test harness that uses `TurkeyAdapter` where an `IDuck` is expected.

## Behavior details

- `TurkeyAdapter.Quack()` calls `ITurkey.Gobble()`.
- `TurkeyAdapter.Fly()` calls `ITurkey.Fly()` multiple times to compensate for turkey’s short flight capability (adaptation logic in code).

## Usage

```csharp
var turkey = new WildTurkey();
var adapter = new TurkeyAdapter(turkey);
Tester(adapter);

static void Tester(IDuck duck)
{
    duck.Fly();
    duck.Quack();
}
```

## Why this pattern is useful

- Provides compatibility between otherwise incompatible components.
- Supports reuse of existing implementations without modifying them.
- Decouples client code from concrete adaptee classes.
