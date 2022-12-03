// Проверить, является ли пятизначное число палиндромом?
Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x % 10; // пятая цифра
int x2 = (x % 100 ) / 10; // четвертая цифра
int x3 = (x % 1000 ) / 100; // третья цифра
int x4 = (x % 10000 ) / 1000; // вторая цифра
int x5 = x / 10000; // первая цифра
int[] num = {x5, x4, x3, x2, x1};
if 
    (num[0] == num[^1] && num[1] == num[^2])
    {
        Console.WriteLine("Число является палиндромом");

    }
else
{
   Console.WriteLine("Число не является палиндромом");
}
{
Console.WriteLine();
}