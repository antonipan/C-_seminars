Console.Clear();

Console.WriteLine("Задача №34");

int [] mass_1 = new int [10];
int count_1 = 0;
for (int i = 0; i < 10; i++)
{   
    mass_1 [i] = new Random().Next(100, 1000);
    
    if (mass_1[i]%2 ==0) count_1++;
    Console.Write($"{mass_1[i]}, ");
    
}
Console.WriteLine();

Console.WriteLine($"Количество чётных чисел: {count_1}");


Console.WriteLine("Задача №36");

int [] mass_2 = new int [10];
int summ_1 = 0;
Console.WriteLine("Элементы массива на нечётных позициях:");
for (int i = 0; i < 10; i++)
{   
    mass_2 [i] = new Random().Next(0, 9);
    if (i%2 == 1) 
    {
        summ_1 = summ_1 + mass_2[i];
        Console.Write($"{mass_2[i]} ");
    }
}
Console.WriteLine();
Console.WriteLine("Все элементы массива:");

for (int i = 0; i < 10; i++)
{
    Console.Write($"{mass_2[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Сумма элем.на нечётн.позиции: {summ_1}");  


Console.WriteLine("Task #38");
int [] a = new int [10];
Console.WriteLine("Элементы массива: ");
for (int i = 0; i<10; i++)
{
    a [i] = new Random ().Next(1, 30);
    Console.Write ($"{a[i]}  ");
}
int max = a [0];
int min = a [0];
for (int i = 0; i<10; i++)
{
    if (a[i] > max) max = a[i];
    if (a[i] < min) min = a[i];
}
Console.WriteLine();
Console.Write($"Разница между {max} и {min}: = {max - min}");



// создает рандомный массив double
double[] RandomArrayDouble(int elements, double min, double max, int accuracy){
    double[] array = new double[elements];
    for(int i = 0; i < elements; i++){
        array[i] = new Random().NextDouble() * (max - min) + min;
        array[i] = Math.Round(array[i], accuracy);
    }
    
    return array;
} // Выводит массив Double в String
string ArrayDoubleToString(double[] arr){
    string result = "[";

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}; ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    result = result + "]";

    return result;
}

double[] array = RandomArrayDouble(10, 10.00, 99.00, 2);

// минимум максимум
double min1 = array.Min();
double max1 = array.Max();

// результат
System.Console.WriteLine($"{ArrayDoubleToString(array)} -> {max - min}");
