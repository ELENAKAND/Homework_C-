// На ввод случайное двузначное число - 
// вывод наибольшей по значению цифры этого числа
Random rnd = new Random(); //создали новый рандомный массив
int number = rnd.Next(10, 100); //ввели переменную числа из массива
Console.WriteLine(number);
int firstNumber = number/10; //выделили первую цифру 2знач числа
int secondNumber = number%10; //выделили вторую цифру 2знач числа
if(firstNumber > secondNumber)
    Console.WriteLine(firstNumber);
if(secondNumber > firstNumber)
    Console.WriteLine(secondNumber);
if(firstNumber == secondNumber)
    Console.WriteLine("Значения равны");
    
