// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите число - размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
FillArrayRandomNumbers(massive);
Console.WriteLine("Массив: ");
PrintArray(massive);
int count = 0;

for (int i = 0; z < massive.Length; i++)
if (massive[i] % 2 == 0)
count++;

Console.WriteLine($"В этом массиве {massive.Length} чисел,  из них чётные - {count}");
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int minimum=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int maximum=int.Parse(ReadLine()!);
int[] Array= GetArray(length, minimum, maximum);
WriteLine($"[{string.Join(", ", Array)}]"); 
FindOdd(Array);

int[] GetArray(int size, int minVal, int maxVal)
{
    Random N= newRandom(); 
    int[] result= newint[size];
    for(int i= 0; i< result.Length; i++)
    {
        result[i] = N.Next(minVal, maxVal+ 1);
    }
    return result;
    }

void FindOdd(int[] MyArray)
{
    int odd=0;
    for(inti= 1; i< MyArray.Length; i=i+2)
{
    odd=odd+MyArray[i];
}
WriteLine($"Сумма нечетных чисел: {odd}");
}
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементамимассива.
using staticSystem.Console;
Clear(); 
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: "); 
int minim=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int maxim=int.Parse(ReadLine()!);
int[] Array= GetArray(length, minim, maxim);
WriteLine($"[{string.Join(", ", Array)}]"); 
FindDifference(Array, max, min);

int[] GetArray(intsize, intminValue, intmaxValue)
{
    Randomrnd= newRandom();
    int[] result= newint[size];
    for(inti= 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
        }
    return result;
    }

void FindDifference(int[] MyArray, intminVal, intmaxVal)
{
    for(inti= 0; i< MyArray.Length; i++)
    {
        if(MyArray[i] < minVal)
        {
            minVal=MyArray[i];
            }
        if(MyArray[i] > maxVal)
        {
            maxVal=MyArray[i];
            }
        }
        WriteLine($"Разница {maxVal-minVal}");
}
