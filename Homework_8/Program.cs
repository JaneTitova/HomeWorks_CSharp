// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];
    for(int i=0; i < n; i++)
    {
        for(int j=0; j < m; j++)
        {
            array[i,j] = new Random().Next(2, 10);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

/*int[,] PutInOrderElementsOfRow(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            int minJ=j;
            int temp;
            for(int k=j+1; k < array.GetLength(1); k++)
            {
                if(array[i, k] < array[i, minJ])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, minJ];
                    array[i, minJ] = temp;
                }
            }
        } 
    }
    return array;
}

int rows = new Random().Next(2, 8);
int columns = new Random().Next(2, 8);
int[,] myArray = CreateArray(rows, columns);
ShowArray(myArray);
Console.WriteLine();
ShowArray(PutInOrderElementsOfRow(myArray));
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumOfElementsInRow(int[,] array)
{
    int sum = 0, iOfMinSum = 0, minSum = 0;
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            sum+=array[i, j];
        }
        
        if(i==0) 
        {
            minSum=sum;
            //Console.WriteLine(i + " " + sum + " " + minSum);
        }
        else
        {
            //Console.WriteLine(i + " " + sum + " " + minSum);
            if(sum < minSum) 
            {
                minSum = sum;
                iOfMinSum = i;
                //Console.WriteLine(i + " " + sum + " " + minSum);
            }
        }
    }
    Console.WriteLine("В " + iOfMinSum + " строке минимальная сумма");
}

int rows = new Random().Next(2, 8);
int columns = new Random().Next(2, 8);
int[,] myArray = CreateArray(rows, columns);
ShowArray(myArray);
Console.WriteLine();
MinSumOfElementsInRow(myArray);

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7