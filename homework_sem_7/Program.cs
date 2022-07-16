//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(maxValue-minValue) + minValue;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row, column]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(rows, columns, -10, 10);
// PrintArray(array);





//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] GenerateRandomArray(int m, int n, int min, int max)
{
    int[,] RandomArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            RandomArray[i, j] = new Random().Next(min, max);
        }
    }
    return RandomArray;
}

void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите колличество строк массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = GenerateRandomArray(row, column, 0, 10);
ShowArray(myRandomArray);

Console.WriteLine("Введите позицию строки в двумерном массиве");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца в двумерном массиве");
int j = Convert.ToInt32(Console.ReadLine());
if (i > myRandomArray.GetLength(0) || i < 0 ||
j > myRandomArray.GetLength(1) || j < 0)
{
    Console.Write("В данном массиве такого элемента не существует");
    Console.WriteLine();
}
else
{
    Console.Write($"({i},{j}) -> {myRandomArray[i, j]}");
    Console.WriteLine();
}




// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int[,] GenerateRandomArray(int m, int n, int min, int max)
// {
//     int[,] RandomArray = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             RandomArray[i, j] = new Random().Next(min, max);
//         }
//     }
//     return RandomArray;
// } 

// void ShowArray(int[,] array)
// {
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1); column++)
//         {
//            Console.Write(array[row,column] + " ");  
//         }
//        Console.WriteLine(); 
//     }
// }

// Console.WriteLine("Введите количество строк массива");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] myRandomArray = GenerateRandomArray(row, column, 0, 100);
// ShowArray(myRandomArray);

// Console.Write("Среднее арифметическое каждого столбца: ");

// for (int j = 0; j < myRandomArray.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < myRandomArray.GetLength(0); i++)
//     {
//         sum = sum + myRandomArray[i, j];
//     }
//     Console.Write($"{sum / myRandomArray.GetLength(0):f1}; ");
// }
// Console.WriteLine();

