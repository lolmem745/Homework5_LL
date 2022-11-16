int[] array = ArrMethods.createArr();
ArrMethods.fillArray(array, 5, 10);
ArrMethods.printArray(array);
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        res++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {res}");
Console.ReadKey(true);