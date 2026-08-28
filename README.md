# CSP26_Console — In-class exercises (console applications)

Template repository for console-based in-class exercises on the
Client-Side Programming course (VAMK, autumn 2026).

Each exercise lives in its own folder (`t0`, `t1`, `t2`, …) inside one
shared Visual Studio solution. Each exercise has an xUnit test project
(`t0.Tests`, `t1.Tests`, …) so you can verify your solution before
submitting.

## Getting started

### 1. Clone this repository

    git clone https://git.vamk.fi/tuo/CSP26_Console.git
    cd CSP26_Console

### 2. Rename origin and add your own remote

    git remote rename origin upstream
    git remote add origin https://git.vamk.fi/<your_username>/<your_repo>.git

Verify your remotes:

    git remote -v
    # origin    https://git.vamk.fi/<your_username>/<your_repo>.git (fetch)
    # upstream  https://git.vamk.fi/tuo/CSP26_Console.git (fetch)

### 3. Push to your own repository

    git push -u origin main

### 4. Implement the exercises

Open `CSP26_Console.sln` in Visual Studio 2022. Each exercise folder
contains a `Program.cs` (and possibly other `.cs` files) with `TODO`
comments marking the parts you need to implement.

### 5. Pull new exercises

When the teacher publishes a new exercise, pull it from upstream:

    git pull upstream main

This adds the new folder to your solution without affecting your existing
work (published exercises are never modified after release).

### 6. Run tests

Open Test Explorer in Visual Studio (Ctrl+E, T) and run all tests, or
use the command line:

    dotnet test

### 7. Commit and push

    git add .
    git commit -m "Complete t1"
    git push origin main

## Project structure

| Folder | Exercise | Tests |
|--------|----------|-------|
| `t0/`  | C# refresher (variables, arrays, loops, methods) | `t0.Tests/` |
| `t1/`  | Person class (constructor, properties, methods, List&lt;T&gt;) | `t1.Tests/` |

More exercises will appear here as the course progresses.

## License

This repository is for educational use only.
