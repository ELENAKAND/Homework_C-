// На вход 2 числа, является ли одно квадратом другого 
Console.WriteLine("Введите первое число");
string firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr); 
Console.WriteLine("Введите второе число");
string secondNumberStr = Console.ReadLine();
int secondNumber = int.Parse(secondNumberStr);
if (secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine($"Первое число {firstNumber} является квадратом {secondNumber}");
}
if (firstNumber * firstNumber == secondNumber)
{
    Console.WriteLine($"Второе число {secondNumber} является квадратом {firstNumber}");
}
else
{
    Console.WriteLine("Числа не являются квадратом друг друга");
}
/* можно также записать
if (first * first == second || secondNumber * second == first)
|| значит "или"
*/