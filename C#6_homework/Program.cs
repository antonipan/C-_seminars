// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Task 41");
Console.Write("Сколько чисел вы собираетесь ввести?  ");
int input = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < input; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 > 0) count++; 
    }
Console.WriteLine("Количество положительных чисел: " + count+".");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Task 43");
Console.Write("enter a variable b1 and k1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("enter a variable b2 and k2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

double x = ((b1 - b2)/(k1 - k2))*(-1);
double y = x*k2 + b2;

Console.Write($"lines will intersect at {x} и {y}");