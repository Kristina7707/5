// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int size = 4;
double[] CreateArray(int size)
{
    double[] array = new double[size];
   
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}
void PrintDiffMinMax(double[] arr)
{  Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
         if (i<arr.Length-1)Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }Console.Write("]");
    double difference = arr.Max() - arr.Min(); 
    Console.WriteLine();
    Console.Write("Разница между максимальным и минимальным элементами массива = "); 
    Console.Write(Math.Round (difference,3));
    
}
PrintDiffMinMax(CreateArray(size));
