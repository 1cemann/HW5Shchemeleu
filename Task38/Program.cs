//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

double[] array = GetRandomArray(5, 1, 100);
WriteLine($"[{String.Join(",", array)}]");


double[] GetRandomArray(int size, int MinValue, int MaxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}


double maxNumber = array[0];
double minNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
        maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}
double NegativeSum = maxNumber - minNumber;
WriteLine($"Разница между максимальным и минмальным элементом массива: {NegativeSum}");
