Console.Clear ();
Console.Write("Введите цифру: ");

int number = int.Parse(Console.ReadLine());

if (number > 7)
{
    Console.Write("Значение не соответствует дню недели");
}
else
{
    if (number > 5)
    {
        Console.Write("Да");
    }
    else 
    {
        Console.Write("Нет");
    }
}