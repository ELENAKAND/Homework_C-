Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine(number);
int firstNumber = number /100; //выделение первой цифр
int secondNumber = (number/10)%10; //выделение второй цифры
int thirdNumber = number%10; //выделение третьей цифры
Console.WriteLine("Полученное число {0}{1}", firstNumber, thirdNumber);




