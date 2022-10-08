Console.Clear();
Console.WriteLine("Поехали");

// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.WriteLine("Task 46");

Console.Write("Enter a integer: ");

int [,] Zapolnenie(int m, int n)
{
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    int [,] array1 = new int [m, n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array1 [i,j] = new Random().Next(0, 10);
        }
    }
    return array1;
}
void Vivod(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] mass1 = Zapolnenie(4,3);
Vivod(mass1);

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.WriteLine();
// Console.WriteLine("Задача №48");
// int [,] Zapolnenie1(int m, int n)
// {
//     Console.WriteLine("Введите элементы массива");
//     m = Convert.ToInt32(Console.ReadLine());
//     n = Convert.ToInt32(Console.ReadLine());
//     int [,] array1 = new int [m, n]; 
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array1 [i,j] = i+j;
//         }
//     }
//     return array1;
// }


// int [,] mass2 = Zapolnenie1(4,3);
// Vivod(mass2);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

/* int [,] Kvadrat (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2 == 0 & j%2 == 0) 
            {
                array[i,j] = array [i,j]*array[i,j];
            }
        }
        Console.WriteLine();
    }
    return array;
}

Kvadrat(mass1);
Vivod(mass1); */
Console.Write("Task 51");
// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int Diagonal (int [,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) 
            {
                summ = summ + array[i,j];
            }
        }
        Console.WriteLine();
    }
    return summ;
}

Console.WriteLine($"Сумма диагональных элементов: {Diagonal(mass1)}");