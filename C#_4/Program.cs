Console.Clear();
// string s1 = "geek";
// string s2 = "brains";
// string s3 = "C#";

// string s = s1 + s2 + " : " + s3;

// string s5 = string.Concat(s1, s2, s3);
// Console.WriteLine(s);
// Console.WriteLine(s5);

// Console.WriteLine(s2[1]);
// Console.WriteLine(s5[4]);
// Console.WriteLine(s1[1] + s2[1]);

/* // Task 26. 
Console.WriteLine("Enter the integer");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = num1;
for (int i = 0; i < num1; i++)
{
    count = count + i;
     
}
Console.WriteLine(count);
 */

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
Console.WriteLine (count);
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