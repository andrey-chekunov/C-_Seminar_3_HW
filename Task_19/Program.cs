/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

Console.Write("Enter a five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = 0;
int copy = n;

if (n < 10000 || n > 99999)
{
    Console.Write("This is not a five-digit number!");
}
else
{
    while (copy > 0)
    {
    n2 = n2 * 10 + copy % 10;
    copy = copy / 10;
    }


    if (n==n2)
    {
        Console.WriteLine("That number is a palindrome.");
    }
    else
    {
        Console.WriteLine("That number is not a palindrome.");
    }
}
