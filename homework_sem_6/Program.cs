//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* int[] GenerateArray(int M)
{
    int[] Array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите число {i+1}: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());;
    }
    return Array;
} 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Укажите количество,вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] myArray = GenerateArray(M);

int sum = 0;
for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0) sum = sum + 1;
    } 
ShowArray(myArray);    
Console.WriteLine("-> " + sum);     */


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите переменную k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b2");
double b2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают!");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются!");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x};{y})");
} 