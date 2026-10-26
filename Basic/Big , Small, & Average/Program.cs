
List<int> numbers = new List<int> { 10, 20, 58, 65, 87, 90, 102 };

int maximumNumber = numbers[0];
int minimumNumber = numbers[0];
int sum = 0;
for(int i = 0; i <numbers.Count; i++)
{
    sum += numbers[i];
    if(numbers[i] > maximumNumber) maximumNumber = numbers[i];

    if (numbers[i] < minimumNumber) minimumNumber = numbers[i];

}

double average = (double)sum / numbers.Count;

Console.WriteLine($"Maximun Number: { maximumNumber}");
Console.WriteLine($"Minimum Number :{minimumNumber}");
Console.WriteLine($"Total number of sum: {sum}");
Console.WriteLine($"Average: {average:F2}");

