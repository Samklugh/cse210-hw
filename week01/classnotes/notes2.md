# C# Programming Exercise 2: If Statements

## Overview
This activity will help you learn to work with variables and conditional statements in C#.

## Preparation Material

### Conditionals
C# uses `if` statements like Python, but the syntax is slightly different.

### If Statements
In C#, the condition of an `if` statement must be in parentheses `()`.  
The body is defined by curly braces `{}` (not indentation).  
Unlike Python, C# does not use `:` to begin a block.

C#:

```csharp
if (x > y)
{
    Console.WriteLine("greater than");
}
```

Python:

```python
if x > y:
    print("greater than")
```

Convention in C# is to put braces on their own lines.

Nested blocks:

```csharp
if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("greater than both");
    }
}
```

### Else and Else If
C# supports `else` and `else if` (Python uses `else` and `elif`).

`else` example:

C#:

```csharp
if (x > y)
{
    Console.WriteLine("greater than");
}
else
{
    Console.WriteLine("less than");
}
```

Python:

```python
if x > y:
    print("greater than")
else:
    print("less than")
```

`else if` example:

C#:

```csharp
if (x > y)
{
    Console.WriteLine("greater than y");
}
else if (x > z)
{
    Console.WriteLine("greater than z");
}
else
{
    Console.WriteLine("less than both");
}
```

Python:

```python
if x > y:
    print("greater than y")
elif x > z:
    print("greater than z")
else:
    print("less than both")
```

### Operators
C# uses familiar comparison operators:

- `==`
- `!=`
- `>=`
- `<=`

Examples:

```csharp
if (name == "John")
{
    Console.WriteLine("The name is John");
}

if (color != favoriteColor)
{
    Console.WriteLine("That color is not my favorite");
}
```

### And, Or, and Not Operators
In C#:

- `and` is `&&`
- `or` is `||`
- `not` is `!`

Examples:

```csharp
if (name == "Peter" || name == "James" || name == "John")
{
    Console.WriteLine("This is a biblical name.");
}

if (firstName == "Brigham" && lastName == "Young")
{
    Console.WriteLine("Welcome Brother Brigham!");
}

if (!(name == "Peter" || name == "James" || name == "John"))
{
    Console.WriteLine("This is not one of those three");
}
```

### Variables and Types
In C#, variable naming convention is camel case:

```csharp
string color;
string firstName;
string lastName;
int velocityBeforeImpactWasMade;
```

### Converting Types
In C#, all variables must have a type when declared. A variable's type does not change later.

Convert text digits to an integer with `int.Parse()`:

```csharp
string valueInText = "42";
int number = int.Parse(valueInText);
```

This is important for user input, since `Console.ReadLine()` always returns a string:

```csharp
Console.Write("What is your favorite number? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
```

If the input is not numeric, this causes a runtime exception.

### Numbers to Strings
Convert an integer to a string with `.ToString()`:

```csharp
int number = 42;
string textVersion = number.ToString();
```

## Video Demo
These fundamentals are demonstrated in the course video.

## Assignment Instructions
For this assignment, complete a previous CSE 110 assignment, now written in C#.

### Program Specification
Determine the letter grade for a course using:

- `A >= 90`
- `B >= 80`
- `C >= 70`
- `D >= 60`
- `F < 60`

### Assignment
Complete core requirements first, then optional stretch challenges.

Work through requirements in order.

## Core Requirements
1. Ask the user for grade percentage, then use `if`, `else if`, `else` statements to print the correct letter grade.
2. Assume passing is at least `70`. After printing grade, use a separate `if` statement to print a pass/fail message.
3. Refactor so each branch sets a variable named `letter`, then print the letter once after the full conditional chain.

## Stretch Challenge
1. Add support for `+` and `-` grade signs (for example, `B+`, `A-`).
2. Use last digit logic:
- `>= 7` gives `+`
- `< 3` gives `-`
- Otherwise, no sign
3. Store sign in a variable and print letter + sign together.
4. Hint: Use remainder (modulo) to get the last digit.
5. Handle special cases:
- No `A+` (only `A` and `A-`)
- No `F+` or `F-` (only `F`)

## Write and Test the Program

- Complete all 3 core requirements.
- Stretch challenges are optional.
- Use the same project template as Exercise 1.
- Add your code in `Program.cs` for the `Exercise2` project.
