// See https://aka.ms/new-console-template for more information
Console.WriteLine("Working With Dates!");

var dateTime = new DateTime(2019, 12, 1);
var now = DateTime.Now;
var today = DateTime.Today;
var currentYear = DateTime.IsLeapYear(now.Year) ? now.Year : now.Month;
Console.WriteLine(currentYear);

Console.WriteLine("Hour: " + now.Hour);
Console.WriteLine("Minute: " + now.Minute);
Console.WriteLine();

var tomorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

//TIME SPAN

//Writing Time Methods
var timeSpan = new TimeSpan(0, 0, 0);
var timeSpan2 = new TimeSpan(1, 0, 0);
var timeSpan3 = new TimeSpan(1, 2, 3);

Console.WriteLine(timeSpan);
Console.WriteLine(timeSpan2);
Console.WriteLine(timeSpan3);

var startTime = DateTime.Now;
var endTime = DateTime.Now.AddMinutes(2);
Console.WriteLine(startTime - endTime);

// TIME PROPERTIES

Console.WriteLine("Minutes: " + timeSpan3.Minutes); //2 minutes
Console.WriteLine("Total Minutes: " + timeSpan3.TotalMinutes); // 62.05 minutes add all minutes

//Add , Since time is immutable, but can be modified with timespan methods

Console.WriteLine("Add Example: " + timeSpan3.Add(TimeSpan.FromMinutes(8)));
Console.WriteLine("Subtract Example: " + timeSpan3.Subtract(TimeSpan.FromMinutes(2)));

//ToString conversion
Console.WriteLine("ToString: " + timeSpan.ToString()); // convert to string
Console.WriteLine("Parse: " + TimeSpan.Parse("01:023:03"));

Console.WriteLine(TimeSpan.FromHours(1));