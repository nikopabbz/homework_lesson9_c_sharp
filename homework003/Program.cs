// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Prompt(string msg)
{
    System.Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN > 0)
    {
        return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
    }
    else if (numberM > 0 && numberN == 0)
    {
        return (AkkermanFunction(numberM - 1, 1));
    }
    else return numberN - 1;
}
int n = Prompt("Введите число N -> ");
int m = Prompt("Введите число M -> ");
System.Console.WriteLine(AkkermanFunction(m, n));

