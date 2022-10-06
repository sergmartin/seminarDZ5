// Задача № 34
Console.Clear();
int co = 0;
int[] mass = new int[10];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
int Chet(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) co++;
    }
    return co;
}



Console.WriteLine("[" + string.Join(",", mass) + "]");
Console.Write($"Количество четных чисел в массиве = {Chet(mass)}.");