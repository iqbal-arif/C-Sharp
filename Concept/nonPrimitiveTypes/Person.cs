﻿// See https://aka.ms/new-console-template for more information


namespace CSharpFundamentals
{
    public class Person
{
    public string FirstName;
    public string LastName;

    public void Introduce()
    {
        Console.WriteLine($"My name is {FirstName} {LastName}!");
    }
}
}
