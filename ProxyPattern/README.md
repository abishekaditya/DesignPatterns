# Proxy Pattern

This project demonstrates the **Proxy** design pattern, a structural pattern that provides a surrogate or placeholder for another object to control access to it.

## Overview

The Proxy pattern provides a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

In this implementation, a proxy image provides lazy loading for real images. Instead of loading images from disk immediately when created, the proxy delays loading until the image is actually displayed, improving performance and memory usage.

## Project Structure

### Core Classes
- `Image.cs` - Interface defining the contract for image objects

### Real Subject
- `RealImage.cs` - The actual image implementation that loads from disk

### Proxy
- `ProxyImage.cs` - Virtual proxy that controls access to RealImage with lazy loading

### Client
- `Program.cs` - Demonstrates the proxy pattern usage

## How It Works

1. **Proxy Creation**: Client creates a `ProxyImage` instead of `RealImage`
2. **Lazy Loading**: Proxy stores the filename but doesn't load the image yet
3. **First Access**: When `display()` is called, proxy creates the `RealImage` and loads it
4. **Subsequent Access**: Proxy delegates to the already loaded `RealImage`

### Example Usage

```csharp
// Create proxy - image not loaded yet
Image image = new ProxyImage("testImage.jpg");

// First display - image gets loaded from disk
image.display();  // "Loading testImage.jpg" then "Displaying testImage.jpg"

// Second display - image already loaded, no disk access
image.display();  // "Displaying testImage.jpg" (no loading message)
```

### Example Output

```
Loading testImage.jpg
Displaying testImage.jpg

Displaying testImage.jpg
```

Notice that "Loading" only appears once, demonstrating the lazy loading behavior.

## Types of Proxies

### Virtual Proxy (Implemented)
- Delays creation of expensive objects until needed
- Used for lazy loading and performance optimization

### Protection Proxy
- Controls access to sensitive objects
- Adds security checks before allowing operations

### Remote Proxy
- Represents objects in different address spaces
- Handles network communication transparently

### Smart Proxy
- Performs additional actions when accessing objects
- Reference counting, logging, caching

## Benefits

1. **Performance**: Delays expensive operations until necessary
2. **Memory Efficiency**: Creates heavy objects only when needed
3. **Access Control**: Can add security and validation layers
4. **Transparency**: Client code works with proxy as if it were the real object
5. **Remote Access**: Enables distributed object communication

## Key Design Principles Demonstrated

- **Single Responsibility**: Proxy handles access control, real object handles functionality
- **Open/Closed Principle**: New proxy types can be added without changing existing code
- **Dependency Inversion**: Client depends on abstraction (Image interface)

## When to Use

- When object creation is expensive and should be deferred
- When you need to control access to sensitive objects
- When objects are in remote locations (distributed systems)
- When you need to add logging, caching, or other cross-cutting concerns
- When you want to postpone resource-intensive operations

## Real-World Applications

- **Image Loading**: Virtual proxies for images, videos, documents
- **Database Connections**: Connection pooling and lazy initialization
- **Web Services**: Remote proxies for service calls
- **Security**: Protection proxies for access control
- **Caching**: Smart proxies that cache results
- **Logging**: Proxies that log method calls
- **ORM**: Lazy loading of related objects

## Implementation Considerations

### Proxy vs. Decorator
- **Proxy**: Controls access to the same interface
- **Decorator**: Adds behavior to the same interface
- Both implement the same interface as the wrapped object

### Proxy vs. Adapter
- **Proxy**: Represents the same object with access control
- **Adapter**: Converts one interface to another
- Proxy maintains the same interface, adapter changes it

### Thread Safety
- Virtual proxies may need synchronization for multi-threaded access
- Consider using double-checked locking for thread-safe lazy initialization

## Comparison with Other Patterns

- **Proxy vs. Adapter**: Proxy provides same interface with access control, Adapter changes interface
- **Proxy vs. Decorator**: Proxy controls access, Decorator adds functionality
- **Proxy vs. Facade**: Proxy controls single object access, Facade simplifies subsystem interfaces
- **Proxy vs. Flyweight**: Proxy controls access to one object, Flyweight shares multiple objects

## .NET Implementation Notes

This implementation uses:
- Interface-based design for loose coupling
- Lazy initialization pattern in the proxy
- Standard .NET naming conventions

For more advanced scenarios, consider:
- `Lazy<T>` for thread-safe lazy initialization
- Dynamic proxies using `RealProxy` or third-party libraries
- Aspect-oriented programming for cross-cutting concerns</content>
<parameter name="filePath">c:\Repos\DesignPatterns\ProxyPattern\README.md