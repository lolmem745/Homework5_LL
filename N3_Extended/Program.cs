double[] array = ArrMethods.createArr(true);
ArrMethods.fillArray(array, 1, 5);
ArrMethods.printArray(array);
double minElem = array[0];
double maxElem = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (minElem > array[i]) minElem = array[i];
    if (maxElem < array[i]) maxElem = array[i];
}
double res = maxElem - minElem;
Console.WriteLine($"Разница между самым большим и маленьким элементом в массиве: {res}");