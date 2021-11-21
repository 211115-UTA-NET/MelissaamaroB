// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello Melissa");


//Casting
//casting does not change the value stored

Console.WriteLine("##### Casting Example ####");

string start = "Begin";
object z = start;
string end = (string)z;

Console.WriteLine("starting string: " + start);
Console.WriteLine("ending string: " + end);


//Conversion
// may change the value of store

Console.WriteLine("##### Conversion Example ######");
// int a = 7; // -2bill - +2bill
// byte b = (byte) a; // 0-255

double a = 5.5;
int b = (int)a;

Console.WriteLine("The value of a is: " + a);
Console.WriteLine("The value of b is: " + b);

//Parsing
// parsing reads and a string as a numerical value 

bool res;
int parsedString;
string newString = "578";
res = int.TryParse(newString, out parsedString);
Console.WriteLine("String could be parsed: " + res);


parsedString = int.Parse(newString);
Console.WriteLine("The value of parsedString is: " + parsedString);

if (res == true);
{}
    parsedString = int.parse(newString);
    Console.WritingLine("The value of parsedString is: " + parsedString);
 ;
else
{
    Console.WriteLine("The value of newString could not be parsed.")


