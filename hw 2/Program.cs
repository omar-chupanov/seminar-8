//  Задайте прямоугольный двумерный массив. 
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int SumNumbers(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void MinSum(int[,] array)
{
    int minSum = 0;
    int sumRows = SumNumbers(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = SumNumbers(array, i);
        if (sumRows > tempSum)
        {
            sumRows = tempSum;
            minSum = i;
        }
    }
    Console.WriteLine($"{minSum + 1} - строкa с наименьшей суммой ({sumRows}) элементов ");
}

int rows = ReadInt("Введите количество строк ");
int columns = ReadInt("Введите количество колонн ");
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);
MinSum(array);



