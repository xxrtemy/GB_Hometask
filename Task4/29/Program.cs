﻿int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
   arr[i] = new Random().Next(0,100); 

void PrintArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
       Console.WriteLine(arr[i]);
}

PrintArray(arr);

