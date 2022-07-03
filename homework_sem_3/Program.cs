// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//double Distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
//{
//    return Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
//}

   //     Console.WriteLine("Введите координату Ax");
   //     int Ax = Convert.ToInt32(Console.ReadLine());
   //    Console.WriteLine("Введите координату Ay");
   //     int Ay = Convert.ToInt32(Console.ReadLine());
   //     Console.WriteLine("Введите координату Az");
   //     int Az = Convert.ToInt32(Console.ReadLine());
   //     Console.WriteLine("Введите координату Bx");
   //     int Bx = Convert.ToInt32(Console.ReadLine());
   //     Console.WriteLine("Введите координату By");
   //     int By = Convert.ToInt32(Console.ReadLine());
   //     Console.WriteLine("Введите координату Bz");
   //     int Bz = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Round(Distance(Ax, Ay, Az, Bx, By, Bz), 2));





//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Console.WriteLine("Введите число");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write(number + "-> ");

//if (number >= 0)
//{
//    for (int i = 1; i <= number; i++)
//    Console.Write(i*i*i + " ");
//}
//else 
//{
//    for (int i = -1; i >= number; i--)
//    Console.Write(i*i*i + " ");
//}






//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int new_number = (number % 10 * 10000) + (number % 100 /10 * 1000) + (number % 1000 /100 * 100) + (number % 10000 /1000 * 10) + (number /10000);

if (number / 10000 > 9 | number / 10000 <1) Console.WriteLine ("Вы ввели не пятизначное число!");
else if (new_number == number)
{
     Console.WriteLine("Число явлеется палиндромом");
}
else Console.WriteLine("Число не является палиндромом");