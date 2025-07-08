// introduction to strings

// first and lastname variables
string firstName = "      Richmond    ";
string lastName = "Andoh";

// remove leading and trailing spaces from firstName with TrimStart() and TrimEnd()
firstName = firstName.TrimStart();
firstName = firstName.TrimEnd();

// or you can use Trim() to remove both leading and trailing spaces
firstName = firstName.Trim();


Console.WriteLine($"Hello My first Name is {firstName} and My surname is {lastName}!");


//friends
string firend1 = "Desmond";
string friend2 = "Kojo Spencer";
string friend3 = "Kwame";

Console.WriteLine($"My friends are {firend1}, {friend2} and {friend3}!");