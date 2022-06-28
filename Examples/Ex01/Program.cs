// Функция поиска max в массиве 
int [] array = {12, 21, 33, 54, 53, 26, 97, 98};
int n = array.Length;
int find = 54;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); 
    }
    index++;
   
    
}
