/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] numbers = new double[rows, columns];
Random rand = new Random();
Console.WriteLine("Массив: ");
for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rand.NextDouble()*10;
            numbers[i,j] = Math.Round(numbers[i,j],1); //для красоты
            
            Console.Write($"{numbers[i,j]} ");
        }
    Console.WriteLine();
    }
Console.WriteLine();