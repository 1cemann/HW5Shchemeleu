//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(10,99,999);
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Количество чётных чисел в массиве = {string.Join(",",ParityCheck(array))}");



int[] GetRandomArray(int size,int MinValue,int MaxValue){
    int[] result=new int[size];
    for(int i=0;i<size;i++){
        result[i]=new Random().Next(MinValue,MaxValue);
    }
    return result;
}

int ParityCheck(int[] array)
{
    int numbers=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            numbers++;   
        }
    }
    return numbers;
}

