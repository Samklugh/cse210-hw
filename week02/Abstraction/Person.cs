using System;

public class Person
{
    // state are variables that are used to store the person class 
    // they are usually camel case and underscore before the variable name
    public string _firstName = "";
    public string _lastName = "";

    public Person() { }

    public void WesternName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
    public void EasternName()
    {
        Console.WriteLine($"{_lastName} {_firstName}");
    }


}