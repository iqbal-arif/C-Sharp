**Class**
Cobines related variabloes (fields) and functions (methods)

1. Class Declaration
****
Access modifier:    public (who can access the class)
Class keyword:      class
An Idendifier:      Person
```
public class Person
{
    public string Name; //Field
    
    public void Introduce() //Methods  (void means does not return any value)
    {
        Console.WriteLine("Hi,my name is " + Name);
    }
}

// Calculator Class

public class Calculatr
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

```
2. Object Declaration
****
    a. Method One
    Person person = new Person ();  // Allocating memory and after process CLR take cares of Garbge Collection.

    b. Method Two
    var person = new Person ();
    person.Name = "ARIF";
    person.Introduce();

3. Static Modifier
***
```
// Calculator Class

public class Calculatr
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

```
***With static modifier we can access it outside the class as follows***
***This way Object creation is not necesary***

int result =  Calculator.Add(1,2);