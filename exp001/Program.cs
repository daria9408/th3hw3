//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int a;
a = 12821;

int num1;
num1 = a / 10000;

int num2;
num2 = a / 1000 % 10;

int num3;
num3 = a % 10;

int num4;
num4 = a / 10 % 10;

if(num1 == num3)
{
    if(num2 == num4)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нет");
}