//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и 
//последнюю строку массива.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
ReversArray(array);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    for(int i = 0; i< m;i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    
    for(int i = 0; i< inArray.GetLength(0);i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
           Console.Write($" {inArray[i,j]} "); 
           
        }
        Console.WriteLine();
    }
}
void ReversArray(int[,] arr)
{
    int[,] inArr = new int [arr.GetLength(0),arr.GetLength(1)];
    int result  = 0;
    for(int i = 0; i< arr.GetLength(0); i++)
    {
        result = arr[0,i];
        arr[0,i] = arr[arr.GetLength(0) -1 ,i];
        arr[arr.GetLength(0) - 1, i] = result;
        }
        Console.WriteLine();
}