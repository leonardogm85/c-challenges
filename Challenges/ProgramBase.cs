using System;
using System.Linq;

namespace Challenges
{
    public abstract class ProgramBase
    {
        protected static void WriteMessage(string message, params object[] arguments)
        {
            ForegroundColor(ConsoleColor.DarkYellow);
            WriteLine(message, arguments);
            NewLine();
        }

        protected static void WriteOptions()
        {
            ForegroundColor(ConsoleColor.DarkYellow);
            WriteEnum<Option>();
            NewLine();
        }

        protected static void WriteError(string message, params object[] arguments)
        {
            ForegroundColor(ConsoleColor.DarkRed);
            WriteLine(message, arguments);
            NewLine();
        }

        protected static string ReadMessage()
        {
            ForegroundColor(ConsoleColor.DarkGreen);
            var input = ReadLine();
            NewLine();

            return input;
        }

        protected static void LastMessages() => ForegroundColor(ConsoleColor.DarkGray);

        protected static void Clear() => Console.Clear();

        protected static void NewLine() => Console.WriteLine();

        protected static string ReadLine() => Console.ReadLine();

        protected static void WriteLine(string message, params object[] arguments) => Console.WriteLine(message, arguments);

        protected static void ForegroundColor(ConsoleColor color) => Console.ForegroundColor = color;

        protected static void WriteEnum<TEnum>() where TEnum : Enum => typeof(TEnum)
            .GetAll<TEnum>()
            .ToList()
            .ForEach(item => WriteLine("{0:d} - {1};", item, item.GetDescription()));
    }
}
