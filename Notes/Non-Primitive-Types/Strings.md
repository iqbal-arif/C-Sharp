Strings
***

1. What is a string
****
A Sequence of characters. eg., "Hello World".

***string*** word maps to String Class in .NET framework
**Classes** have ***fields*** and ***methods***.
and these are declare has static. SO it can be accessed directly without creating an instance or an object.

**Strings are Immutable**
Once written cannot be changed.
Certain string methods can ***modify*** or ***manipulate*** their values by returing ***New Sting***

e.g.
string name  = "Amona"
char firstChar = name[0];
***Cannot do the following to modify it***
name[0] = "m"


2. How to create strings
***
string fristName = "Mosh";

    a. **Concatenation**
    string name = firstName + " " + lastName;

    b. **String Fromst**
    string name  = string.Format("{0} {1}", fristName, lastName);

    ***Format*** is a static Method of String Class

    ***"{0} {1}"*** is a **Format String** to define a template for a string inside this template

    Converting Array of an Object into string
    string list =  string.Join(",", numbers);

    ***Join*** is a static Method of String Class

    c. **Accessing Elements**
    string name = "Arif";
    char firstChar = name[0];



3. Escape Charaters and Verbatim strings

There are few special characters in C# called escape characters:
\n      New line
\t      Tab
\\      The \ character itself
\’      The ‘ (single quote) character
\"      The “ (double quote) character

Hard to read the following string
var message = “Hi John\nLook at the following path:c:\\folder1\
\folder2”;

Adding **@** sign to convert it to ***verbatim string***

var message = @“Hi John Look at the following path: c:\folder1\folder2”;
