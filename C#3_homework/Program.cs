Console.Clear();
Console.WriteLine("Это домашняя работа к семинару №3");
Console.WriteLine("Задача №19");
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите 5-значное число");
int numstart = Convert.ToInt32(Console.ReadLine());
 
while ((numstart < 9999) | (numstart > 99999)) 
{
        Console.WriteLine("Число не пятизначное");
        Console.WriteLine("Введите 5-значное число");
        numstart = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Хорошо");

int num5 = numstart%10;
int num1 = numstart/10000;
int num4 = (numstart%100)/10;
int num2 = (numstart/1000)%10;
if  ((num1 == num5)
    & (num2 ==num4)) 
    {
        Console.WriteLine($"Да, число {numstart} палиндром");
    } else
    {
        Console.WriteLine($"нет, число {numstart} - не палиндром");
    }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача №21");
int [] a = new int [3];
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите {i+1}-ю координату точки А: ");
    a [i] = Convert.ToInt32(Console.ReadLine());
}
int [] b = new int [3];
for (int i = 0; i < b.Length; i++)
{
    Console.Write($"Введите {i+1}-ю координату точки B: ");
    b [i] = Convert.ToInt32(Console.ReadLine());
}

double distans = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) 
+ Math.Pow((b[1] - a[1]), 2) 
+ Math.Pow((b[2] - a[2]), 2));
distans = Math.Round(distans, 2);
Console.WriteLine(distans);


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Задача №23");
Console.WriteLine("Введите любое положительное число число");
int numberN = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= numberN; i++)
{
    int cub = i*i*i;
    Console.WriteLine(cub);
}