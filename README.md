# Assignment 02 - Number Guessing Game and Grade Tracker

This repository contains two small C# console applications built for Week 2:
1. **GuessingGame** - A number guessing game where the player has a limited number of tries to guess a random number between 1 and 100.
2. **GradeTracker** - A student grade tracker that stores scores in an array and calculates the class average, highest score, lowest score, and letter grade for each student.

## How to Run

### Using Visual Studio
1. Clone or download this repository.
2. Open `GuessingGame.slnx` in Visual Studio.
3. Right-click either **GuessingGame** or **GradeTracker** in the Solution Explorer and select **Set as Startup Project**.
4. Press `F5` or click **Start** to run the console app.

### Using the .NET CLI
Run the Guessing Game:
```bash
dotnet build GuessingGame/GuessingGame.csproj
./GuessingGame/bin/Debug/GuessingGame.exe
```

Run the Grade Tracker:
```bash
dotnet build GradeTracker/GradeTracker.csproj
./GradeTracker/bin/Debug/GradeTracker.exe
```

## How It Works / Design

Both programs use a `while` loop in `Main` to show a menu that repeats until the user chooses to quit. Instead of putting all the logic inside `Main`, the code is split into smaller helper methods:

- **GuessingGame**:
  - `ShowMenu()` prints the menu options.
  - `PlayGame()` generates a random number from 1 to 100 and loops for up to 5 tries.
  - `CheckGuess()` compares the user's guess with the secret number and tells them if it is too high, too low, or correct.

- **GradeTracker**:
  - `ShowMenu()` prints the menu options.
  - `EnterScores()` asks how many students there are and stores their scores in an `int[]` array using a `for` loop.
  - `ShowReport()` prints each student's score and grade, plus the class summary.
  - `GetAverage()`, `GetHighest()`, `GetLowest()`, and `GetGrade()` calculate the results from the array.

## Assumptions and Known Limitations

- The programs expect the user to type valid whole numbers (integers) when entering guesses, student counts, and scores. Entering letters instead of numbers will cause `Convert.ToInt32` to throw a format error.
- Scores are assumed to be between 0 and 100 (70+ = A, 60-69 = B, 50-59 = C, 40-49 = D, below 40 = F).
- Student scores are stored in memory inside an array while the app is running and are not saved to a file after closing the program.
