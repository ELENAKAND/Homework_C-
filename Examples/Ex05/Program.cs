// Программа принимает число, проверяет кратно ли оно одновременно 7 и 23 
Console.WriteLine("Введите  число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr); //спарсили входное число 
int remainder1 = number % 7;
int remainder2 = number % 23;
if (remainder1 == 0 && remainder2 == 0) 
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
