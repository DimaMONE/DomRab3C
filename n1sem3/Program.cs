// Проверить, является ли пятизначное число палиндромом
try
{
    Console.WriteLine("Введите пятизначное число");
    int x = Convert.ToInt32(Console.ReadLine());
    int x1 = x % 10; // пятая цифра
    int x2 = (x % 100) / 10; // четвертая цифра
    int x3 = (x % 1000) / 100; // третья цифра
    int x4 = (x % 10000) / 1000; // вторая цифра
    int x5 = x / 10000; // первая цифра
    Checknumb(x1, x2, x3, x4, x5);
    void Checknumb(int x1, int x2, int x3, int x4, int x5)
    {
        if
            (x1 == x5 && x2 == x4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
}
catch
{
    Console.WriteLine("Введите именно пятизначное число");
}
{
    Console.WriteLine();
}
