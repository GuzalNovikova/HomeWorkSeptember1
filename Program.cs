//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreatRandomArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int countEven(int[] array)
{
    int count = 0;
    int size = array.Length;
    for(int i = 0; i < size; i++)
        if(array[i] % 2 == 0) count ++;
    
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size);
ShowArray(myArray);

int countNumber = countEven(myArray);
Console.WriteLine($"Count of even numbers is {countNumber}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreatRandomArray(int size, int minN, int maxN)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minN, maxN + 1);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindPositiveCurrentSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(i % 2 > 0) sum += array[i];
    
    return sum;

}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

int positiveCurrentSum = FindPositiveCurrentSum(myArray);

Console.WriteLine($"Sum of positive current is {positiveCurrentSum}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreatRandomArray(int size, int minN, int maxN)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minN, maxN + 1);
    
    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DeltaMinMax(double[] array)
{
    double delta = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];
        else
        {
            if(array[i] < min) min = array[i];
        }
    delta = max - min;
    return delta;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible number: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

double deltaMinMax = DeltaMinMax(myArray);

Console.WriteLine($"Delta min and max is {deltaMinMax}");
*/
