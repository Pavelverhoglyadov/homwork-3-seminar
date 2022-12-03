//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10000 && num <= 99999)
{
    if (num / 10000 == num % 10 && (num % 10000) / 1000 == (num % 100) / 10)
    {
        Console.WriteLine($"{num} - да");
    }
    else
    {
        Console.WriteLine($"{num} - нет");
    }
}
else
{
    Console.WriteLine($"{num}  не пятизначное число");
}
