double[] arr = new double[8];
for (int i = 0; i < arr.Length; i++)
   arr[i] = new Random().Next(0,10) +  new Random().NextDouble(); 

double _minValue = arr[0];
double _maxValue = arr[0];
for (int i = 0; i < arr.Length; i++)
{
   if (arr[i] <= _minValue)
      _minValue = arr[i];
    if (arr[i] >= _maxValue)
      _maxValue = arr[i];   
}

void PrintArray(double[] array)
{
    for (int i = 0; i < arr.Length; i++)
       Console.WriteLine(arr[i]);
}

PrintArray(arr);
Console.WriteLine($"Разность между максимальным и минимальным элементами равна: {_maxValue - _minValue}");