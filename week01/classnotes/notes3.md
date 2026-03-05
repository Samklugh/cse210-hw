# C# Programming Exercise 3: Loops

## Overview
This activity will help you learn to work with loops in C#.

## Preparation Material

### Loops
C# provides four kinds of loops:

- `while`
- `do-while`
- `for`
- `foreach`

### While Loops
`while` loops in C# work like Python. Main syntax differences:

- C# uses curly braces `{}` for the loop body.
- The condition must be in parentheses `()`.

C#:

```csharp
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}
```

Python:

```python
response = "yes"

while response == "yes":
    response = input("Do you want to continue? ")
```

### Do-While Loops
Many languages include `do-while` loops (Python does not).  
Unlike a `while` loop, the body runs once before the condition is checked, so it always runs at least once.

```csharp
string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");
```

### For Loops
The standard `for` loop in C# is similar to Python's `for x in range(...)`.

It has three parts separated by semicolons:

1. Initialization
2. Condition
3. Increment step

Count from `0` to `9`:

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

The `++` operator increments by one.

Count by twos from `2` to `20`:

```csharp
for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}
```

### Foreach Loops
C# `foreach` is similar to Python's `for item in list`.

The iterator variable must include its type:

```csharp
foreach (string color in colors)
{
    Console.WriteLine(color);
}
```

`foreach` will be used extensively in material that discusses lists.

### Random Numbers
For this assignment, you need random numbers.

In C#, create a `Random` object and call `Next(min, maxExclusive)`:

```csharp
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);
```

This gives a number from `1` through `10`.

## Assignment Instructions
For this assignment, complete another CSE 110 assignment in C#.

### Program Specification
Build a "Guess My Number" game:

- The computer picks a magic number.
- The user guesses.
- After each guess, show `Higher` or `Lower` until correct.

This assignment combines loops and `if` statements.

## Core Requirements
Work through these in order:

1. Ask the user for the magic number.
2. Ask the user for a guess.
3. Use an `if` statement to output `Higher`, `Lower`, or `You guessed it!`.

At this stage, no loop is used.

Expected output examples:

```text
What is the magic number? 6
What is your guess? 4
Higher

What is the magic number? 6
What is your guess? 7
Lower

What is the magic number? 6
What is your guess? 6
You guessed it!
```

4. Add a loop so guessing continues until the guess matches the magic number.

Expected output with loop:

```text
What is the magic number? 18
What is your guess? 5
Higher
What is your guess? 6
Higher
What is your guess? 7
Higher
What is your guess? 20
Lower
What is your guess? 19
Lower
What is your guess? 18
You guessed it!
```

5. Replace user-entered magic number with a random number from `1` to `100`.
6. Play and verify behavior.

## Stretch Challenge
1. Track how many guesses the user makes and display it at the end.
2. After each game, ask if they want to play again.
3. Repeat full gameplay while they answer `"yes"`.

## Write and Test the Program

- Write and test the program as described.
- Complete the 3 core requirements.
- Stretch challenges are optional.
- Use the same project template as previous activities.
- Add your code in `Program.cs` in the `Exercise3` project.
