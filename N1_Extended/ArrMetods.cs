using System.Text;
///<summary>
///Описание: <br/> 
///Класс для создания, заполнения и вывода массивов целых чисел.
///</summary>
public class ArrMethods
{
    ///<summary>
    ///Описание: <para> 
    ///Функция без параметра создает целочисленный массив c длиной, заданной пользователем с клавиатуры.</para>
    ///</summary>
    public static int[] createArr()
    {
        Console.Write("Введите размер массива: ");
        int arrLength = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[arrLength];
        return arr;
    }
    ///<summary>
    ///Описание: <para> 
    ///Функция без параметра создает вещественный массив c длиной, заданной пользователем с клавиатуры.</para>
    ///</summary>
    public static double[] createArr(bool isDouble)
    {
        Console.Write("Введите размер массива: ");
        int arrLength = Convert.ToInt32(Console.ReadLine());
        double[] arr = new double[arrLength];
        return arr;
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция создает целочисленный массив заданной длины.
    ///</summary>
    ///<param name = "arrLength">Длина массива</param>
    public static int[] createArr(int arrLength)
    {
        int[] arr = new int[arrLength];
        return arr;
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция создает вещественный массив заданной длины.
    ///</summary>
    ///<param name = "arrLength">Длина массива</param>
    public static double[] createArr(int arrLength, bool isDouble)
    {
        double[] arr = new double[arrLength];
        return arr;
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция без дополнительных параметров заполняет массив случайными целыми трехзначными числами.
    ///</summary>
    public static void fillArray(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);
        }
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция без дополнительных параметров заполняет массив случайными вещественными числами от 0 до 1.
    ///</summary>
    public static void fillArray(double[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().NextDouble();
        }
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция заполняет массив случайными целыми числами, границы должны быть заданы.
    ///</summary>
    ///<param name = "minValue">Нижняя граница массива</param>
    ///<param name = "maxValue">Верхняя граница массива</param>
    public static void fillArray(int[] arr, int minValue, int maxValue)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(minValue, maxValue + 1);
        }
    }
    ///<summary>
    ///Описание: <br/> 
    ///Функция заполняет массив случайными вещественными числами, границы должны быть заданы.
    ///</summary>
    ///<param name = "minValue">Нижняя граница массива</param>
    ///<param name = "maxValue">Верхняя граница массива</param>
    public static void fillArray(double[] arr, int minValue, int maxValue)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    ///<summary>
    ///Описание: <br/> 
    ///Функция красивенько печатает массив.
    ///</summary>
    public static void printArray(int[] arr)
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
    ///<summary>
    ///Описание: <br/> 
    ///Функция красивенько печатает массив.
    ///</summary>
    public static void printArray(double[] arr)
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
}
