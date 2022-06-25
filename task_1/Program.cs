// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number: "); 
int number_1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input second number: "); 
int number_2 = Convert.ToInt32(Console.ReadLine()) ;

if (number_1 < number_2)
    Console.WriteLine ("max = " + number_2);
else
    Console.WriteLine ("max = " + number_1);
