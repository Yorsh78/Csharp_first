﻿//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Пощелкай пальчиками по клавиатуре, дружок, не ленись");
int m = InputNumbers("Ширина первого квадратика из цифр - ");
int n = InputNumbers("Высота первого квадратика из цифр - ");
int r = InputNumbers("Ширина второго квадратика из цифр - ");
int p = InputNumbers("Высота второго квадратика из цифр - ");
int range = InputNumbers("Введите диапазон случайных чисел - от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первый квадратик из цифр -");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[r, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Второй квадратик из цифр - ");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Перемножим-ка квадратики из цифр -");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Форматирование такое?

// перепроверил задачу 36 по Вашему замечанию - алгоритм считает сумму значений на нечетных позициях.