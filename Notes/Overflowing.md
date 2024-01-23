**Overflowing**

byte number = 255;
number = number +1; // **Retrun 0; Because exceeding the boundary of the byte data type in C# by default.**

To check the OVerflowing, do following. The C# compiler will throw an Exception.

checked
{
    byte number = 255;
    number = number +1;
}