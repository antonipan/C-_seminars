Console.Clear();

/* // Метод 1. Ничего не принмает, не возвращает.
void SayHelloC() //  скобки позволяют отличать метод от переменной
// принято писать метод с большой буквы и называть действием 
{
    Console.WriteLine("Привет, Java !");
}
// вызов метода.
SayHelloC();
SayHelloC();
SayHelloC(); */

/* // Метод 2. принмает, но не возвращает.
void SayHellolang(string lang)
{
    Console.WriteLine($"Привет, {lang} !");
    // Внутренняя переменная lang по отношению к методу. 
}
// вызов метода.
SayHellolang("C++");
SayHellolang("C#");
string l = "C#"; // Внешняя переменная по отношению к методу.
//Если в методе объявлен один тип переменной, то вписывать нужно этот тип.
SayHellolang(l); */

/* 
// Метод 3. принмает, возвращает.
int SayMax(int x1, int x2)
{
    if (x1 > x2) return x1; // как только программа заходит на return, она покидает метод.
    // Console.WriteLine($"Max = {x1}.");
    else return x2;
    // Console.WriteLine($"Max = {x2}.");
}
Console.WriteLine($"Max = {SayMax(4, 1)}.");

int max1 = SayMax(3, 15);
Console.WriteLine(max1);

int l1 = 5;
int l2 = 4;
int max2 = SayMax(l1, l2);

Console.WriteLine($"Max = {max2}."); */


// Задача №31.
// Задайте массив из 12 элементов, заполненный случайными числами. 
// Найдите сумму отрицательных и положительных элементов массива
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

int SummPozit (int []array)
{
    int size = array.Length;
    int summPozit = 0;
    for (int i = 0; i < size; i++)
    {
        
        if (array[i] > 0) summPozit = summPozit + array[i];
    }
    return summPozit;
}
int SummNegat (int []array)
{
    int size = array.Length;
    int summNegat = 0;
    for (int i = 0; i < size; i++)
    {
        
        if (array[i] < 0) summNegat = summNegat + array [i];
    }
    return summNegat;
}


int [] mass1 = FillArray(10, -9, 9);
PrintArray(mass1); 
Console.WriteLine();
Console.WriteLine("This summa of pozitive: " + SummPozit(mass1));
Console.WriteLine("This summa of negative: " + SummNegat(mass1));


// Задача №32. 
// Замените отрицательные элементы массива на положительные и наоборот. 
void ReplaceSign(int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array [i] = array [i] * -1;
    }
}

ReplaceSign(mass1);
Console.WriteLine();
PrintArray(mass1); 

// Задача №33.
// Задайте массив. Напишите программу. Присутствует ли данное число в массиве. 
Console.Write("enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
void Availibility(int [] array, int num)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array [i] == num) 
        {
            Console.WriteLine("such a number is");
            break;
        }
        else if (i == size - 1) Console.WriteLine("there is no such number");
    }

}
Availibility(mass1, number);


// Задача №35. 
// Задать массив из 123 элементов. Найти количество элементов в пределах 10 до 99. 

Console.WriteLine();
int [] mass2 = FillArray(123, 0, 123);

int Countelement(int [] array, int minValue, int maxValue)
{
    int count = 0;
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        if (array [i] >= minValue & array [i] <= maxValue) count = count+1;
    }
    return count;
}

Console.WriteLine ("Количество элементов в массиве: " + Countelement(mass2, 10, 99));

// Задача №37. 
// Найти произведение симметричных элементов массива. Записать их в новый массив. 
int [] Newarray(int [] array)
{
    int size = array.Length;
    int [] array2 = new int [size/2];
    int i = 0;
    while (i < size/2)
    {
        
    }
}