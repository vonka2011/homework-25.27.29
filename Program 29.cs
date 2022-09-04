// напишите программу, кот.выдает массив из 8 элементов и выводит их на экран


int[] CreatArray(int size, int minValue, int MaxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, MaxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0;i<array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.Write("Введите размер желаемого массива из 8 элементо: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите минимальное число диапазона цифр в массиве: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите максимальное число диапазона цифр в массиве: ");
int maxValue=Convert.ToInt32(Console.ReadLine());

int[] binaryArray = CreatArray(size, minValue, maxValue);
ShowArray(binaryArray);
