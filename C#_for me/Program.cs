/* // Задача с массивами.


int [] massiv = new int [5];
for (int i = 0; i < massiv.Length; i++)
{
    Console.Write($"Vvedite {i+1}-oe chislo: ");
    massiv[i] = Convert.ToInt32(Console.ReadLine()); 
}
int nechet = 0; 
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i]%2 != 0) nechet += massiv[i];
}
Console.Write(nechet); */

/* // Задача №2. Применение метода Мах и массива

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 6;
int b1 = 4;
int c1 = 18;
int a2 = 9;
int b2 = 23;
int c2 = 13;
int a3 = 11;
int b3 = 5;
int c3 = 115;
// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max (
    Max (a3, b3, c3), 
    Max (a2, b2, c2), 
    Max (a1, b1, c1));

Console.WriteLine(max); */

/* // Задача №3. Убираем переменные в массив.

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {6, 4, 18, 9, 43, 13, 11, 5, 19};



int max = Max (
    Max (array[0], array[1], array[2]), 
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8]));

Console.WriteLine(max); 

int result = Max (array[3], array[6], array[2]);
Console.WriteLine(result);  */

// Задача №4. 

Console.Clear();
/* Console.WriteLine("Задача: процент символа в строке");

string sign = "Наш моисей сейчас замёрзнет на улице. А Ева тоже хочет гулять.";
int size = sign.Length;
int sizeLetter = 0;
int count = 0;
for(int i = 0; i<size; i++)
{
    if ((sign[i] != ' ') & 
        (sign[i] != '.') &
        (sign[i] != ',')) sizeLetter++;
    if ((sign[i] == 'о') | (sign[i] == 'е')) count++;
}
double procent = (count*100)/sizeLetter;
procent = Math.Round(procent, 2);
Console.WriteLine($"Общее количество символов: {size}.");
Console.WriteLine($"Общее количество букв: {sizeLetter}.");
Console.WriteLine($"Количество найденных символов: {count}.");
Console.WriteLine($"Процент символа в тексте: {procent}."); */

/* Console.Clear();
Console.WriteLine("Задача: количество чисел в массиве");

int [] mass_1 = new int [100];
int [] mass_2 = new int [100];
int count_1 = 0;
int count_2 = 0;
int sovp = 0;
for (int i = 0; i < 100; i++)
{   
    mass_1 [i] = new Random().Next(1, 51);
    if (mass_1[i]  == 8) count_1++;
    mass_2 [i] = new Random().Next(1, 51);
    if (mass_2[i] == 8) count_2++;
    if (mass_1[i] == mass_2[i]) sovp++;
    
}
Console.WriteLine($"Счёт №1: {count_1}");
Console.WriteLine($"Счёт №2: {count_2}");
Console.WriteLine($"Количество совпадений: {sovp}");
 */

