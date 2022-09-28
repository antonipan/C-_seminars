

/* // Задача №1. Работа с массивами

Console.Clear(); 

Console.WriteLine(""); 

// int [] numbers = new int [5]; 
int [] numbers = new int [5] {1, 3, 5, 4, 5}; 
// int [] numbers = new int [] {1, 3, 5, 4, 5}; 
// int [] numbers = new [] {1, 3, 5, 4, 5}; 
// int [] numbers = {1, 3, 5, 4, 5}; 
string [] name = {"ann", "bob", "robert", "roberto"};

// Console.WriteLine ($"{name[3]} !!!"); 
numbers[3] = numbers[3] + 10;
Console.WriteLine ($"{numbers[3]} !!!"); 

for (int i = 0; i < 5; i++)
    Console.WriteLine ($"{i} - элемент - это {numbers[i]} !!!");  */

// Задача №2. Работа с методами Math

/* Console.Clear(); 


// int [] numbers = new int [5]; 
int [] numbers = new int [5] {1, 3, 5, 4, 5}; 
// int [] numbers = new int [] {1, 3, 5, 4, 5}; 
// int [] numbers = new [] {1, 3, 5, 4, 5}; 
// int [] numbers = {1, 3, 5, 4, 5}; 
string [] name = {"ann", "bob", "robert", "roberto"};

// Console.WriteLine ($"{name[3]} !!!"); 
numbers[3] = numbers[3] + 10;
Console.WriteLine ($"{Math.Pow(numbers[2], 3)} !!!"); 

double result = Math.Round (17.137, 1); 
Console.WriteLine(result);

Console.WriteLine(Math.Sqrt(16)); */

// for (int i = 0; i < 5; i++)
//     Console.WriteLine ($"{i} - элемент - это {numbers[i]} !!!"); 


// 17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//  выдаёт номер четверти плоскости, 
//  в которой находится эта точка.


// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear(); 
Console.WriteLine("Введите координаты x точки А");
int a1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты y точки А");
int a2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты x точки B");
int b1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты y точки B");
int b2 = Convert.ToInt32(Console.ReadLine()); 



double ab = Math.Sqrt(Math.Pow((b1 - a1), 2) + Math.Pow((b2 - a2), 2)); 
double result = Math.Round(ab, 3);
Console.Write ($" Расстояние между точками А и В = {result}"); 

int [] array = new int [3];

/* // Задача 22: Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int count = 1; count <= num; count++) 
{
    double sqr = Math.Pow(count,2);
    Console.WriteLine(sqr);
} */

