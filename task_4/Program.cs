//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: "); 
int N = Convert.ToInt32(Console.ReadLine()) ;

if (N > 0)
   {
    
      int count = 1;

      while (count <= N)
      {
      if ((count % 2) == 0) 
        Console.Write(count + ", ");
    
      count ++;
      }
   }
else   
    {
        int count = -1;

      while (count >= N)
      {
      if ((count % 2) == 0) 
        Console.Write(count + ", ");
    
      count --;
      }
    } 