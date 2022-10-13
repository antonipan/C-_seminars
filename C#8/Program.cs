Console.Clear();
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int [,] FillArray ()
{
    Console.Write("Введите число строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число стоблцов: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int [row, column]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] mass1 = FillArray();
PrintArray(mass1);
int [,] ReplaceLines(int [,] array)
{
    int replace;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) 
            {
                replace = array [i,j];
                array [i,j] = array [array.GetLength(0)-1, j];
                array [array.GetLength(0)-1, j] = replace;
            }
        }
    }
    return array;
}
Console.WriteLine();
ReplaceLines(mass1);
PrintArray(mass1);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.WriteLine("Задача 55");

int [,] ReplaceRowColumn (int [,] array)
{
    int row = array.GetLength(1);
    int column = array.GetLength(0);
    int [,] array2 = new int [row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array2 [j,i] = array[i,j];
        }
    }
    return array2;
}

int [,] mass2 = ReplaceRowColumn(mass1);
PrintArray(mass2);
// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
Console.WriteLine("Задача 57");

void Frequency (int [,] array)
{
    for (int m = 0; m < 10; m++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {                    
                if (array[i,j] == m) count++;
                
                
            }
        }
        Console.WriteLine ($"число {m} = {count} раз");
        
    }    

}
Frequency(mass2);
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7



// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
