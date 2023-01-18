
int _sum = 0;
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
   arr[i] = new Random().Next(0,20); 

for (int i = 0; i < arr.Length; i+=2)
{
    _sum += arr[i]; 
}

void PrintArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
       Console.WriteLine(arr[i]);
}

PrintArray(arr);
Console.WriteLine($"Сумма нечетных элементов массива равна: {_sum}");