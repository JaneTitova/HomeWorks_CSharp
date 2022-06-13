// Задача 1: Задайте массив строк. Напишите программу, 
//считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

void CountStringWithVowel(string[] words)
{
    int count = 0;
    for(int i=0; i < words.Length; i++)
    {
        if(words[i][0] == 'a') count++;
        if(words[i][0] == 'e') count++;
        if(words[i][0] == 'o') count++;
        if(words[i][0] == 'u') count++;
        if(words[i][0] == 'i') count++;
        if(words[i][0] == 'y') count++;
    }
    Console.WriteLine("1-ый способ: " + count);
}

void CountStringWithVowel2(string[] words)
{
    int count = 0;
    string allVowel = "a e o i u y";
    for(int i=0; i < words.Length; i++)
    {
        if(allVowel.Contains(words[i][0])) count++;
    }
    Console.WriteLine("2-ой способ: " + count);
}

void CountStringWithVowel3(string[] words)
{
    int count = 0;
    string allVowel = "a e o i u y";
    foreach(string w in words)
    {
        if(allVowel.Contains(w[0])) count++;
    }
    Console.WriteLine("3-ий способ: " + count);
}


string[] myWords = { "aqwe", "wer", "rt", "rty", "ytyu"};
CountStringWithVowel(myWords);
CountStringWithVowel2(myWords);
CountStringWithVowel3(myWords);


// Задача 2: Задайте массив строк. Напишите программу, 
//которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CreateNewArray(string[] words)
{
    int arrayLength = words.Length;
    int newArrayLength = 0;

    if(arrayLength % 2 == 0) newArrayLength = words.Length/2;
    else newArrayLength = words.Length/2 + 1;

    string[] newArray = new string[newArrayLength];
    for(int i=0, j=0; j < newArrayLength-1; i+=2, j++)
    {
        newArray[j] = words[i] + words[i+1];
    }

    if(arrayLength % 2 == 0) newArray[newArrayLength-1] = words[arrayLength-2] + words[arrayLength-1];
    else newArray[newArrayLength-1] = words[arrayLength-1];

    return newArray;
}

void ShowArray(string[] words)
{
    Console.Write("{ ");
    foreach(string w in words)
    {
        Console.Write( w + " ");
    }
    Console.Write("}");
    Console.WriteLine();
}

string[] myArray = { "qwe", "wer", "ert", "rty", "tyu", "yui", "ghy"};
//string[] myArray = { "qwe"};
string[] myNewArray = CreateNewArray(myArray);
ShowArray(myArray);
ShowArray(myNewArray);


// и немного докрутила методы с прошлой домашки и лекции:

// int SumBetweenTwoNums2(int m, int n)     Сумма натуральных чисел между N и m
// {
//     if(m==n) return n;
//     else return m + SumBetweenTwoNums2(m+1, n);
// }

// int SumOfDigits(int n)          Сумма цифр чисоа
// {
//     if(n == 0) return 0;
//     else return n%10 + SumOfDigits(n/10);
// }

//задача с семинара, возвести число n в степень m.
// int Exp(int n, int m)
// {
//     if(m==1) return n;
//     else return n*Exp(n, m-1);
// }