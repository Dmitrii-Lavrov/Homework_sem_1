//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/* int[] GenerateRandomArray(int N)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(100, 1000);
    }
    return RandomArray;
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите колличество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = GenerateRandomArray(num);

int sum = 0;
for (int i = 0; i < myRandomArray.Length; i++)
    {
        if ((myRandomArray[i] % 2) == 0) sum = sum + 1;
    }
ShowArray(myRandomArray);    
Console.WriteLine("-> " + sum);   */



//Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
/* int[] GenerateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите колличество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива.");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива.");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = GenerateRandomArray(num, min, max);


int sum = 0;
for (int i = 1; i < myRandomArray.Length; i += 2)
{
    sum = sum + myRandomArray[i];
}
ShowArray(myRandomArray);
Console.WriteLine("-> " + sum); */




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GenerateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   
}

Console.WriteLine("Введите колличество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = GenerateRandomArray(num, min, max);

int min_pos = myRandomArray[0];
int max_pos = myRandomArray[0];
for (int i = 1; i < myRandomArray.Length; i++)
{
    if(myRandomArray[i] > max_pos) max_pos = myRandomArray[i];
    if(myRandomArray[i] < min_pos) min_pos = myRandomArray[i];
}
ShowArray(myRandomArray);
Console.WriteLine("-> " + (max_pos - min_pos));



