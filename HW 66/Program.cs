// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int N = int.Parse(Console.ReadLine());

        if (M <= N)
        {
            int sum = CalculateSum(M, N);
            Console.WriteLine($"Сумма натуральных элементов от {M} до {N} = {sum}");
        }
        else
        {
            Console.WriteLine("Значение M должно быть меньше или равно N.");
        }
    }

    static int CalculateSum(int start, int end)
    {
        if (start == end)
        {
            return start;
        }
        else
        {
            return start + CalculateSum(start + 1, end);
        }
    }
}