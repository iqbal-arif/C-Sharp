// See https://aka.ms/new-console-template for more information
Console.WriteLine("Strings!\n");

var fullName = "Arif Iqbal  ";

// Trim
Console.WriteLine("Trim  : '{0}'", fullName.Trim());
//ToUppper
Console.WriteLine("Toupper  : '{0}'", fullName.Trim().ToUpper());

//IndexOf
var index = fullName.IndexOf(" ");
var firstName = fullName.Substring(0,index);
var lastName = fullName.Substring(index + 1);
Console.WriteLine("FirstName: " + firstName);
Console.WriteLine("LasttName: " + lastName);

//Split
var fullName2 = "Abdul-Sattar Khan";
var names = fullName2.Split("-");
Console.WriteLine("FirstName : " + names[0]);
Console.WriteLine("LastName : " + names[1]);

//Replace
fullName.Replace("Iqbal", "Iqbal Khan");
Console.WriteLine(fullName); // The replace does not modify the original variable. It creates a new one.

Console.WriteLine(fullName.Replace("Iqbal", "Iqbal Khan"));

// Is NullOrEmpty


if (String.IsNullOrEmpty(null)){Console.WriteLine("Invalid Null");} 
if (String.IsNullOrEmpty(" ")){Console.WriteLine("Invalid EmptySpace");} 
if (String.IsNullOrEmpty("")){Console.WriteLine("Invalid NoEmptySpace");}
if (String.IsNullOrEmpty(" ".Trim())){Console.WriteLine("Invalid EmptySpace with Trim");}

// IsNullOrWhiteSpace
if (String.IsNullOrWhiteSpace(null)){Console.WriteLine("Invalid Null");}
if (String.IsNullOrWhiteSpace(" ")){Console.WriteLine("Invalid WhiteSpace Empty");}
if (String.IsNullOrWhiteSpace("")){Console.WriteLine("Invalid NoWhiteSpace");}


//Converting To Number

var str = "27";
var age = Convert.ToByte(str);
Console.WriteLine(age);

//Converting To String
float price = 29.95f;
var currency = price.ToString("C0");
Console.WriteLine(currency);




