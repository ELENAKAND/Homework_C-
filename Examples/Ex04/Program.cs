// На вход два числа, на выход является ли второе число кратным первому
//int[] array = array.Length();
Console.WriteLine("Введите первое число");
string firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr); 
Console.WriteLine("Введите второе число");
string secondNumberStr = Console.ReadLine();
int secondNumber = int.Parse(secondNumberStr); 
int result = firstNumber % secondNumber; //переменная для вывода в ответ остатка 
if(result == 0)  //значит делится без остатка 
{
    Console.WriteLine("Кратно");
}

else // если делится с отстатком 
{
            Console.WriteLine("Не кратно. Остаток {0}", result);
}






