Console.Clear();

Console.WriteLine("Task47");
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] FillandPrintDoubleArray()
{
    Console.WriteLine("set the size of the array of two numbers");
    Console.Write("rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("columns: ");
    int column = Convert.ToInt32(Console.ReadLine());

    double [,] array = new double [row,column];
    for (int i = 0; i<row; i++)
    {
        for(int j = 0; j<column; j++)
        {
            array[i,j] = Math.Round (new Random().NextDouble()*10, 2);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

double [,] mass1 = FillandPrintDoubleArray();


Console.WriteLine("Task50");
// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

double CheckNumber(double [,] array)
{
    Console.WriteLine("What number should I check?");
    double number = Convert.ToDouble(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number) 
            {
                count++;
                Console.WriteLine($"Number {number} is in the array"); break;
            }

        }
    }
    if (count == 0) Console.WriteLine($"{number} is not");
    return number;
}

CheckNumber(mass1);

Console.WriteLine("Task52");

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int [,] Fillarray()
{
    Console.WriteLine("set the size of the array of two numbers");
    Console.Write("rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("columns: ");
    int column = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [row,column];
    for (int i = 0; i<row; i++)
    {
        for(int j = 0; j<column; j++)
        {
            array[i,j] = new Random().Next(0, 10);
            
        }
    }
    return array;
}
void Printarray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [] MidlSummColumn (int [,] array)
{
    double [] summarray = new double [array.GetLength(1)];
    double summ = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        for(int j = 0; j<array.GetLength(0); j++)
        {
            summ = summ + array [j,i]; 
        }
        summarray [i] = summ/array.GetLength(0);
        summarray [i] = Math.Round(summarray[i], 1);
        Console.Write($"{summarray [i]} ");
        summ = 0;
    }
    return summarray;
}
int [,] mass2 = Fillarray();
Printarray(mass2);
Console.WriteLine($"Среднеарифметическое по столбцам: ");
MidlSummColumn(mass2);
