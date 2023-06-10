// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите случайное число: ");

int[,] firstMartrix = new int[m, n];
GenerateArray(firstMartrix);
System.Console.WriteLine("Первая матрица");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
GenerateArray(secomdMartrix);
System.Console.WriteLine("Вторая матрица");
PrintArray(secomdMartrix);

int[,] thirdMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, thirdMatrix);
System.Console.WriteLine("Резултат");
PrintArray(thirdMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] thirdMatrix)
{
  for (int i = 0; i < thirdMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < thirdMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      thirdMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void GenerateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
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