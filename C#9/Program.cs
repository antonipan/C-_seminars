Console.Clear();

// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



void Recurce (int num)
{
    if (num == 0) Console.Write("Вы ввели: ");

   
    else 
        Recurce (num-1);
        Console.Write($"{num} ");
    
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Recurce(num);

/* int Fact (int num)
{
    if (num == 1) return 1;
    return num*Fact(num - 1);
}

int x = Fact(5); */


// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"




/* 
void SumNumbers(int n, int i)
{
    if (i <= n)
    {
        Console.Write($"{i} ");
        i++;
        SumNumbers(n, i);
    }
}

SumNumbers(5, 1);
в чате вариант
От Константин А. всем 09:45 PM
System.Console.Write($"Введите число: ");
int a = Convert.ToInt16(Console.ReadLine());

int summ = 0;

int Recurse(int a)
{
    if (a > 0) 
    {   
        summ = summ + a % 10;
        Recurse(a / 10);
        return summ;
    }

    return 0;
}

System.Console.Write($"A = {a} - > ");

System.Console.Write($"{Recurse(a)}");
System.Console.Write($"Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());

System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

int count = m;

void Recurse(int m, int n)
{
    if (m < n) {
        System.Console.Write($"{count++}, "); 
        Recurse(m, n - 1);
    } else if (m == n) {
        System.Console.Write($"{count++}"); 
    } 
}

System.Console.Write($"M = {m}, N = {n} - > ");

Recurse(m, n);
System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());
int count = 1;

void Recurse(int n)
{
    if (n > 1) {
        System.Console.Write($"{count++}, "); 
        Recurse(n - 1);
    } else if (n == 1) {
        System.Console.Write($"{count++}");         
    }
}

System.Console.Write($"N = {n} - > ");

Recurse(n);
От Константин А. всем 09:45 PM
System.Console.Write($"{Recurse(a, b)}");
 
 
 Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29

 */

