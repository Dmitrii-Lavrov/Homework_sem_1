//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Console.Write("Введите трёхзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 999 | number < 100)
//{
//    Console.WriteLine("Вы ввели не трёхзначное число!");
//}
//else
//{
//Console.WriteLine("Вторая цифра -> " + number / 10 % 10);
//}



//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number < 100)
//{
//    Console.WriteLine("Третьей цифры нет!");
//}
//else if (number < 1000)
//{
//Console.WriteLine("Третья цифра -> " + number  % 10 );
//}  
//else if (number < 10000)
//{
//Console.WriteLine("Третья цифра -> " + number / 10 % 10 );
//}
//else if (number < 100000)
//{
//Console.WriteLine("Третья цифра -> " + number / 100 % 10 );
//}
//else Console.WriteLine("Вы ввели слишком большое число!");



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 | number < 1)
{
    Console.WriteLine("Введено некорректное значение!");
}
else if (number > 5)
{
  Console.WriteLine("УРА! Сегодня выходной!");
}
else Console.WriteLine("Сегодня будний день");