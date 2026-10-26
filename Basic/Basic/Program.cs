
// 1 - 100  even number
int evenCount = 0;
for(int i = 1;i <= 100; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
        evenCount++;
    }
}

Console.WriteLine($"Even Number 1 - 100 : {evenCount}");
