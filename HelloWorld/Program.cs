// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Test Code");
byte number = 255;
int count = 10;
float temperature = 36.6f;
Console.WriteLine($"The number is: {number}");
Console.WriteLine($"The count is {count}");
string firstName = "Prateek";
Console.WriteLine($"temperature: {temperature}");
Console.WriteLine($"FirstName: {firstName}");
bool isWorking = false;
Console.WriteLine($"totalPrice:{isWorking}");

//Instead of specifying data type for each variable I can use var

var tempIsWorking = true;
var string1 = "A"; //String Double Quote
char character2 = 'B'; //Character Single Quote

Console.WriteLine($"tempisWorking:{tempIsWorking}");
Console.WriteLine($"character:{string1}");
Console.WriteLine($"character2:{character2}");
Console.WriteLine("{0},{1}",byte.MinValue, byte.MaxValue);
Console.WriteLine("{0},{1}", float.MinValue, float.MaxValue);
Console.WriteLine("{0},{1}", int.MinValue, int.MaxValue);

const float Pi = 3.14f;
//Pi = 1; //Value That should not be changed in the program should be defiend as constants