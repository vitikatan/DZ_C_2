Console.Clear ();
Console.Write("Введите цифру: ");

int number = int.Parse(Console.ReadLine());

int[]week = {1, 2, 3, 4, 5, 6, 7, 8};
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