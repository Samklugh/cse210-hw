# C# Programming Exercise 1: Input and Output

## Overview
Ensure that your tools are installed and that you can compile and run a basic program in C#.

C# (pronounced *C-Sharp*) is very similar to other procedural or object-oriented programming languages, so if you have learned to program in one of them, you should be able to leverage the core concepts that you already know and focus on the slight differences in syntax.

You should already be familiar with:

- Variables
- Loops
- Lists
- Conditionals (`if` statements)
- Functions

If you are not comfortable with these, you are not prepared to start this course.

## Preparation Material
This material outlines some major differences between C# and Python, highlighting the pieces you need for this assignment.

In addition to this text, use the web as a primary source for learning. Useful searches include:

- `C# print statement`
- `C# for loop`
- `C# open file and read line by line`

Stack Overflow is a strong resource for these types of questions.

## C# Language Fundamentals
C# uses the same concepts as Python in terms of variables, loops, expressions, and so forth. Here are the key syntax differences.

### 1) Defined Types
In C#, when a variable is declared, its data type must be specified. The computer then knows how much memory to allocate for it. Once a variable's type is defined, it cannot be changed later.

Declare first, assign later:

```csharp
int x;
x = 5;
Console.WriteLine(x);
```

Declare and initialize in one statement:

```csharp
int x = 5;
Console.WriteLine(x);
```

Common built-in types:

- `int` - Integers (whole numbers, positive and negative)
- `string` - Strings (a sequence of characters, including letters, numbers, or symbols)
- `float` - Floating-point numbers (numbers that use decimals)
- `double` - Double precision floating-point numbers (larger range and precision than `float`)
- `bool` - Boolean variables (`true` or `false`)

### 2) Input and Output
In C#, to print to the console, use `Console.WriteLine("")`.

Python:

```python
print("Hello World!")
```

C#:

```csharp
Console.WriteLine("Hello World!");
```

`Console.WriteLine("")` writes a full line including a newline. If you do not want a newline at the end, use `Console.Write("")`.

```csharp
Console.Write("There will not be a newline after this.");
```

To get input in C#, use `Console.ReadLine()`, which returns a string from what the user typed.

- It returns a `string`, not an integer or floating-point number.
- Use `Console.ReadLine()`, not `Console.Read()`.
- Unlike Python, you do not pass prompt text into `ReadLine()`, so print the prompt first.

Python:

```python
color = input("What is your favorite color? ")
```

C#:

```csharp
Console.Write("What is your favorite color? ");
string color = Console.ReadLine();
```

### 3) Curly Braces Define Blocks
In C#, curly braces `{}` define the body of an `if` statement or function. In Python, block bodies are defined by indentation.

In C#:

- You still indent for readability, but braces define the body.
- You do not use `:` to start a block.
- Conditions for `if` statements must be in parentheses `()`.

C#:

```csharp
if (x > y)
{
    Console.WriteLine("greater");
}
```

Python:

```python
if x > y:
    print("greater")
```

### 4) Statements End in Semicolons
In C#, statements end with `;`.

This rule applies to statements such as:

- Calling a function
- Declaring a variable
- Assigning a variable

Do not put a semicolon between the condition of an `if` statement and its body, or between a function name/signature and its body.

### 5) String Interpolation
In C#, if you want to use a variable inside a string, start the string with `$` (similar to Python `f`-strings).

Python:

```python
school = "BYU-Idaho"
print(f"I am studying at {school}.")
```

C#:

```csharp
string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");
```
