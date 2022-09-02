// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество элементов массива");
int a = int.Parse(Console.ReadLine());

int [] collection = new int[a];

int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(100,1000);
        index++;
    }
int count = 0;
int i = 0;
while (i<length)
{
    if (collection[index]%2 == 0)
    {
        count = count + 1;
    }
    i++;
}
Console.WriteLine(count);



