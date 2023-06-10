// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = InputNumbers("Введите значение m: ");
int n = InputNumbers("Введите значение n: ");
int range = InputNumbers("Введите число: ");

int[,] array = new int[m, n];
GenerateArray(array);
PrintArray(array);

int min_sum = 0;
int sum_line = Sum_Elements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp_sum = Sum_Elements(array, i);
    if (sum_line > temp_sum)
    {
        sum_line = temp_sum;
        min_sum = i;
    }
}

Console.WriteLine($"{min_sum + 1} - строка с наименьшей суммой ({sum_line})");


int Sum_Elements(int[,] array, int i)
{
    int sum_line = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum_line += array[i, j];
    }
    return sum_line;
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}