double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (k2 == k1 && b1 != b2) 
Console.WriteLine("Lines don't intersect");
else if (k2 == k1 && b1 == b2) 
Console.WriteLine("Identical lines");
else if (k2 != k1 && b1 == b2) 
Console.WriteLine("Intersection point: (0;" + b1 + ')');
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.WriteLine("Intersection point: (" + x + ";" + y + ")");
}