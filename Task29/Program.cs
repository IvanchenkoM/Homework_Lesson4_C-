// Напишите программу, которая задает массив из N элементов и выводит их на экран.
//Вывод сделать отдельным методом.
int number = ReadInt("Enter the number: ");
int[] array = new int[number];
for (int i=0; i< array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}

Console.Write($"The random array is made up of {number} elements: ");
Print1();


void Print1()
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}