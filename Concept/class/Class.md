***Class**
***
Class is a building block of an application.

**Anatomy of Class**

1. Data : represented by fields
2. Behaviour : represented by methods / functions

***Object***is an instance of Class residing in compuer memory.

**Declaring Class**
```
public class Person
{
    //Field of Class
    public string Name ;

    //Methods in Class
    public void Introduce()
    {
        Console.WriteLine("Hi,my name is " + Name);
    }

}
```
**Object Declaration**
```
Person person  = new Person();

//Shortform of writing Object
var person = new Person();
```
**Using Objects**
```
var person = new Person();
person.Name = "Mosh";
person.Introduce();
```
**Class Methods**

1. Instance: accessible from an object
```
var person = new Person();
person.Introduce();
```
2. Stati: accessible from the class.
```
Console.WriteLine();
```
Why use static members?

1. To represent concepts taht are ***singleton***
   Such as
   DateTime.Now
   Console.WriteLine()


**Declaring Static Members**
```
public class Person
{
    public static int PeopleCount = 0;
}
```
**Constructors**

A method that is called when an instance of class is created.

It is needed to  put an object in an early state to initialize some of the fields in the class.

**Declaration of Constructor**
```
public class Customer
{
    public Customer()
    {

    }
}
```

1. The Constructor name shall be same as class
2. Default values for non-parameter cosntructor are
    a. numbers = 0
    b. boolean = false
    c. string = null
    d. char = empty

```
public class Customer
{
    public string Name;

    public Customer(string name)
    {
            this.Name = name;
    }
}

```
**Constructor**
```
var customer = new Customer("John");
```

***Constructor Overloading***
***Different Signauter Method:***
identifies as unique return type, name and nubmer of its paramters.
```
  public class Customer
    {
        public Customer() { }
        public Customer(string name) { }
        public Customer (int id, string name) { }
    }
```

**Object Initialzer**
A systax for quickly initialising an object without the need to call one of its constructors.

To Avoid creating multiple constructors

public class Person
        { 
            public Person(int id) { }
            public Person(int id, string firstName) { }
            public Person(int id, string firstName, string lastName) { }
            public Person(int id, DateTime birthdate) { }
        }
**Object Initialzer**
var person = new Person
                        {
                            FirstName = "Arif",
                            LastName = "Iqbal"
                        };

