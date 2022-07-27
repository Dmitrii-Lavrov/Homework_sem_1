//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// string PrintNumbersRecusiveType(int M, int N)
// {
//     if (M <= N)
//     {
//         return $"{M} " + PrintNumbersRecusiveType(M+1, N);
//     }
//     else return String.Empty;

// }
// Console.Clear();
// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(M, N));


//----------------------


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumRecusiveType(int M, int N)
{
    if (M == N) return M;
    else return M + SumRecusiveType(M + 1, N);
}
Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) Console.WriteLine("Введены некорректные числа: M должно быть меньше N");
else
{
    SumRecusiveType(M, N);
    Console.WriteLine(SumRecusiveType(M, N));
}


//----------------------


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int A(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return A(n - 1, 1);
//     else
//       return A(n - 1, A(n, m - 1));
// }
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A(n,m));
