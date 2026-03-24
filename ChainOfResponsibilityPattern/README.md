# Chain of Responsibility Pattern

This folder implements the Chain of Responsibility design pattern in C# using mathematical operation handlers.

## Pattern overview

Chain of Responsibility allows passing requests along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain.

In this example:

- Handlers process mathematical operations ("Add", "Minus", "Multiply").
- Each handler checks if it can handle the operation; if not, it delegates to the next.
- If no handler can process the request, it returns null.

## Project structure

- `IHandler.cs`: interface with `AddChain()` and `Handle()`.
- `BaseHandler.cs`: abstract base implementing `AddChain()` and holding `_nextInLine`.
- `AdditionHandler.cs`: handles "add" by summing values.
- `SubtractionHandler.cs`: handles "minus" by subtracting values.
- `MultiplicationHandler.cs`: handles "multiply" by multiplying values.
- `Program.cs`: sets up the chain and tests operations.

## How it works

1. Handlers are chained: Addition → Subtraction → Multiplication.
2. `Handle()` is called on the first handler.
3. Each handler checks the `action` string.
4. If it matches, performs the operation; else, calls `_nextInLine.Handle()`.
5. Unhandled requests return null.

## Usage

```csharp
var additionHandler = new AdditionHandler();
var subtractionHandler = new SubtractionHandler();
var multiplicationHandler = new MultiplicationHandler();

subtractionHandler.AddChain(multiplicationHandler);
additionHandler.AddChain(subtractionHandler);

double[] numbers = { 2, 3, 4, 5 };
var result = additionHandler.Handle(numbers, "Add"); // 14.0
```

## Why this pattern is useful

- Decouples sender from receiver.
- Allows dynamic handler chains.
- Promotes loose coupling and extensibility.
- Easy to add new handlers without changing existing code.