//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.Security.Claims;

int [,] TwoDimensionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int [,] array = new int [lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0,10);

        }
    }
    return array;
}
void GetArrayAsString(int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:0.##} ", massive[i, j]));
        }
        Console.WriteLine();
    }
}

int ReadInt()
{
    int a = int.Parse(Console.ReadLine());
    return a;
}


void Check (int[,] massive, int a, int b)
{
    if (a < massive.GetLength(0) && b < massive.GetLength(1))
    {
        Console.WriteLine("Элемент с заданными позициями = " + massive[a,b]);
    }
    else
    {
        Console.WriteLine("Элемента с заданными позициями не существует");
    }
}

Console.WriteLine("Input m");
int m = ReadInt();
Console.WriteLine("Input n");
int n = ReadInt();

int [,] massiv = TwoDimensionArray(m, n);
Console.WriteLine();
GetArrayAsString(massiv);
Console.WriteLine();
Console.WriteLine("Input i");
int i = ReadInt();
Console.WriteLine("Input j");
int j = ReadInt();
Console.WriteLine();
Check (massiv, i, j); 
