Console.Clear ();
Console.Write("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());
int number1 = number / 100;
int number2 = (number - number1 * 100) / 10;

Console.Write($"Вторая цифра этого числа: {number2}");