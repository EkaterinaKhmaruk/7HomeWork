/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double sr =0; 

int[,] numbers = new int[rows, columns];
Console.WriteLine("Массив: ");

for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1,10);
            Console.Write($"{numbers[i,j]} ");
        }
    
    Console.WriteLine();
    }
Console.WriteLine();

for(int i = 0; i < numbers.GetLength(1) ; i++)
    {
        double sum = 0;
        for(int j = 0; j < numbers.GetLength(0); j++)
        {
           sum += numbers[j, i];
        }
        sr = sum/rows;
        Console.WriteLine("Среднее арифметическое в {0} столбце: {1}", i, sr);
    }

Console.WriteLine();