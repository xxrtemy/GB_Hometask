
Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
   for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(0,10);
        Console.Write(arr[i,j] + " ");
    }
  Console.WriteLine();
}

Console.Write("Введите строку желаемого элемента: ");
int _string = Convert.ToInt32(Console.ReadLine());
if (_string > m)
    Console.WriteLine("Введенная строка не существует в массиве.");
else 
{
    Console.Write("Введите столбец желаемого элемента: ");
    int _column = Convert.ToInt32(Console.ReadLine());
    if (_column > n )
        Console.WriteLine("Введенный столбец не существует в массиве.");
    else
        {
            _column--;
            _string--;
            Console.WriteLine($"Ваш элемент: {arr[_string,_column]}");
  
        }
}


