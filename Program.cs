// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// Console.WriteLine("Введите количество строк массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] arrey=new int [m,n];
// for (int i=0; i<arrey.GetLength(0); i++)
//    {for (int j=0; j<arrey.GetLength (1); j++)
//     {
//         arrey [i,j]=new Random().Next(1,100);
//         Console.Write ($"{arrey[i,j]}  ");
//     }
//     Console.WriteLine ();
//    }

// for (int i=0; i<arrey.GetLength(0); i++)
//    { for (int j=0; j<arrey.GetLength (1); j++)
//           for (int k = 0; k < arrey.GetLength(1) - 1; k++)
//       {
//         if (arrey[i, k] < arrey[i, k + 1])
//         {
//           int temp = arrey[i, k + 1];
//           arrey[i, k + 1] = arrey[i, k];
//           arrey[i, k] = temp;
//          }
//       }
//    }
//    for (int i=0; i<arrey.GetLength(0); i++)
//    {for (int j=0; j<arrey.GetLength (1); j++)
//     {
//         Console.Write ($"{arrey[i,j]}  ");
//     }
//     Console.WriteLine ();
//    }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// 
//    }
// for (int i=0; i<arrey.GetLength(0); i++)
//    { int sum=0;
//     {for (int j=0; j<arrey.GetLength (1); j++)
//     {
//         sum=sum+arrey[i,j];
//     }
//    }
//     newarrey [i]=sum;
//     Console.Write ($"{newarrey[i]}  ");
//    }
//     int summin= newarrey[0];
//     int num=1;
//     for (int i=0; i<arrey.GetLength(0); i++)
//    {
//         if (newarrey[i]<summin)
//         { summin=newarrey[i];
//          num=num+i;
//         }
//    } 
//    Console.WriteLine ();
//    Console.WriteLine ($"{num} строка с наименьшей суммой элементов: {summin} ");
   

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите количество строк первой матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы:");
int n1 = Convert.ToInt32(Console.ReadLine());
int [,] matrix=new int [m,n];
int [,] matrix1=new int [m1,n1];
int [,] newmatrix=new int [m,n1];
for (int i=0; i<matrix.GetLength(0); i++)
   {for (int j=0; j<matrix.GetLength (1); j++)
    {
        matrix [i,j]=new Random().Next(1,10);
        Console.Write ($"{matrix [i,j]}  ");
    }
    Console.WriteLine ();
   }
for (int i=0; i<matrix1.GetLength(0); i++)
{for (int j=0; j<matrix1.GetLength (1); j++)
    {
        matrix1 [i,j]=new Random().Next(1,10);
        Console.Write ($"{matrix1 [i,j]}  ");
    }
    Console.WriteLine ();
   }
Console.WriteLine ();
if (n==m1)
{for (int i=0; i<m; i++)
    {for (int j=0; j<n1; j++)
    {int sum=0;
     for (int k=0; k<n; k++)
    {
        sum=sum+matrix[i,k]*matrix1[k,j];
    }
    newmatrix[i,j]=sum;
    Console.Write ($"{newmatrix[i,j]}  ");
   }
   Console.WriteLine();
   }
   }
   else Console.WriteLine ($"Такие матрицы умножать нельзя  ");

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07