// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

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

//Implicit Type Conversion
byte b = 1;
int i = b; // Implicit conversion from byte to int

//Explicit Type Conversion
int x = 100;
byte y = (byte)x; // Explicit conversion from int to byte
//Data loss will occur if the value of x exceeds the range of byte (0 to 255)

float f = 1.0f;
int z = (int)f; // Explicit conversion from float to int    

string str = "123";
int num = int.Parse(str); // Convert string to int
int num2 = Convert.ToInt32(str); // Another way to convert string to int

/*
 Multiline Comment
 In C#
 A byte = 1 byte
 A Short = 2 bytes
 An Int = 4 bytes
 A Long = 8 bytes
*/

//Convert Class
// ToByte(),
// ToInt16(),
// ToInt32(),
// ToInt64(),
// ToString(),
// ToDouble(),
// ToBoolean()
// etc. are some of the methods in Convert class

int ii = 1000;
//byte bb = i; // Implicit conversion from int to byte (if the value of i is within the range of byte)
byte bb = (byte) ii;
Console.WriteLine($"bb: {bb}");

try
{
    var largeNumber = 1000;
    byte smallNumber = Convert.ToByte(largeNumber) ; 
    Console.WriteLine($"smallNumber: {smallNumber}");

    string strBool = "true";
    bool boolValue = Convert.ToBoolean(strBool);
    Console.WriteLine($"boolValue: {boolValue}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

//Operators

//Arithmetic Operators: 

//Addition,+, Adds two operands.,10 + 5,15
//Subtraction,-, Subtracts the second operand from the first.,10 - 5,5
//Multiplication,*, Multiplies two operands.,10 * 5,50
//Division,/, Divides the first operand by the second.,10 / 5,2
//Remainder,%, Returns the remainder after division (modulus).,10 % 3,1

var aa = 10;
var ab = 3;
var cc = 20;
Console.WriteLine($"aa/bb - {aa/ab}");
Console.WriteLine((float)aa / (float)ab);
Console.WriteLine($"aa + ab * cc - {aa + ab * cc}");
Console.WriteLine($"(aa + ab) * cc - {(aa + ab) * cc}");
Console.WriteLine(ab > aa);
Console.WriteLine(ab != aa);
Console.WriteLine(!(ab != aa));
Console.WriteLine($"cc > ab && cc > aa : {cc > ab && cc > aa}");
Console.WriteLine($"ab > cc || cc > aa : {ab > cc || cc > aa}");

//Unary Operators(Using one variable)
//These are shorthand ways to update a variable's current value.

//Increment (++): Increases the value of the variable by 1.
//For example, a++ is functionally the same as writing a = a + 1.

//Decrement (--): Decreases the value of the variable by 1.
//For example, a-- is functionally the same as writing a = a - 1.

//Prefix vs. Postfix
//a++(Postfix):
//The current value of a is used in the expression first, and then it is incremented.

//++a (Prefix):
//The value of a is incremented first, and then the new value is used in the expression.

//Example:
//If a = 5, then Console.WriteLine(a++); prints 5 (but a becomes 6).
//If a = 5, then Console.WriteLine(++a); prints 6.


//Comparision Operators


// Equal,==, a == b, Returns true if values are equal.
// Not Equal,!=, a != b, Returns true if values are not equal.
// Greater than,>, a > b, True if a is larger than b.
// Greater than or equal to,>=, a >= b, True if a is larger than or equal to b.
// Less than,<, a < b, True if a is smaller than b.
// Less than or equal to,<=, a <= b, True if a is smaller than or equal to b.


//Assignment Operators

// Assign,=, a = 1, Sets value.
// Add & Assign,+=, a += 3, a = a + 3.
// Sub & Assign,-=, a -= 3, a = a - 3.
// Mult & Assign,*=, a *= 3, a = a * 3.
// Div & Assign,/=, a /= 3, a = a / 3.


//Logical Operators

// And,&&, a && b,true only if both are true.
// Or,||, a || b,true if at least one is true.
// Not,!,!a, Reverses the boolean value.


//Bitwise & Shift Operators

//Bitwise AND,&, a & b, Compares each bit; results in 1 if both bits are 1.
//Bitwise OR,|, a | b, Compares each bit; results in 1 if either bit is 1.
//Bitwise XOR,^, a ^ b, Results in 1 if bits are different (exclusive or).
//Bitwise NOT,~,~a,"Inverts all bits (0 becomes 1, 1 becomes 0)."
//Left Shift,<<, a << 2,"Shifts bits to the left, filling with zeros."
//Right Shift,>>, a >> 2, Shifts bits to the right.