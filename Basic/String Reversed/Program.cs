
static string ReversedString(string text)
{
    string reversed = "";
    for(int i = text.Length - 1;i >= 0; i--)
    {
        reversed += text[i];
    }
    return reversed;
}

static bool Ispalindrome(string text)
{
    return text == ReversedString(text);
}

Console.WriteLine(ReversedString("hello"));
Console.WriteLine(Ispalindrome("madam"));
Console.WriteLine(Ispalindrome("hello"));

