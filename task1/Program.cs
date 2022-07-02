// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int Promt(string msg)
{
    System.Console.Write(msg);
    int numberInt = int.Parse(Console.ReadLine());
    return numberInt;
}

int[] FillArray(int[] fillArr)
{
    int length = fillArr.Length;
    for (int i = 0; i < length; i++)
    {
        int element = Promt($"Введите элемент {i + 1} ");
        fillArr[i] = element;
    }
    return fillArr;
}

void PrintArray(int[] printArr)
{
    int length = printArr.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{printArr[i]} ");
    }
}

int СalculatePositivElement(int[] calcArr)
{
    int length = calcArr.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (calcArr[i] > 0) sum++;
    }
    return sum;
}

int numberElementMassiv = Promt("Введите число элементов массива => ");

int[] array = new int[numberElementMassiv];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int sum = СalculatePositivElement(array);
System.Console.WriteLine($"число положительных элементов массива = {sum}");