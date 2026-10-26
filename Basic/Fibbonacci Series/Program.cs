
int n = 10;
int a = 0, b = 1, c = 0;

Console.WriteLine($"First 10 Fibonacci numbers : ");

for ( int i = 0; i < n; i++)
{
    Console.WriteLine(a + " ");
    c = a + b;
    a = b;
    b = c;
}

