// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

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

void PrintSumOfEven(int[] intArray, int intEven) // Считает сумму элементов массива, вторым параметром передаем позицию четных (0) или нечетных (1)
 {
    int intSum = 0;
    for (int i = intEven; i < intArray.Length; i += 2)
    {
        intSum += intArray[i];
    }
    System.Console.Write("В массиве [");
    printArray(intArray: intArray);
    string tempStr = "четных";
    if (intEven == 1) tempStr = "нечетных";
    System.Console.Write($"] cумма чисел на {tempStr} позициях равна {intSum}.");
}

System.Console.WriteLine("Данная программа принимает на вход размер массива N, минимальное Min и максимальное Max значение для генерации случайных чисел, создает массив заданной размерности случайными числами в заданном диапазоне, находит сумму чисел находящихся на четной/нечетной позиции в массиве.");
int intN = PromptInt("Введите размер массива - N: ");
int intMin = PromptInt("Введите минимальное значение случайного числа - Min: ");
int intMax = PromptInt("Введите максимальное значение случайного числа - Max: ");
int intEven = PromptInt("Введите 0 - если суммировать все четные позиции, введите 1 - если суммировать все нечетные позиции: ");
if (intEven < 0) intEven = 0;
    else if (intEven > 1) intEven = 1;

int[] randArray = CreateArray(intN, intMin, intMax);
PrintSumOfEven(randArray, intEven);