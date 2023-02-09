//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double RandomDouble (int miniBorder, int maxBorder)
{
    double randomDouble = new Random().NextDouble() * (maxBorder-miniBorder)+miniBorder;
    return randomDouble;
}
double[,] GetDoubleMantrix (int m, int n, int miniBorder, int maxBorder )
{
    double[,] matrix = new double [m,n] ;
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            matrix[i,j]= RandomDouble(miniBorder, maxBorder);
        }
        
    }
    return matrix;
}

 void PrintArray (double[,] array)
 {
 for (int i =0; i<array.GetLength(0); i++ )  // имя_массива.GetLength(0)- замена длины массива. (0)- строки
    {
         for (int j = 0; j<array.GetLength(1); j++) // имя_массива.GetLength(0)- замена длины массива. (1)- столбцы
        {
            Console.Write($"{array[i,j]:f2}\t ");
        }
        Console.WriteLine(); // переход на новую строку
    }
 }

Console.Clear();
double [,] matr = GetDoubleMantrix (m: 4, n: 5, miniBorder: 10, maxBorder: 90) ; 
PrintArray (matr);