int GetFirstNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.Clear();
Console.WriteLine("Вы ввели не число. Введите корректное число.");
}
}

return result;
}
int number = GetFirstNumber("Введите число");
