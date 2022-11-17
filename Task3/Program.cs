// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

double[] CreateArrayOfDouble(int intLength, int intMin, int intMax)
{
    double[] tempArray = new double[intLength];
    for (int i = 0; i < intLength; i++)
    {
        tempArray[i] = GenerateRandomDouble(intMin, intMax);
    }
    return tempArray;
}

void printArrayOfDouble(double[] dblArray)
{
    System.Console.Write($"{dblArray[0]}");
    for (int i = 1; i < dblArray.Length; i++)
    {
        System.Console.Write($", {dblArray[i]}");
    }
}

double GenerateRandomDouble(int intMin, int intMax) // Генерирует случайное вещественное число в заданных границах.
{
    double temp = new Random().Next(intMin, intMax+1);
    if (temp > 0) temp -= new Random().NextDouble();
        else temp += new Random().NextDouble();
    temp = ((double)((int)(temp * 100))) / 100; // Округляем
    return temp;
}

(double, double) FindMinMaxArrayOfDouble (double[] dblArray)
{
    double dblMin = dblArray[0];
    double dblMax = dblArray[0];
    for (int i = 1; i < dblArray.Length; i++)
    {
        if (dblArray[i]>dblMax) dblMax = dblArray[i];
            else if (dblArray[i]<dblMin) dblMin = dblArray[i];
    }
    return (dblMin, dblMax);
}

void PrintMinMaxDifferenceArrayOfDouble (double[] dblArray)
{
double dblMin = 0;
double dblMax = 0;
(dblMin, dblMax) = FindMinMaxArrayOfDouble(dblArray);
System.Console.Write("Разница между максимальным и минимальным элементом массива [");
printArrayOfDouble(dblArray);
System.Console.WriteLine($"] составляет {((double)((int)((dblMax - dblMin) * 100))) / 100}");

}

System.Console.WriteLine("Данная программа принимает на вход размер массива N, минимальное Min и максимальное Max значение для генерации случайных чисел, создает массив заданной размерности случайными вещественными числами в заданном диапазоне, находит разницу между максимальным и минимальным значениями в массиве.");
int intN = PromptInt("Введите размер массива - N: ");
int intMin = PromptInt("Введите минимальное значение случайного числа - Min: ");
int intMax = PromptInt("Введите максимальное значение случайного числа - Max: ");

double[] randArray = CreateArrayOfDouble(intN, intMin, intMax);
PrintMinMaxDifferenceArrayOfDouble (randArray);