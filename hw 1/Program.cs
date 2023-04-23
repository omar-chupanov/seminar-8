// Задайте двумерный массив. Напишите программу, которая 
// упорядочивает по убыванию элементы каждой строки двумерного массива.

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = 0; g < array.GetLength(1) - 1; g++)
            {
                if (array[i, g] < array[i, g + 1])
                {
                    int temp = array[i, g + 1];
                    array[i, g + 1] = array[i, g];
                    array[i, g] = temp;
                }
            }
        }
    }
}

int rows = ReadInt("Введите количество строк > ");
int columns = ReadInt("Введите количество колонн > ");
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);
System.Console.WriteLine();
SortArray(array);
Print2DArray(array);


