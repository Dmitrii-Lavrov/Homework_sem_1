
Console.Write("Введите количество элементов в массиве: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
int sortArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        sortArrayLength++;
    }       
string[] sortArray = new string[sortArrayLength];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
    {
        sortArray[j] = array[i];
        j++;
    }
}
Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" -> ");
Console.Write("[{0}]", string.Join(", ", sortArray));
Console.WriteLine();




