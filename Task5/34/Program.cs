int _count = 0;
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
   arr[i] = new Random().Next(100,999); 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
       _count++;
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
       Console.WriteLine(arr[i]);
}

PrintArray(arr);
Console.WriteLine($"В данном массиве {_count} четных элемента");
