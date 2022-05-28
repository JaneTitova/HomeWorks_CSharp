// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
void CreateArray(int n, int m)
{
    double[,] array = new double[n, m];
    for(int i=0; i < n; i++)
    {
        for(int j=0; j < m; j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble()*10, 2);
            //array[i,j] = Math.Round(new Random().NextDouble()*(15-9) + 9, 2); //эксперимент
            //array[i,j] = Convert.ToDouble(new Random().Next(-100,100)/10.0);  //эксперимент
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колонок массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(rows > 0 && columns > 0) CreateArray(rows, columns);
else Console.WriteLine("Вы ввели отрицательные числа или 0.");
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for(int i=0; i < n; i++)
    {
        for(int j=0; j < m; j++)
        {
            array[i,j] = new Random().Next(2, 10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int rows = new Random().Next(2, 8);
int columns = new Random().Next(2, 8);
int[,] myArray = CreateArray(rows, columns);

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки: ");
int y = Convert.ToInt32(Console.ReadLine());


if(x < rows && y < columns && x >= 0 && y >= 0) Console.Write(myArray[x, y]);
else Console.Write("такого элемента нет");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for(int i=0; i < n; i++)
    {
        for(int j=0; j < m; j++)
        {
            array[i,j] = new Random().Next(2, 10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("-> [" + array[0]);
    for(int i=1; i<array.Length; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

void FindAverageOfEveryColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] averageOfCols = new double[columns];

    for(int j=0; j < columns; j++)
    {
        for(int i=0; i < rows; i++)
        {
            averageOfCols[j] += array[i, j];
        }
        averageOfCols[j] /= rows;
    }
    Console.Write("Среднее арифметическое каждого столбца "); 
    PrintArray(averageOfCols);
}

int rows = new Random().Next(2, 8);
int columns = new Random().Next(2, 8);
int[,] myArray = CreateArray(rows, columns);
FindAverageOfEveryColumns(myArray);