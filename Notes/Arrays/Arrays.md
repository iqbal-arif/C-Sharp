**Arrays**
***
Represents a fixed number fo variables of a particular type.

**Single Dimension Arrays**
***

var nubmers = new int [5];
var nubmers = new int [5]{1,2,3,4,5};

**Syntax-Rectangle Array**
***

var matrix =  new int[3,5];
var matrix = new int [3,5]
{
    {1,2,3,4,5},
    {6,7,8,9,10},
    {11,12,13,14,15}
};
//Acessing the value
var element = matrix[0,0];

**Syntax-Jagged Array**
***
var array = new int[3][];

array[0] = new int[4];
array[1] = new int[5];
array[2] = new int[3];

//Accessing the value
var array[0][0] = 1;

**Methods of Array**

Length
Clear()
Copy()
IndexOf()
Reverse()
Sort()