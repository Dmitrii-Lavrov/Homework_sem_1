// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* Console.WriteLine("Введите необходимое колличество повторений цикла");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите первое число");
    int A = Convert.ToInt32(Console.ReadLine());
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(A + "^" + B + " -> " + Math.Pow(A, B));
} */




 // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number;
int sum = 0;
while (N  >  0)
{
   sum = sum + N % 10;
   N = N / 10;
}
Console.WriteLine(number + " -> " + (sum)); 




//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/* Console.WriteLine("Введите мимнимальное значение диапазона случайных чисел");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона случайных чисел");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];
    for (int i = 0; i < N; i++)
    {
        Array[i] = new Random().Next(min, max);
        Console.Write(Array[i] + " ");
    }
Console.WriteLine(); 
 */