
double[,] arr = new double[3,4];
for (int i = 0; i < 3; i++)
{
   for (int j = 0; j < 4; j++)
    {
        arr[i,j] = new Random().Next(0,10) +  new Random().NextDouble(); 
        Console.Write(arr[i,j] + " ");
    }
  Console.WriteLine();
}