// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintInRecursion(int intN)
{
    if (intN > 0)
    {   
        int temp = intN - 1;
        PrintInRecursion(temp);
        for (int i = 0; i<intN; i++)
        {
            System.Console.Write($"{intN} ");
        }
    }
}

System.Console.WriteLine("Данная программа принимает на вход натуральное число N и в рекурсии выводит с заданной логикой строку");
int intN = PromptInt("Введите N: ");
PrintInRecursion(intN);