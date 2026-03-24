# Bridge Pattern

This folder implements the Bridge design pattern in C# illustrating how weapons and enchantments are decoupled.

## Pattern overview

Bridge separates an abstraction from its implementation so they can vary independently. In this example, weapons are the abstractions and enchantments are the implementations.

- `IWeapon` is the abstraction interface.
- `IEnchantment` is the implementation interface.
- `Sword` and `Hammer` are concrete abstractions.
- `FlyingEnchantment` and `SoulEatingEnchantment` are concrete implementations.

## How it works

Each `IWeapon` holds an `IEnchantment`. Weapon methods delegate behavior to the enchantment, allowing any weapon to be combined with any enchantment:

- `Wield()` calls `IEnchantment.OnActivate()`
- `Swing()` calls `IEnchantment.Apply()`
- `Unwield()` calls `IEnchantment.OnDeactivate()`

This keeps weapon and enchantment hierarchies independent and reusable.

## Project files

- `IWeapon.cs`: abstraction interface.
- `IEnchantment.cs`: implementor interface.
- `Sword.cs`, `Hammer.cs`: concrete abstractions.
- `FlyingEnchantment.cs`, `SoulEatingEnchantment.cs`: concrete implementors.
- `Program.cs`: sample usage.

## Example usage

```csharp
IWeapon sword = new Sword(new FlyingEnchantment());
sword.Wield();
sword.Swing();
sword.Unwield();

IWeapon hammer = new Hammer(new SoulEatingEnchantment());
hammer.Wield();
hammer.Swing();
hammer.Unwield();
```

## Why this pattern is useful

- Adds flexibility by enabling combinations (weapon + enchantment) without class explosion.
- Reduces coupling and improves maintainability.
- Makes it easy to add new weapons or enchantments independently.
