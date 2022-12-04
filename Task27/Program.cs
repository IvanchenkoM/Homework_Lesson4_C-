// Напишите программу, которая принимает на вход число и выдает сумму чисел в числе.
int number = ReadInt("Enter the number: ");
int temp=number;
int sum=0;
int i=0;
while (temp>0)
{
    sum +=temp%10;
    temp/=10;
    i++;
}
Console.Write($"The sum of the numbers in {number} is {sum}.");
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}