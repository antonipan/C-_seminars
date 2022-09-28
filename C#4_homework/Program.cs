// Task 26
Console.WriteLine ("Task 26");
// Вариант 1
// Console.WriteLine ("enter the integer");
// string user = Convert.ToString(Console.ReadLine());
// int length = user.Length;
// Console.Write(length); 

// Вариант 2.
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
Console.WriteLine (sum);