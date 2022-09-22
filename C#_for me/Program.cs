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

