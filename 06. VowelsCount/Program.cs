string text = Console.ReadLine();

Console.WriteLine(GetVowelCount(text));
static int GetVowelCount (string text)
{
    int count = 0;
    for (int positions = 0; positions <= text.Length -1; positions++)
    {
        char symbol = text[positions];
        if (symbol == 'A' || symbol == 'a' 
            || symbol == 'E' || symbol == 'e'
            || symbol == 'I' || symbol == 'i' 
            || symbol == 'U' || symbol == 'u' 
            || symbol == 'O' || symbol == 'o')
        {
            count++;
        }

    }

    return count;
}