static class LogLine
{
    public static string Message(string logLine)
    {
        return $"{logLine.Split(':')[1].Trim()}";
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(']')[0].Substring(1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        var splitedString = logLine.Split(':');
        var logLevel = splitedString[0].Substring(1, splitedString[0].Length - 2);
        var fortmatedString = $"{splitedString[1].Trim()} ({logLevel.ToLower()})";
        return fortmatedString;
    }
}
