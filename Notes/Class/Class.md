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

**Methods**

1. Signature of Methods
2. Method Overloading
3. Params Modifier
4. Ref Modifier
5. Out Modifier

```
            //Signature of Methods
            //Move;int x, int y
            //Overloading: same name but different signatures
                public class Point
            {
                public void Move(int x, int y) { }
                public void Move(Point newLocation) { }
                public void Move(Point newLocation, int speed) { }

            }
        //Method with varying nubmer of parameters
        //Wrong way of doing it
        public class Calculator
            {
                public int Add(int n1, int n2) { return n1; }
                public int Add(int n1, int n2, int n3) { return n1; }
                public int Add(int n1, int n2, int n3, int n4) { return n1; }
            }

        //The Prams Modifier
            public class Calculator2
            {
                public int Add(params int[] nubmers) { }
            }

                var result = calculator.Add(new int[] { 1, 2, 3, 4, });
                var result = calculator.Add(1, 2, 3, 4);

        //The Ref Modifier

        public class Weirdo
    {
        public void DoAWeirdoThing(ref int a)
        {
            a += 2;
        }
    }
    var a = 1;
    weirdo.DoAWeirdoThing(ref a);

        //The Out Modifier

        public class MyClass
    {
        public void MyMethod(out int result)
        {
            result = 1;
        }
    }
    int a;
    MyClass.MyMethod(out a);

```

**Fields**

1. Initialzation fields
2. Read-only fields.

     public class Customer
    {
        List<Order> Orders;

        //Use Constructors only when we need to initialize our Fields based on value passed from the outside.
        //Constructor has no parameters
        public Customer()
        {
            Orders = new List<Order>();
        }
    }

    // Here is the Another way of doing it correctly
    // initializing Field WITHOUT any CONSTRUCTOR
    public class Customer
    {
        List<Order> Orders = new List<Order>();
    }

    //Read-Only Fields

    public class Customer
    {
        readonly List<Order> Orders = new List<Order>();
    }