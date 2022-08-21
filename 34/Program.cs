// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 4;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
 {
    int even = 0;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1)Console.Write($"{array[i]}, "); 
        else Console.Write(array[i]); 
        if (array[i] % 2 == 0) even++;
      }   
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}");
    
}
PrintArray(CreateArray(size));

