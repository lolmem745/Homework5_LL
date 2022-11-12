double[] createArr(int arrLength)
{
    double[] arr = new double[arrLength];

    return arr;
}

double[] arrFilling(double[] arr, int minValue = 100, int maxValue = 999)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 10;
        arr[i] = Math.Round(arr[i], 2);
    }
    return arr;
}

void printArray(double[] arr)
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
double[] array = arrFilling(createArr(size));
printArray(array);
double minElem = array[0];
double maxElem = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (minElem > array[i]) minElem = array[i];
    if (maxElem < array[i]) maxElem = array[i];
}
double res = maxElem - minElem;
Console.WriteLine($"Разница между самым большим и маленьким элементом в массиве: {res}");