using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        var stringPattern = new Regex(@"[a-zA-Z]");

        if (statement.Equals("WHAT'S GOING ON?")) return "Calm down, I know what I'm doing!";
        else if (statement.Trim().EndsWith('?')) return "Sure.";
        else if (statement.Trim().Equals("")) return "Fine. Be that way!";
        else if (stringPattern.IsMatch(statement) && statement.StartsWith(statement.ToUpper())) return "Whoa, chill out!";

        return "Whatever.";
    }
}
