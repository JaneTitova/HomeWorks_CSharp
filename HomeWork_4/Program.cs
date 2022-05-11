// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
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

int CountOfEvenElements(int[] array)
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
Console.Write("Количество четных элементов массива равна - " + CountOfEvenElements(MyArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
*/

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double Difference(double a, double b)
{
    return b-a;
}

double FindMax(double[] array)
{
    double max = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i]>max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i]<min) min = array[i];
    }
    return min;
}

double[] MyArray = new double[5]{3,7,22,2,78};

double minimum = FindMin(MyArray);
double maximum = FindMax(MyArray);
Console.Write("Разница между " + maximum + " и " + minimum + " равна " + Difference(minimum, maximum));
*/

//// все методы вместе
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

int CountOfEvenElements(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2 == 0) count+=1;
    }
    return count;
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

int Difference(int a, int b)
{
    return b-a;
}

int FindMax(int[] array)
{
    int max = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i]>max) max = array[i];
    }
    return max;
}

int FindMin(int[] array)
{
    int min = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i]<min) min = array[i];
    }
    return min;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите наименьшее значение элементов массива: ");
int minval = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите наибольшее значение элементов массива: ");
int maxval = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(size, minval, maxval);
PrintArray(MyArray);

int minimum = FindMin(MyArray);
int maximum = FindMax(MyArray);
Console.WriteLine("Разница между " + maximum + " и " + minimum + " равна " + Difference(minimum, maximum));

Console.WriteLine("Сумма элементов стоящих, на нечетных позициях равна " + SumElementsOnUnevenPositions(MyArray));

Console.WriteLine("Количесвто четных элементов массива равна - " + CountOfEvenElements(MyArray));