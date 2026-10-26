
Console.Write("Enter a word : ");
string word = Console.ReadLine()?.ToLower() ?? "";

int vowel = 0;
for (int i = 0; i < word.Length; i++)
{
    if ("aeiou".Contains(word[i]))
    {
        vowel++;
    }
}
Console.WriteLine($"text : {word}");
Console.WriteLine($"Total Vowel : {vowel}");