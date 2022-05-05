﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfEvenElements(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2 == 0) count+=1;
    }
    return count;
}

int[] MyArray = CreateRandomArray(6, 100, 999);
PrintArray(MyArray);
Console.Write("Сумма четных элементов массива равна - " + SumOfEvenElements(MyArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumElementsOnUnevenPositions(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

int[] MyArray = CreateRandomArray(7, -10, 10);
PrintArray(MyArray);
Console.Write("Сумма элементов стоящих, на нечетных позициях равна " + SumElementsOnUnevenPositions(MyArray));

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
