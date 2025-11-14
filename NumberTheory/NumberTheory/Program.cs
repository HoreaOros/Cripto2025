

Console.WriteLine(ModularInverse(7, 26));

int ModularInverse(int a, int n)
{
    for (int x = 1; x < n; x++)
        if ((a * x) % n == 1)
            return x;
    return -1;
}