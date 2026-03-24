# Facade Pattern

This folder implements the Facade design pattern in C# using a home theater system example.

## Pattern overview

Facade provides a unified interface to a set of interfaces in a subsystem. It defines a higher-level interface that makes the subsystem easier to use.

In this example:

- `HomeTheatreFacade` is the facade.
- `Dimmer`, `Dvd`, `DvdPlayer` are subsystem components.
- Facade methods like `WatchMovie()` coordinate multiple subsystem calls.

## Project structure

- `HomeTheatreFacade.cs`: facade class with high-level methods.
- `Dimmer.cs`: subsystem for lighting control.
- `Dvd.cs`: subsystem for DVD media.
- `DvdPlayer.cs`: subsystem for DVD playback.
- `Program.cs`: demo using facade to control home theater.

## How it works

1. Facade holds references to subsystem objects.
2. High-level methods (e.g., `WatchMovie()`) call multiple subsystem methods in sequence.
3. Clients use the facade instead of dealing with subsystem complexity.
4. Subsystem components remain decoupled from clients.

## Usage

```csharp
var dimmer = new Dimmer();
var dvdPlayer = new DvdPlayer();
var dvd = new Dvd("Movie Title");
var facade = new HomeTheatreFacade(dimmer, dvd, dvdPlayer);

facade.WatchMovie();  // Coordinates dimming, turning on player, inserting DVD, playing
facade.Pause();       // Dims lights and pauses playback
```

## Why this pattern is useful

- Simplifies client interaction with complex subsystems.
- Reduces coupling between clients and subsystem components.
- Promotes loose coupling and easier maintenance.
- Allows subsystem evolution without affecting clients.