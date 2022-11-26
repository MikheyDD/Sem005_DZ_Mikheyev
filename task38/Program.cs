// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

var array = FillArray(10);
Print(array);
Console.WriteLine();
Console.WriteLine($"max = {GetMax(array)}");
Console.WriteLine($"min = {GetMin(array)}");
Console.WriteLine(GetDiff(array));

double GetMax(double[] arr)
{
    int item = 0;
    double max = arr[item];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
double GetMin(double[] arr)
{
    int item = 0;
    double min = arr[item];
    for (int i = 0; i < arr.Length; i++)
    {
        
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double GetDiff(double[] arr)
{
    double dif = 0;
    dif = GetMax(arr) - GetMin(arr);
    return dif;
}

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
    return array;
}

void Print(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}