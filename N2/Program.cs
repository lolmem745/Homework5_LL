int[] createArr(int arrLength)
{
    int[] arr = new int[arrLength];
    return arr;
}

int[] arrFilling(int[] arr, int minValue = 100, int maxValue = 999)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]\n");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = arrFilling(createArr(size));
printArray(array);
int res = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    res = res + array[i];
}
Console.WriteLine($"Сумма нечетных элементов в массиве: {res}");