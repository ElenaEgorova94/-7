//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



double[,] TwoDimensionArray(int lenght, int secondlenght)
{
    Random random = new Random();
    double[,] array = new double[lenght, secondlenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextSingle() * 100 * GenerateOneMinusOne();

        }
    }
    return array;
}
void GetArrayAsString(double[,] massive)
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


int GenerateOneMinusOne()
{
    Random random = new Random();
    if (random.Next(10) > 5) return 1;
    return -1;
}


Console.WriteLine("Input m");
int m = ReadInt();
Console.WriteLine("Input n");
int n = ReadInt();

double[,] massiv = TwoDimensionArray(m,n);
Console.WriteLine();
GetArrayAsString(massiv);
