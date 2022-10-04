Console.Clear();

// int [,] xx = {{1, 3, 4, 4}, {4, 4, 6, 7}, {3, 4, 8, 0}};


// for (int i = 0; i < xx.GetLength(1); i++)
// {
//     for (int j = 0; j < xx.GetLength(0); j++)
//     {
//         Console.Write($"{xx[j, i]} ");
//     }
//     Console.WriteLine();

// }


// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.WriteLine("Задача №31");
int [] FillArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray (int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] mass1 = FillArray(11, -10, 10);
PrintArray(mass1);
Console.WriteLine();
int [] Revers(int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size/2; i++)
    {
        int intermediate = array[i];
        array[i] = array[(size - 1) - i];
        array[(size - 1) - i] = intermediate;
    }
    return array;
}
Revers(mass1);
PrintArray(mass1);


// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// <aside>
// **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.
// </aside>

/* Console.WriteLine("Задача №40");
bool Triangle ()
{
    int [] array = new int [3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    if (array[0] > array[1] + array[2]) 
    {
        return false;
    }
    else if (array[1] > array[0] + array[2]) 
    {
        return false;
    }
    else if (array[2] > array[1] + array[0])
    {
        return false;
    }
    else return true;
}
Console.Write(Triangle()); */
// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/* Console.WriteLine("Задача №42");
Console.Write("Введите число: ");
void dvoichnoe(int a)
{
    a = Convert.ToInt32(Console.ReadLine()); 
    int count = 0; 
    int b = a;
    while (b!= 0)
    {
        b = b/2;
        count++;
    }
    int ost;
    int [] doublarray = new int [count];
    Console.WriteLine();
    for (int i = count-1; i>=0; i--)
    {
        ost = a%2;
        doublarray [i] = ost;
        a=a/2;
    }
    for(int i = 0; i < count; i++)
    {
        Console.Write(doublarray[i]);
    }
}
int des = 0;
dvoichnoe(des);
 */

/* // **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Задача №42");
Console.Write("Введите число: ");
void Fibonacci(int count)
{
    count = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [count];
    array[0] = 0;
    array[1] = 1;
    Console.Write($"{array[0]} {array[1]} ");
    for (int i = 2; i < count; i++)
    {
       array[i] = array[i - 1] + array[i - 2];
       Console.Write($"{array[i]} ");
    }
}
int i = 0;
Fibonacci(i); */
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
