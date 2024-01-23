**Scope**
*****
1. Scope determines where a value has meaning and is accessible. A variable has a scope in the **block** it is defined and in any child blocks. But it is not accessible outside that block. 
```
{
    byte a = 1;
    {
        byte b = 2;
        {
            byte c = 3;
        }
    }
}
```
2. A block is indicated by curly braces ({ }).