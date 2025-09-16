static class LogLine
{
    public static string Message(string logLine)
    {
        int pos = logLine.IndexOf(":"); 
        string sol = logLine.Substring(pos + 1).Trim();
        return sol;
    }

    public static string LogLevel(string logLine)
    {
        int pos = logLine.IndexOf("]");
        string sol = logLine.Substring(1,pos -1).ToLower();
        return sol;
    }

    public static string Reformat(string logLine)
    {
        string level = LogLevel(logLine);
        string message = Message(logLine);

        return $"{message} ({level})";
    }
}
