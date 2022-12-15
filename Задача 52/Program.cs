//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] TwoDimensionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    int[,] array = new int[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);

        }
    }
    return array;
}
void GetArrayAsString(int[,] massive)
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


double AvgColumns (int[,] massive, int column)
{
    double res = 0;
    for (int j = 0; j < massive.GetLength(0); j++)
    {
        res += massive[j, column];
    }
    return res/massive.GetLength(0);
}




Console.WriteLine("Input m");
int m = ReadInt();
Console.WriteLine("Input n");
int n = ReadInt();

int[,] massiv = TwoDimensionArray(m, n);
Console.WriteLine();
GetArrayAsString(massiv);
Console.WriteLine();
for (int i = 0; i < massiv.GetLength(1); i++)
{
    Console.WriteLine($"{i} -- {AvgColumns(massiv, i)}");
}

