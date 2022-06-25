/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);
Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine();
int number3 = int.Parse(numberStr3);
int numberMax = number1;
if (number2 > numberMax)
{
    numberMax = number2;
}
if (number3 > numberMax)
{
    numberMax = number3;
}
Console.WriteLine("Максимальное число " + numberMax);

