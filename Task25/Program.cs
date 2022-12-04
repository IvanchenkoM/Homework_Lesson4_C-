// Напишите цикл, который принимает два числа (А и В) и возводит число А в степень В.

int numberFirst = ReadInt("Enter the first number: ");
int numberSecond = ReadInt("Enter the second number: ");
double result = 1;
if (numberSecond>=0)
{
    for (int i=1; i<=numberSecond; i++)
    {
    result *= numberFirst; 
    }
}
else
{
    for (int j=1; j<= -numberSecond; j++)
    {
    result /= numberFirst; 
    }
}

Console.Write($"{numberFirst} to the {numberSecond}th power is {result}.");

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
