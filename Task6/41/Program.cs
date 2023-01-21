Console.Write("Введите кол-во вводимых чисел: ");
int _countPositiveNumbers = 0;
int _count = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[_count];
Console.Write("Введите число: ");
for (int i = 0; i < arr.Length; i++)
   arr[i] = Convert.ToInt32(Console.ReadLine()); 

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) 
        _countPositiveNumbers++;
}
Console.Write($"Кол-во положительных чисел: {_countPositiveNumbers}");
