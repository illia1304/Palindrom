int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPalindrom(x));

bool isPalindrom(int number)
{
    string s = number.ToString();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != s[s.Length - 1 - i])
            return false;
    }
    return true;
}