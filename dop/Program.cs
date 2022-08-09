int N = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[N, N];
Console.WriteLine();
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        arr[i,j] = new Random().Next(10, 100);
        Console.Write("{0,3}", arr[i,j]);
    }
Console.WriteLine();
}

int[,] trans = new int[N,N];
Console.WriteLine();
for (int k = 0; k < N; k++)
{
    for (int l = 0; l < N; l++)
    {
        trans[k,l] = arr[l, k];
        Console.Write("{0,3}", trans[k,l]);
    }
Console.WriteLine();
}

