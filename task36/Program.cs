// Задача № 36
Console.Clear();
int summ = 0;
int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < mass.Length; i++)
{
    if (i % 2 != 0)
    {
        summ+=mass[i];
    }
}

Console.WriteLine("[" + string.Join(",", mass) + "]");
Console.Write($"Сумма чисел на нечетных позициях массива равна: {summ}");