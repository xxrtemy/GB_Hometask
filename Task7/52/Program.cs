// Не смог найти решение задачи

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double [] arrAvarage = new double [n];
int sum = 0;
int count = 0;
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

for (int j = 0; j < n; j++)
{
  for (int i = 0; i < m; i++)
    {
      sum += arr[j,i];
      count++;
    }
  for (int k = 0; k < n; k++)
    {
      arrAvarage[k] = sum/count;
    }
    sum = 0;
    count = 0;
}

for (int i = 0; i < arrAvarage.Length; i++)
       Console.Write(arrAvarage[i] + " ");