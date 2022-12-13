Console.Clear ();
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
if (number > 100)
{
    string str = number + string.Empty;
    Console.Write($"Третья цифра этого числа: {str[2]}");
}
else 
{
    Console.Write("Третей цифры нет");
}