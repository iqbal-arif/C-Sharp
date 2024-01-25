Question 1: What is a namespace?
A Conatainer for Classes.

Question 2: What is JIT Compilation?
The compilation of IL code to native machine code at runtime.

Question 3: What is an assembly?
A single unit of deployment of .NET applications

Good job!
This is a more accurate description of an assembly. It's a file, in the form of a executable or a DLL, that contains one ore more namespaces and classes.


**Variables and Constants**

Question 1: What would be the value of number after this line is executed?

byte number = 1000;

A1: This code cannot be compiled.

Question 2: The type long in C# is equivalent to which type in .NET framework?
A2: Int64


Question 3: What would be the output of this program?

byte number = 255;

number += 2;

Console.WriteLine(number);

A3: 1 
Good job!
Number will overflow and the result will be 1.

Question 4: What would be the value of number2 after this code is executed?

int number1 = 257;

byte number2 = number1;

A4: This code cannot be compiled.
Good job!
Since there is a chance for data loss during the conversion, compiler would stop the compilation.

Question 5: What would be the value z?

var x = true;

var y = false;

var z = true && false;

A5: False
Good job!
A logical AND between true and false results in false. 

Question 6: What would be the value of z?

var x = true;

var y = false;

var z = true || false;

A6: True;
Good job!
A logical OR between true and false results in true.

**Non-Primitive**

Question 1: What is the correct way to declare an int array?
A1: int[] nubmers = new int[3];

Q2: What would be the output of this code?

var array1 = new int[3] { 1, 2, 3 };

var array2 = array1;

array2[0] = 0;

Console.WriteLine(array1[0]);

A2: 0
Good job!
Arrays are reference types. So here, both array1 and array2 are referencing the same object in the memory. Any changes applied via array2 (note line 3), will be visible via array1 reference.

Q3: How can we access the first element in this array?

var numbers = new int[3] { 1, 2, 3 };

A3: numbers[0]
Good job!
Arrays in C# are zero-indexed, so the index of the first element is 0.

Q4: We have a class as follows:
public class Point

{
public int X;
public int Y;
}

How can we create an object of type Point?
A4: Point p = new Point();

Q5: We have a TaxCalculator class as follows. How can we call the Calculate method?

public class TaxCalculator
{
public static float Calculate()
{
}
}
A5: TaxCalculator.Calculate();
Good job!
The method is declared as static so it is only accessible via a class reference. 

Q6: The \n escape character in a string represents: 
A6:  A line-break or a new line.

Q7: What would be the result of this program?

var number1 = 1;

var number2 = number1;

number2++;

Console.WriteLine(number1);

A7: 1
Good job!
Both number1 and number2 are integers and they are value types. So they will be two independent values in the memory. Modifying number2 does not affect number1.

Q8: We have an enum as follows:

public enum CustomerType
{
Bronze,
Silver,
Gold
}

What will be the output of this code?

var type = (int)CustomerType.Bronze;

Console.WriteLine(type):

A8: 0
Good job!
Enums are internally integers. The value of the first member of an enum (if not set) is 0.

**Iteration**

Q1: What is the correct syntax to check if number is not 0? 
A1: if (number != 0)
Good job!
Condition should be enclosed with parentheses. 

Q2: Which answer correctly demonstrates the use of for loop to get the numbers 1 to 10?
A2: for (var number = 1; nubmer <= 10; number ++>)

Q3: var cities = new string[] { "Melbourne", "Sydney", "Brisbane" };

What is the correct syntax to iterate over cities using a foreach block?

A3: foreach (var city in cities)

Q4: How many times will this while loop execute?

var numbers = 0;

while (numbers < 5)
{
numbers += 2;
}

A4: 3
Good job!
The first time number is 0, so it's less than 5. Then, it'll be incremented by 2, so it's still less than 5. Next, it'll be 4, so the loop be executed one more time. Finally, it becomes 6 and because it's greater than 5, the loop will not be executed.
