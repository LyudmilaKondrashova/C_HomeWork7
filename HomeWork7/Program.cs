// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    double[,] array = new double[rows, columns];

    FillArrayReal(array);
    PrintArrayReal(array);
}

// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
//ДЛЯ ПОЛЬЗОВАТЕЛЯ НУМЕРАЦИЯ СТРОК И СТОЛБЦОВ НАЧИНАЕТСЯ С 1
void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int[,] array = new int[rows, columns];

    FillArray(array,-100,100);
    PrintArray(array);

    Console.Write("Введите номер строки: ");
    int rowElem = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int columnElem = Convert.ToInt32(Console.ReadLine());
    if (rowElem < 1 || rowElem > rows || columnElem < 1 || rowElem > columns)
        Console.WriteLine($"В массиве нет элемента, стоящего на позиции ({rowElem},{columnElem})");
    else Console.WriteLine($"Элемент массива, стоящий на позиции ({rowElem},{columnElem}) равен {array[rowElem-1,columnElem-1]}");
}

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int[,] array = new int[rows, columns];

    FillArray(array, -10 , 10);
    PrintArray(array);

    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
    PrintArrayReal(FindSredArif(array));
}


void FillArray(int[,] array, int startNumber = 0, int finishNumber = 9)
{
    Random random = new Random();
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArrayReal(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(50 - random.NextDouble() * 100, 1);
        }
    }
}

void PrintArrayReal(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] FindSredArif(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[,] resultArray = new double[1,columns];

    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
            resultArray[0, j] += array[i, j];
        resultArray[0, j] = Math.Round((double)(resultArray[0, j]) / (double)rows, 2);
    } 

    return resultArray;
}

Zadacha47();
Zadacha50();
Zadacha52();