//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"сумма натуральных элементов в промежутке от {m} до {n} = {Sum(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}