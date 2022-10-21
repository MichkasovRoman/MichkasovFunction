// Функция Мичкасова по заданному основанию.

int MichkasovFunction(int number1, int number2)
{
    int count = 0;
    while (number1 % number2 == 0)
    {
        number1 = number1/number2;
        count ++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите аргумент функции: x = ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите основание функции: a = ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine($"mich({x},{a}) = {MichkasovFunction(x,a)}");
