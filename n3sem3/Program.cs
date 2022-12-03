// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
try
{
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
for(i = 0; i <= N; i++) 
System.Console.Write($"{i*i*i} ");
}
catch
{
    System.Console.WriteLine("Введите корректное число");
}
System.Console.WriteLine();


