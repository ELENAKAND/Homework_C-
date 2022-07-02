// Проверка на ввод пользователем неадекватной информации

int GetNumber(string message);
{

    result = 0;
    while (true)
    {
        Console.WriteLine("Введите число");
        if (int.TryParse(Console.ReadLine(), out int result));
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("Это не число. Введите число");
        } 
        
    }   
    return result;

}
