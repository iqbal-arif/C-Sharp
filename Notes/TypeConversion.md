**Type Conversion**
***
1. Implicit type conversion

    Example 1
    byte b =1; takes 1 byte memory space    (00000001)
    Assigning i int to value of byte b (no data loss)
    int i = b; takes 4 bytes memory space   (00000000 00000000 00000000 00000001)

    Example 2
    int i = 1;      takes 4 bytes memory space
    Assigning f float to value of int i (no data loss)
    float f = i ;   takes 4 bytes memory space 


2. Explicit type conversion (Casting)
    Example 3
    int i = 1;
    byte b = i ; // won't compile
    byte capacity will be exceeding int capacity (data loss)
    To Fix apply Casting
    int i = 1;
    byte b = (byte)i ;

    float f = 1.0f;
    int i = (int)f;

3. Conversion between non-compatible types.
    string s = "1";
    int i = (int)s; // won't compile

    //Fix use C# System Method **Convert.ToInt32**

    int i = Covert.ToInt32(s); ( int has 4 bytes * each byte is 8 bits = 32 bits)

    int j = int.Parse(s);

    Covert Method

    . ToByte()      (convert to byte)
    . ToInt16()     (convert to short)
    . ToInt32()     (convert to integer)
    . ToInt64()     (convert to long)
