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

