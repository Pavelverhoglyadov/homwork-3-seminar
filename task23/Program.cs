
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int SumNumbers(int N)
{
    int mul = 1;
    for (int i = 1; i <= N; i++)
        mul = i*i*i;
    return mul;
}
        
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" таблица кубов от 1 до {N} равно {SumNumbers(N)}");