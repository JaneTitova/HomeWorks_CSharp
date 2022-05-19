// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int[] CreateArrayByPerson(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write("Введите "+ (i+1) + " элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("-> [" + array[0]);
    for(int i=1; i<array.Length; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int CountOfPositive(int[] array)
{
    int count=0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i]>0) count+=1;
    }
    return count;
}

Console.Write("Введите количество элементов в массиве: ");
int mySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[mySize];
if(mySize>0) myArray=CreateArrayByPerson(mySize);
else Console.Write("Число должно быть больше нуля.");

PrintArray(myArray);
Console.Write(CountOfPositive(myArray) + " - количество элементов больше нуля.");
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
string ConvertNums(int n, int del)
{
    string number_2 = "";
    while(n>=del) 
    {
        number_2 = Convert.ToString(n%del) + number_2;
        n/=del;
    }
    number_2 = Convert.ToString(n) + number_2;
    return number_2;
}

Console.Write("Введите число, которое из десятичного программа преобразует в двоичное: ");
int number_10 = Convert.ToInt32(Console.ReadLine());
string MyNum_2 = ConvertNums(number_10, 2);
Console.Write(number_10 + " -> " + MyNum_2);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void Solver(double a1, double b1,
            double a2, double b2)
{
    double x = (b2-b1)/(a1-a2);
    double y = x*a1 + b1;

    Console.Write("(" + x + "; " + y + ")");
}

Console.WriteLine("Введите переменные, чтобы найти точку пресечения двух прямых y = a * x + b, y = c * x + d");
Console.Write("a=");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b=");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c=");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("d=");
double d = Convert.ToDouble(Console.ReadLine());

Solver(a, b, c, d);