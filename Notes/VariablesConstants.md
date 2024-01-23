Primitive Types and Expressions
****
1. Variables:
***
A variable is a name that we give to a storage location in memory. We use variables to store temporary values in memory.

2. Constants:
****
A constant is a value that cannot be changed. We use constants in situations where we need to ensure that a value does not change. For example, if you're working on a program where you need to calculate the area of a circle, you need to use the Pi number (3.14). You can define Pi as a constant to ensure you don't accidentally change the value of Pi in computations.

To define a variable, we specify a type and an identifier:

**int number**;

Here, int represents the integer type, which takes 4 bytes of memory. You can find the most frequently used data types in the next section.
Number is the identifier for our variable. We can optionally set the value of a variable upon declaration. This is called “initializing a variable”:

**int number = 5**;

***Remember: in C#, you cannot read the value of a variable unless you have set it before.***


*** Varialbe Constant Declaration***
1. Data Type needed
2. An Identifier (name of the variable or const).
    a. Idenfifier cannot start with number, eg., 1route ---- oneRoute
    b. Idenfifier Cannot include space in name, eg., first name ----- firstName
    c. Idenfifier Cannot be a reserved keyword, eg., int ------ @int
    d. Idenfifier must have a meningful name, eg., fn ------ firstName
    e. Name Convetions:
        1. Camel Case: firstName, eg., int number;
        2. Pascal Case: FirstName, eg., const int MaxZoom = 5;
        3. Hungarian Notation: strFirstName
3. Initializer (the value for variable & const)

***Real Nubmers***
**double** is the Default Data Type used in C-Sharp Complier.
**float** define as float number = 1.2f;
**decimal** define as decimal number  = 1.2m;