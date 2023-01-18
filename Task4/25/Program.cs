int Degree(int number1, int number2)
{
int _degree = 1;
for(int i = 1; i <= number2; i++)
{
    _degree *= number1;
}
return _degree;
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(A, B));