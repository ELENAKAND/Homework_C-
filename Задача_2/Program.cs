/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int number1 = int.Parse(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int number2 = int.Parse(numberStr2);
if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else 
{
  Console.WriteLine("Числа не равны");  
}
if (number1 > number2)
{
    Console.WriteLine("Наибольшее число " + number1);
}
else 
{
    Console.WriteLine("Наибольшее число " + number2);
}
