// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.

int[] array = new int[20];
Random temp = new Random();
int k = 0;

Console.WriteLine("Исходный массив данных:");
for (int i = 0; i < 20; i++)
{
    array[i] = temp.Next(1,99);
    Console.Write(array[i]+" ");
    if (array[i]%2 == 0)
    {
        k++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов = "+k);
Console.WriteLine("Массив из четных чисел:");

int[] arrayfinal = new int[k];

k = 0;

for (int i = 0; i < 20; i++)
{
    if (array[i]%2 == 0)
    {
        arrayfinal[k] = array[i];
        Console.Write(arrayfinal[k]+" ");
        k++;        
    }
}
