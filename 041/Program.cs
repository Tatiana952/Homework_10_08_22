int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int j = 0;
int[] arr = new int [m];
for (int i = 0 ; i < m; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0 ) j++; 
}
Console.WriteLine();
Console.WriteLine(j);
