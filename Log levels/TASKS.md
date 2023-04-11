Instructions
In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: "[<LEVEL>]: <MESSAGE>".

There are three different log levels:

INFO
WARNING
ERROR
  
You have three tasks, each of which will take a log line and ask you to do something with it.

Task 1
Get message from a log line

Implement the (static) LogLine.Message() method to return a log line's message:

LogLine.Message("[ERROR]: Invalid operation")
// => "Invalid operation"
Any leading or trailing white space should be removed:

LogLine.Message("[WARNING]:  Disk almost full\r\n")
// => "Disk almost full"

Task 2
Get log level from a log line

Implement the (static) LogLine.LogLevel() method to return a log line's log level, which should be returned in lowercase:

LogLine.LogLevel("[ERROR]: Invalid operation")
// => "error"

Task 3
Reformat a log line

Implement the (static) LogLine.Reformat() method that reformats the log line, putting the message first and the log level after it in parentheses:

LogLine.Reformat("[INFO]: Operation completed")
// => "Operation completed (info)"

How to debug
When a test fails, a message is displayed describing what went wrong and for which input. You can also use the fact that any console output will be shown too. You can write to the console using:

Console.WriteLine("Debug message");
