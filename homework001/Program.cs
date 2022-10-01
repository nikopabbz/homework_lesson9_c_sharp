// Задача 1. Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
int Prompt(string msg)
{
    System.Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if(count)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

void NaturalNumbers(int number)
{
    if(number > 0)
    {
        System.Console.Write(number + " ");
        NaturalNumbers(number-1);
    }
}
int n = Prompt("Введите число N -> ");
NaturalNumbers(n);

