//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
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
void PrintArray (int[,] array)
 {
 for (int i =0; i<array.GetLength(0); i++ )  
    {
         for (int j = 0; j<array.GetLength(1); j++) 
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine(); 
    }
 }


double[] GetMatrix (int[,] matrix )
{
    double[] result = new double [matrix.GetLength(0)] ;
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        double total = 0;
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            total+=matrix[i,j];
        }
        total /= matrix.GetLength(1);
        result [i]=total;
    }
    return result;
}

int [,] matr = GetRandomArray (m: 4, n: 5, min: 10, max: 90) ;
PrintArray (matr);
double[] result = GetMatrix (matr);
Console.Write($"Среднее арифметическое столбцов: {string.Join(";", result)}");