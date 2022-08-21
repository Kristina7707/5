// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;
int[] CreateArray(int size)
{
    int[] array = new int[size];
     Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (i<array.Length-1)Console.Write($"{array[i]}, "); 
        else Console.Write(array[i]);
    }Console.Write("]");
    return array;
}
void PrintArray(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
         
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях(индексах) = {sum} ");
    
}
PrintArray(CreateArray(size));