/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);
SumOddPosition(array);

int result = SumOddPosition(array);
Console.WriteLine($"Сумма элементов нечетных позиций массива равна {result}");

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
    Console.WriteLine();
}

int SumOddPosition(int[] array)
{
    int sum = 0;
    int count = array.Length;
    for (int i = 1; i < count; i += 2)
    {
        sum += array[i];
    }
    return sum;
}