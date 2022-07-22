//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
// int[,] myRandomArray = GenerateRandomArray(row, column, -10, 10);
// ShowArray(myRandomArray);

// int minSum = 0;
// for (int j = 0; j < myRandomArray.GetLength(1); j++)
//     {
//         minSum = minSum + myRandomArray[0, j];
//     }

// int minRow = 0;
// for (int i = 0; i < myRandomArray.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < myRandomArray.GetLength(1); j++)
//     {
//         sum = sum + myRandomArray[i, j];
//     }
//     Console.WriteLine($"Сумма строки с позицией '{i}' = {sum}");
//     if (sum < minSum)
//     {
//         minSum = sum;
//         minRow = i;
//     }
// }
// Console.WriteLine($"Сумма минимальной строки: {minSum}. Позиция строки: {minRow}");


//--------------------


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int[,] GenerateRandomArray(int m, int n, int min, int max)
// {
//     int[,] RandomArray = new int[m, n];
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
//             Console.Write(array[row, column] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите количество строк 1 массива");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1 массива");
// int column1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк 2 массива");
// int row2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 2 массива");
// int column2 = Convert.ToInt32(Console.ReadLine());
// if (column1 != row2)
// {
//     Console.WriteLine($"Такие матрицы умножать нельзя!");
//     return;
// }
// int[,] Array1 = GenerateRandomArray(row1, column1, 0, 10);
// ShowArray(Array1);
// Console.WriteLine("---------------");
// int[,] Array2 = GenerateRandomArray(row2, column2, 0, 10);
// ShowArray(Array2);
// Console.WriteLine("---------------");

// int[,] GetMultiplikationMatrix(int[,] Array1, int[,] Array2)
// {
//     int[,] Array = new int[Array1.GetLength(0), Array2.GetLength(1)];
//     for (int i = 0; i < Array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array1.GetLength(0); k++)
//             {
//                 Array[i, j] += Array1[i, k] * Array2[k, j];
//             }

//         }
//     }
//     return Array;
// }
// int[,] Array = GetMultiplikationMatrix(Array1, Array2);
// ShowArray(Array);



//-------------------------


//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// void SelectionSort(int[,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxPosition = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)   
//             {
//                 if (array[i,k] > array[i,maxPosition])
//                 {
//                    maxPosition = k; 
//                 }
//             }
//             int temp = array[i,j];
//             array[i,j] = array[i,maxPosition];
//             array[i,maxPosition] = temp;
//         }
//     }
// }

// Console.WriteLine("Введите количество строк массива");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] Array = GenerateRandomArray(row, column, 0, 10);
// ShowArray(Array);
// SelectionSort(Array);
// Console.WriteLine();
// ShowArray(Array);


//-------------------------


//Заполните спирально массив 4 на 4.Например, на выходе получается вот такой массив:
void ShowArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
           Console.Write(array[row,column] + " ");  
        }
       Console.WriteLine(); 
    }
}

int[,] GetArray(int size)
{
    int[,] array = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size - 1;
    int columnE = size - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        array[i, j] = count;
        //идем вправо
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        // идем вниз
        if (!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идем влево
        if (!left && !top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //идем вверх
        if (left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return array;
}

int[,] Array = GetArray(4);
ShowArray(Array);


//-------------------------------


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[, ,] GenerateRandomArray(int m, int n, int l, int min, int max)
// {
//     int[, ,] RandomArray = new int[m,n,l];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             int k = 0;
//             while(k < RandomArray.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(RandomArray, element)) continue;
//                 RandomArray[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return RandomArray;
// } 

// bool FindElement(int[, ,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }

// void ShowArray(int[, ,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            for (int l = 0; l < array.GetLength(2); l++)
//            {
//                Console.Write($"{array[i,j,l]} ({i},{j},{l}) "); 
//            } 
//            Console.WriteLine();
//         } 
//     }
// }

// int[, ,] Array = GenerateRandomArray(2, 2, 2, 1, 10);
// ShowArray(Array);