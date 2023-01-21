Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

if ((k1==k2)&&(b1==b2))
    Console.Write("Одна из прямых лежит на другой");
else if (k1==k2)
    Console.Write("Прямые параллельны и не пересекаются");
    else
        {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
        }
