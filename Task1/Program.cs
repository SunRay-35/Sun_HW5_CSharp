// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int intLength, int intMin, int intMax)
{
    int[] tempArray = new int[intLength];
    for (int i = 0; i < intLength; i++)
    {
        tempArray[i] = new Random().Next(intMin, intMax+1);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

bool IsEven(int intNum)
{
    if (intNum % 2 == 0) return true;
    return false;
}

void PrintCountOfEven(int[] intArray)
{
    int intCouter = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (IsEven(intArray[i])) intCouter++;
    }
    System.Console.Write("В массиве [");
    printArray(intArray: intArray);
    System.Console.Write($"] {intCouter} число(-а,-ел) являются четными.");
}

System.Console.WriteLine("Данная программа генерирует массив из положительных трехзначных чисел и считает количество четных чисел в нем.");
int intN = 5; // Размер массива
int intMin = 100; // Начальная граница интервала генерации чисел
int intMax = 990; // Конечная граница интервала генерации чисел

int[] randArray = CreateArray(intN, intMin, intMax);
PrintCountOfEven(randArray);
