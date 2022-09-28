Console.Clear();
/* // Task 25
Console.WriteLine("Task 25");
int a = 1;
while (a != 0)
{
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 0) break;
    Console.Write($"В какую степень нужно возвести число {a}? ");
    int b = Convert.ToInt32(Console.ReadLine());
    double c = Math.Pow(a, b);
    Console.WriteLine($"Получилось число {c}");
}
Console.WriteLine($"Спасибо за работу"); */


/* // Task 27
Console.WriteLine ("Task 27");
Console.WriteLine ("enter the integer");
int user = Convert.ToInt32(Console.ReadLine());
// Сначала определяем, из скольки знаков
int del = 10;
int ost = 1;
int count = 0;
while (ost !=0)
{
    count = count+1;
    ost = user/del;
    del = del*10;
}

del = del/10;
int [] user1 = new int [count];
int sum = 0;
for (int i = 0; i < count; i++)
{
    del = del/10;
    user1[i] = (user/del)%10;
    sum = sum + user1[i];
}
Console.WriteLine (sum); */


/* // Task 29. 
Console.WriteLine ("Task 27");
Console.WriteLine ("Сколько чисел вы введёте?");
int length = Convert.ToInt32(Console.ReadLine());
int [] mass1 = new int [length];
for(int i = 0; i < length; i++)
{
    Console.WriteLine ($"Введите {i+1}-е число?");
    mass1[i] = Convert.ToInt32(Console.ReadLine());

}
for(int i = 0; i < length; i++)
{
    if (i == length - 1)
    {
        Console.Write($"{mass1[i]} - элементы массива.");
        break;
    }
    Console.Write($"{mass1[i]}, ");
    
} */