List<int> numbers = new List<int>();
Console.WriteLine("Enter a list of numbers, type 0 when finished.");
int num = -1;
while (num != 0)
{
    Console.Write("Enter number: ");
    num = int.Parse(Console.ReadLine());
    if (num != 0) numbers.Add(num);
}
int sum = numbers.Sum();
double avg = numbers.Average();
int max = numbers.Max();
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {avg}");
Console.WriteLine($"The largest number is: {max}");