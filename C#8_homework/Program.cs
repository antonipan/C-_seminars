Console.Clear();

Console.WriteLine("Задача 54");
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

int [,] FillArray()
{
    Console.WriteLine("Введите размер массива");
    Console.Write("Строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбцы: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(0,5);
        }
    }
    return array;
}

void Printarray(int [,]array)
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

int [,] mass1 = FillArray();
Printarray(mass1);

int [,] Minrowarray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int index = 0;
        while(index < array.GetLength(1))
        {    
            int max = array [i, index];
            for (int j = index+1; j < array.GetLength(1); j++)
            {
                if (array [i,j] > max)
                {
                    max = array[i,j];
                    array[i,j] = array[i, index];
                    array[i, index] = max;
                }
            }
            index++;
        }
    }
    return array;
}

int [,] mass2 = Minrowarray(mass1);
Console.WriteLine();
Printarray(mass2);
// int [] array = {4, 5, 3, 8, 6};
// int index = 0;
// while(index < array.Length)
// {    
//     int max = array[index];
//     for (int i = index+1; i < array.Length; i++)
//     {
//         if (array[i] > max) 
//         {
//             max = array[i];
//             array[i] = array[index];
//             array[index] = max;
//         }
//     }
//     index++;
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
    
Console.WriteLine("Задача 56");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int Rowminsumm (int [,] array)
{
    int [] array2 = new int [array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array [i,j];
        }
        array2[i] = summ;
        Console.Write($"{array2[i]} ");
    }
    int min = array2[0];
    int index = 1;
    for (int m = 0; m < array2.Length; m++ )
    {
        if (array2[m] < min) 
        {
            min = array2[m];
            index = m+1;
        }
    }
    return index;
}

Console.WriteLine();
int index = Rowminsumm(mass1);
Console.WriteLine();
if (index == 3)
{
    Console.WriteLine($"В {index}-ей строке минимальная сумма");
} else
{
    Console.WriteLine($"В {index}-ой строке минимальная сумма");

}

Console.WriteLine("Задача 58");
Console.WriteLine("Матрица А");
int [,] mass3 = FillArray();
Printarray(mass3);
Console.WriteLine();
Console.WriteLine("Матрица B");
int [,] mass4 = FillArray();
Printarray(mass4);
Console.WriteLine();

int [,] Umnogeniematrix (int [,] array1, int [,] array2)
{
  
    int row1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int column2 = array2.GetLength(1);
    int [,] array3 = new int [row1, column2];
    if (row1 != column2) 
        {
            Console.WriteLine ("Матрицы нельзя перемножить");
        }  
    else {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int m = 0; m < row2; m++)
                    {
                        {
                        array3 [i,j] += array1 [i, m] * array2 [m,j];
                        }              
                    }
                }
            }
        }
    return array3;
        
}
int [,] mass5 = Umnogeniematrix(mass3, mass4);
Console.WriteLine ("Итоговая матрица C = A*B");
Printarray(mass5);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Задача 58");

int [,,] FillthreeArray()
{
    int [,,] array = new int [2,2,2];
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                array[x,y,z] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

int [,,] Norepeatarray (int [,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] = new Random().Next(10, 100);
            }
        }
    }
    return array;
} 
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07