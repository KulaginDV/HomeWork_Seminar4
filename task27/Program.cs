/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void SummDigits (int number)
{
    int sum = 0;
while (number > 0)
    {
    int result = number % 10;
    number /= 10;
    sum = sum + result;
    }
Console.WriteLine("The sum of the digits: " + sum);
}

Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) SummDigits (num);
else
{
    int num1;
    num1 = num * (-1);
    SummDigits(num1);
}