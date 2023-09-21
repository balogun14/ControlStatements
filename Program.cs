// See https://aka.ms/new-console-template for more information
// Console.Write("Enter Text: ");
// string text = Console.ReadLine()!;

// if (text == "Hello World!")
// {
//     System.Console.WriteLine($"{text} is correct");
// }
// else
// {
//     System.Console.WriteLine($"{text}  does not match");
// }

Random random = new();
int a = random.Next(5, 50);
int b = random.Next(5, 50);

if (a < b)
{
    System.Console.WriteLine($"{a} is less than {b}");
}

else if (a > b)
{
    System.Console.WriteLine($"{a} is greater than {b}");
}
else
{
    System.Console.WriteLine($"{a} is equals to {b}");
}