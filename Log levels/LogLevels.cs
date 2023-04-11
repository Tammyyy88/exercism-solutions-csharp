using System;

static class LogLine
{
    public static string Message(string logLine)
    {
         int colonIndex = logLine.IndexOf(':');
        if (colonIndex == -1)
            throw new ArgumentException("Invalid log line format");

        // Extract the message after the colon, and remove leading/trailing white spaces
        string message = logLine.Substring(colonIndex + 1).Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
          int bracketIndex = logLine.IndexOf('[');
        if (bracketIndex == -1)
            throw new ArgumentException("Invalid log line format");

        // Find the index of the closing square bracket
        int closingBracketIndex = logLine.IndexOf(']');
        if (closingBracketIndex == -1)
            throw new ArgumentException("Invalid log line format");

        // Extract the log level between the square brackets and convert to lowercase
        string logLevel = logLine.Substring(bracketIndex + 1, closingBracketIndex - bracketIndex - 1).ToLower();
        return logLevel;
    }

    public static string Reformat(string logLine)
    {
        // Extract the log level and message
        string logLevel = LogLevel(logLine);
        string message = Message(logLine);

        // Reformat the log line by putting the message first and the log level in parentheses
        string reformattedLog = $"{message} ({logLevel})";
        return reformattedLog;
    }
}
