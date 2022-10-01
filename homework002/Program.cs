// Задача 2. Задайте значения M и N. Напишите программу, 
// которая найдет сумму натуральных элементов в промежутке от M до N

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

int NaturalNumbers(int number1, int number2)
{
    int sum = number1;
    if (number1 < number2)
    {
        sum = sum + NaturalNumbers(number1 + 1, number2);
    }
    else if (number1 > number2)
    {
        sum = sum + NaturalNumbers(number1 - 1, number2);
    }
    return sum;
}
int n = Prompt("Введите число N -> ");
int m = Prompt("Введите число M -> ");
System.Console.WriteLine(NaturalNumbers(n, m));

