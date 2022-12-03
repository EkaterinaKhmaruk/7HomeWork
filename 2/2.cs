/*Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет. Во вводе первая цифра
 - номер строки, вторая - столбца. Цифры не больше 9.
 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позиции искомого элемента i,j: ");
int element = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
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

int firstElement = element/10;
int secondElement = element%10;

if(firstElement <= numbers.GetLength(0) && secondElement <= numbers.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine($"Искомый элемент: {numbers[firstElement,secondElement]}");
}
else Console.WriteLine("такого числа в массиве нет");
Console.WriteLine();



