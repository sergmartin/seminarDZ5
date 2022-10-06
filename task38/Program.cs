// Задача №38
Console.Clear();



double[] mass = new double[10];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-20, 20);
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    
    int i = 0;
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}



Console.WriteLine("[" + string.Join(",", mass) + "]");
Console.WriteLine($"Максимальный элемент массива: {Max(mass)}");
Console.WriteLine($"Минимальный элемент массива: {Min(mass)}");
Console.WriteLine($"Разница между максимальными и минимальными значениями массива: {Max(mass) - Min(mass)}");