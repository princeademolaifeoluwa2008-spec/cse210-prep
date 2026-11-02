static void DisplayWelcome() { Console.WriteLine("Welcome to the program!"); }
static string PromptUserName() { Console.Write("Please enter your name: "); return Console.ReadLine(); }
static int PromptUserNumber() { Console.Write("Please enter your favorite number: "); return int.Parse(Console.ReadLine()); }
static int SquareNumber(int n) { return n * n; }
static void DisplayResult(string name, int sq) { Console.WriteLine($"{name}, the square of your number is {sq}"); }

DisplayWelcome();
string name = PromptUserName();
int number = PromptUserNumber();
int squared = SquareNumber(number);
DisplayResult(name, squared);
