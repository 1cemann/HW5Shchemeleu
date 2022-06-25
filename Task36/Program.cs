//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

Write("Введите длину массива   ");
int size=int.Parse(ReadLine());
Write("Введите Мах значение в массиве   ");
int Max=int.Parse(ReadLine());
Write("Введите Мин значение в  массиве   ");
int Min=int.Parse(ReadLine());
int[] array= new int[size];
array=GetRandomArray(size,Min,Max);
WriteLine($"[{String.Join("," ,array)}]");
WriteLine($"Сумма элементов, стоящих в массиве, на нечетных позициях(нумерация начинается с нулевого индекса): {0} = {string.Join(",",SumElemnts(array))}");




int[] GetRandomArray(int size,int MinValue,int MaxValue)
{
    int[] result=new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(MinValue,MaxValue+1);
    }
    return result;
}



int SumElemnts(int[] Sumarry)
{
    int sum1=0;
    int sum2=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        sum1 = sum1 + Sumarry[i];
        else
        sum2 = sum2 + Sumarry[i];
    }
    return sum2;
}