# Iterator Pattern

This project demonstrates the **Iterator** design pattern, a behavioral pattern that provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

## Overview

The Iterator pattern allows clients to traverse different types of collections (aggregates) in a uniform way, without needing to know the internal structure of the collection. It encapsulates the traversal logic within iterator objects that implement a common interface.

In this implementation, a restaurant menu system uses the Iterator pattern to traverse breakfast and dinner menus. The menus use different data structures (ArrayList for breakfast, array for dinner), but clients can iterate over both using the same interface.

## Project Structure

### Core Classes
- `Menu.cs` - Represents a menu item with name, description, price, and vegetarian flag
- `IEnumerable` / `IEnumerator` - .NET interfaces for iteration (built into the framework)

### Aggregate Classes (Collections)
- `BreakfastMenu.cs` - Stores breakfast items in an ArrayList
- `DinnerMenu.cs` - Stores dinner items in a fixed-size array

### Iterator Classes
- `BreakfastMenuIterator.cs` - Iterator for breakfast menu (implements IEnumerable)
- `DinnerMenuIterator.cs` - Iterator for dinner menu (implements IEnumerable)

### Enumerator Classes
- `BreakfastMenuEnum.cs` - Enumerator for breakfast menu (implements IEnumerator)
- `DinnerMenuEnum.cs` - Enumerator for dinner menu (implements IEnumerator)

### Client Classes
- `Client.cs` - Uses the iterators to traverse and display menu items
- `Program.cs` - Main entry point demonstrating the pattern

## How It Works

1. **Aggregate Objects**: `BreakfastMenu` and `DinnerMenu` store menu items in different data structures
2. **Iterator Creation**: Each menu provides an `Items` property that returns an iterator implementing `IEnumerable`
3. **Traversal**: The `Client` uses `foreach` loops to iterate over the menus without knowing their internal structure
4. **Enumeration**: The iterators create enumerators that implement `IEnumerator` to handle the actual traversal

### Key Methods
- `MoveNext()` - Advances to the next element
- `Current` - Returns the current element
- `Reset()` - Resets the iterator to the beginning

### Example Output

```
Waffle  Rs. 125 x 
 Blueberry Sauce topped breakfast Waffles 
Sandwich  Rs. 75 * 
 Veggie Sandwich with tomato and cucumber 
Pankcakes  Rs. 110 x 
 Maple syrup Pancakes 
Corn Flakes  Rs. 60 * 
 Cornflakes with fruits and nuts 
Hamburger  Rs. 160 x 
 Hamburger with cheese and onions 
```

The `*` indicates vegetarian items, `x` indicates non-vegetarian items.

## Benefits

1. **Uniform Access**: Different collection types can be traversed using the same interface
2. **Encapsulation**: Internal structure of collections is hidden from clients
3. **Single Responsibility**: Iterators handle traversal logic separately from collection logic
4. **Extensibility**: New collection types can be added without changing client code
5. **Concurrent Access**: Multiple iterators can traverse the same collection simultaneously

## Key Design Principles Demonstrated

- **Single Responsibility Principle**: Iterators handle traversal, collections handle storage
- **Open/Closed Principle**: New iterators can be added without modifying existing code
- **Information Hiding**: Clients don't need to know collection internals

## When to Use

- When you need to provide a uniform way to access different types of collections
- When you want to hide the internal structure of collections from clients
- When you need to support multiple traversal algorithms for the same collection
- When you want to provide concurrent access to collections

## Real-World Applications

- Database result sets (different databases provide different iterator interfaces)
- File system traversal (different file systems, local vs. network)
- Collection libraries (List, Set, Map iterators in programming languages)
- UI component traversal (tree structures, composite objects)
- Streaming data processing (iterating over large datasets)

## Comparison with Other Patterns

- **Iterator vs. Visitor**: Iterator traverses elements, Visitor performs operations on elements
- **Iterator vs. Composite**: Iterator provides access to elements, Composite defines element hierarchies
- **Iterator vs. Observer**: Iterator provides pull-based access, Observer provides push-based notifications</content>
<parameter name="filePath">c:\Repos\DesignPatterns\IteratorPattern\README.md