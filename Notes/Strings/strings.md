**Strings**
***
1. String
    a. Convert String to Number
        string s = "1234"
        int i = int.Parse(s)
        int j = Convert.ToInt32(s) :return defaults value as 0
    b. Covnert Numbers to Strings
        int i = 1234;
        string s = i.ToString()         "1234"
        Currency Formatter : string t = i.ToString("C")       "$1,2334.00"
        Currency Formatter : string t = i.ToString(C0")     "$1,234"

Methods
    1. ToUpper()
    2. ToLower()
    3. Trim()
    4. IndexOf("a")
    5. LastIndexOf("Hello")
    6. String.IsNullOrEmpty(str)
    7. String.IsNullOrWhiteSpace(str)
    8. Split() : str.Split(" ")


2. Substrings

Methods
    1. Substring(startIndex)
    2. Substring(startIndex,length)
    3. Repalce("a" , "i")  : Repalce("mosh" , "moshfegh")


