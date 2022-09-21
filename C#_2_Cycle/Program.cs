

// адача №1. 



Console.Clear();
Console.WriteLine("Задача №1");
int num = new Random().Next(10, 100);
Console.WriteLine(num);
int char1 = num / 10;
int char2 = num % 10;
if (char1 > char2)
{
    Console.WriteLine("Наибольшая цифра: " + char1);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + char2);
}

// Задача №2. 

Console.WriteLine("Задача №2");
int a = new Random().Next(100,1000);
Console.WriteLine(a);

int num3 = a%10;
int num1 = a/100;


Console.WriteLine(num1*10+num3);

// Задача №3

Console.WriteLine("Задача №3");
Console.Write("Введите первое число: ");
int mit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int mit1 = Convert.ToInt32(Console.ReadLine());
int mod = mit % mit1;
if (mod == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток " + mod);
}

// Задача №4
Console.WriteLine("Задача №4");
Console.WriteLine("Введите любое число");

int x = Convert.ToInt32(Console.ReadLine());
int y = x%(7*23);
if (y == 0)
{
    Console.WriteLine($"Да, число {x} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Нет, число {x} не делится на 7 и 23");

}

// Задача №5
Console.WriteLine("Задача №5");
Console.Write("Введите первое число: ");
int bar1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int bar2 = Convert.ToInt32(Console.ReadLine());
if ((bar1 * bar1 == bar2) || (bar2 * bar2 == bar1))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


// Задача №6
Console.WriteLine("Задача №6");
Console.WriteLine("Введите ваш возраст");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 0)
{
    Console.WriteLine("Такого возраста не существует");
}
else if (age < 14)
{
    Console.WriteLine("Детство");
}
else if (age < 25)
{
    Console.WriteLine("Молодость");
}
else if (age < 60)
{
    Console.WriteLine("Зрелость");
}
else
{
    Console.WriteLine("Старость");
}

// Задача 7.
Console.WriteLine("Задача №7");
int[] mix = new int[3];
for (int i = 0; i < mix.Length; i++)
{
    Console.Write($"Введите {i+1}-е число: ");
    mix[i] = Convert.ToInt32(Console.ReadLine());
}
int posSum = 0;
for (int i = 0; i < mix.Length; i++)
{
    if (mix[i] > 0) posSum += mix[i];
}
Console.Write("Сумма положительных: " + posSum);
