int[] array = ArrMethods.createArr();
ArrMethods.fillArray(array);
ArrMethods.printArray(array);
int res = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    res = res + array[i];
}
Console.WriteLine($"Сумма нечетных элементов в массиве: {res}");