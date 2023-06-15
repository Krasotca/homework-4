Console.Clear();
Console.Write("Введите первое целое число:");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число:");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

Console.Write("Введите третье целое число:");
string userInput3 = Console.ReadLine() ?? "";
int c = int.Parse(userInput3);

int max = int.Parse(userInput1);

if (b > max)
{
    Console.WriteLine($"{b}->max");
}
if (c > max)
{
    Console.WriteLine($"{c}->max");
}
else
{
    Console.WriteLine($"a = {max}-> max");
}

