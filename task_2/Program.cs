//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input first number: "); 
int a = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input second number: "); 
int b = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input fhird number: "); 
int c = Convert.ToInt32(Console.ReadLine()) ;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;   

Console.WriteLine ("max = " + max);