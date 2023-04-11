using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrEmpty(statement))
        {
            return "Fine. Be that way!";
        }
        else if (statement.EndsWith("?") && HasLetters(statement) && IsShouting(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.EndsWith("?"))
        {
            return "Sure.";
        }
        else if (IsShouting(statement))
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }

    private static bool HasLetters(string statement)
    {
        foreach (char c in statement)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsShouting(string statement)
    {
        bool hasLetters = false;
        bool isUpperCase = true;

        foreach (char c in statement)
        {
            if (char.IsLetter(c))
            {
                hasLetters = true;
                if (!char.IsUpper(c))
                {
                    isUpperCase = false;
                    break;
                }
            }
        }

        return hasLetters && isUpperCase;
    }
}
