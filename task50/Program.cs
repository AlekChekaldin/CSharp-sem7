// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();

int[,] GetRandomArray (int m, int  n,  int min, int max )
{
    int[,] result = new int [m,n] ;
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<m; j++)
         result [i,j]=new Random().Next(min, max+1);
    }
    return  result;
}

void GetMantrix(int[,] matrix)
{
    Console.Write("Введите строку с 0: ");
    int row = int.Parse(Console.ReadLine ()!);
    if (row >=matrix.GetLength(0)) Console.WriteLine("Такого числа нет");
    else
    {
     Console.Write("Введите столбец с 0: ");
     int colunn = int.Parse(Console.ReadLine ()!); 
     if (colunn >=matrix.GetLength(1)) Console.WriteLine("Такого числа нет"); 
     else Console.WriteLine(matrix[row, colunn]);
    }
}

void PrintArray (int[,] array)
 {
 for (int i =0; i<array.GetLength(0); i++ )  // имя_массива.GetLength(0)- замена длины массива. (0)- строки
    {
         for (int j = 0; j<array.GetLength(1); j++) // имя_массива.GetLength(0)- замена длины массива. (1)- столбцы
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine(); // переход на новую строку
    }
 }

int [,] matr = GetRandomArray (m: 4, n: 5, min: 10, max: 90) ; 
PrintArray (matr);
GetMantrix (matr);
