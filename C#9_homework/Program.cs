Console.Clear();

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Recurce (int num, int n)
{
    if (n == num) 
        {
            Console.Write("Вы ввели: ");
        }
    
    else 
        Recurce (num, n + 1);
        Console.Write($"{n} ");

}
// Я не понимаю, как обойтись в данном случае без второй переменной n = 0. 
Console.WriteLine("Task 64");

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int nnn = 1;
Recurce(num, nnn);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void RecurceSumm (int min, int max, int summ)
{
    summ = summ + min;
    if (min == max) 
        {
            Console.Write($"Сумма элементов равна: {summ}");

        }
    
    else 
        RecurceSumm (min + 1, max, summ);
}
Console.WriteLine();
Console.WriteLine("Task 66");

Console.WriteLine("Введите min и max");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
int summ = 0;
RecurceSumm(min,max,summ);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Попробовал решить, но плохо получается... 
int Akker (int m, int n)
{
    if (m == 0) 
        return n + 1;
    else if (n == 0)
        return Akker (m - 1, n);
    else
        return Akker (m-1, Akker(m, n-1));
}
Console.WriteLine();
Console.WriteLine("Task 68");

Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Akker(m, n)}");