// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
bool Palindrome(int n)
{
    bool respond = false;
    if(n/10000 == n%10 && (n/1000)%10 == (n%100)/10) respond = true;
    return respond;
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 9999 && num < 100000)
{
    bool resp = Palindrome(num);
    if(resp) Console.Write(num + " -> да");
    else Console.Write(num + " -> нет");
}
else Console.Write(num + " -> не пятизначное число!");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
void Distance(double xa, double ya, double za,
              double xb, double yb, double zb)
{
    double d = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
    Console.Write("A(" + xa + "," + ya + "," + za + "); B("+ xb + "," + yb + "," + zb + ") -> " + d);
}

Console.Write("Введите x координату точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x координату точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

Distance(xA, yA, zA, xB, yB, zB);
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int n)
{
    int count = 2;
    Console.Write(n + " -> 1");
    while(count < n+1)
    {
        Console.Write(", " + count*count*count);
        count++;
    }
}

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0) Cube(num);
else Console.Write(num + " -> 0 или отрицательное!");