// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Результат:");
        PrintNaturalNumbers(n);
    }

    static void PrintNaturalNumbers(int n)
    {
        if (n >= 1)
        {
            Console.Write(n);
            if (n > 1)
            {
                Console.Write(", ");
            }
            PrintNaturalNumbers(n - 1);
        }
    }
}
