# C# Programming Exercise 3: Loops

## Overview
This activity will help you learn to work with loops in C#.

## Preparation Material

### Loops
C# provides four kinds of loops:

- while
- do-while
- for
- foreach

### While Loops
While loops in C# work exactly the same way as in Python or other languages. The only difference is that C# uses curly braces {} to define the body of the loop, and the condition, must be surrounded by parentheses ().

**C#**

```csharp
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}
```

**Python**

```python
response = "yes"

while response == "yes":
    response = input("Do you want to continue? ")
```

### Do-While Loops
Many languages have a construct called a do-while loop (Python does not). This loop works the same as a while loop, with the exception that the body of the loop runs once first, before the check is made for the first time. This means that the body of the loop is guaranteed to run at least once.

The syntax for a do-while loop is to use the keyword do, followed by the body, followed by the the while keyword with the expression and a semi-colon as shown:

```csharp
string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");
```

### For Loops
The standard for loop in C# is more like a "for x in range" loop in Python. The condition has three parts, separated by semi-colons. The first initializes the value, the second is the condition to check, and the third is an increment step that is run at the end of each loop.

The following code shows the syntax of a for loop that counts from 0 to 9.

```csharp
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

In that code, you will see the use of the ++ operator which increments the value in the variable by one.

The code above is the most common way to see one of these loops, but you could put other values or statements in these spots, such as counting from 2 to 20 by two's:

```csharp
for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}
```

### Foreach Loops
C# contains a foreach loop that is similar to a standard for loop in Python. It is important to remember that the iterator variable must have its type defined, just like when declaring any other variable:

```csharp
foreach (string color in colors)
{
    Console.WriteLine(color);
}
```

The foreach loop will be used extensively in the next preparation material that discusses lists.

### Random Numbers
In addition, for this assignment you'll need to get a random number from the computer. In C#, this is done by creating an instance of the Random class, and then using it to get the next integer in a particular range.

```csharp
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);
```

## Assignment Instructions
For this assignment, you will complete another assignment that you did previously in CSE 110, but in this case, write the program in C#:

### Program Specification
Here are the instructions that you saw previously in CSE 110 that we will use as our program specification:

#### Overview
In the Guess My Number game the computer picks a magic number, and then the user tries to guess it. After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic number.

This assignment is a little tricky, because it brings together many of the concepts you've learned in this course including loops and if statements.

#### Core Requirements
Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because many people benefit from seeing the program built up step by step.

Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)

Ask the user for a guess.

Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.

At this point, you won't have any loops.

The following shows the expected output at this point:

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

Add a loop that keeps looping as long as the guess does not match the magic number.

At this point, the user should be able to keep playing until they get the correct answer.

The following shows the expected output at this point:

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

Instead of having the user supply the magic number, generate a random number from 1 to 100.

Play the game and make sure it works!

#### Stretch Challenge
Keep track of how many guesses the user has made and inform them of it at the end of the game.

After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".

## Write and Test the program
Write and test the program as described above.
You should complete the 3 Core Requirements.
The stretch challenges are optional.
Make sure to use the same project template that you did for the previous activities. However, this time, you should add your code in Program.cs file in the the Exercise3 project.

## Sample Solution
When you have finished the program, please compare your approach to the one from this sample solution:

C# Programming Exercise 03 Sample Solution

## Getting Help
If you get stuck, please ask questions in MS Teams.

## Submitting
Return to Canvas and complete the corresponding quiz.
