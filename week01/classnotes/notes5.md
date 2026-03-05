# C# Programming Exercise 5: Functions

## Overview
This activity will help you learn to work with functions in C#.

## Preparation

### Functions
Like most other languages, functions are an important part of C#.

Functions in C# are defined and behave similarly to Python functions:

- They have a name.
- They can receive parameters.
- They perform work in a function body.
- They can return a value.

Key C# differences:

- Every function must declare a return type (`int`, `string`, `void`, etc.).
- Every parameter must declare a data type.

This improves clarity because you know what data type is expected.

Function naming style in C# should use **Title Case** (PascalCase), for example:

- `DisplayMessage`
- `PromptUserName`
- `SquareNumber`

General function structure:

```csharp
returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function body
}
```

### Function Examples
Function with no parameters and no return value:

C#:

```csharp
void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}
```

Python:

```python
def display_message():
    print("Hello World")
```

Function with one string parameter:

C#:

```csharp
void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}
```

Python:

```python
def display_personal_message(user_name):
    print(f"Hello {user_name}")
```

Function with two `int` parameters and an `int` return value:

C#:

```csharp
int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
```

Python:

```python
def add_numbers(first, second):
    sum = first + second
    return sum
```

### Functions vs Methods
From previous courses, you may remember the difference between:

- Standalone functions
- Member functions (methods)

In C#, functions are typically methods in the context of classes/objects.

For standalone functions in this course stage, use `static`.

```csharp
static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
```

Use `static` for your functions until you begin writing classes.

### Variable Scope
Like Python, variables declared inside a function are local to that function and cannot be accessed from `Main` or other functions directly.

### Other Operations
There are many more advanced function features, but this assignment focuses on the basics.

## Assignment Instructions
Write a C# program with several simple functions:

- `DisplayWelcome` - Displays `"Welcome to the Program!"`
- `PromptUserName` - Asks for and returns the user's name (`string`)
- `PromptUserNumber` - Asks for and returns the user's favorite number (`int`)
- `SquareNumber` - Accepts an `int` and returns the square (`int`)
- `DisplayResult` - Accepts the user's name and squared number and displays them

Your `Main` function should call each function, save return values, and pass data as needed.

Sample output:

```text
Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Brother Burton, the square of your number is 1764
```

## Write and Test the Program
- Write and test the program as described.
- Use the same project template as previous activities.
- Add your code in `Program.cs` in the `Exercise5` project.
