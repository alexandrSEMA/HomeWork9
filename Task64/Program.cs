//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
int n = FillNumber("Введите положительное число: ");
int m = 1;
Console.WriteLine(NaturalNumber(n, m));
int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}
int FillNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}