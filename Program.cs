using System;
using System.Text;
using User_Commands;
using Startup;

namespace TextAdventure
{
    class Program
    {
        public static void Main()
        {
            App.Load();
        App.OnStart();
        Console.WriteLine("Hello World");
        User_Command.Input(Command());
    }

    private static string Command()
    {
        string input = CustomConsoleInput("➜ ");
        return input ?? "";
    }

    static string CustomConsoleInput(string prompt)
    {
        StringBuilder inputBuilder = new StringBuilder();
        Console.Write(prompt);

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine(); // Move to the next line after Enter is pressed
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Backspace && inputBuilder.Length > 0)
            {
                inputBuilder.Remove(inputBuilder.Length - 1, 1);
                Console.Write("\b \b"); // Move the cursor back, erase the character, and move the cursor back again
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                inputBuilder.Append(keyInfo.KeyChar);
                Console.Write(keyInfo.KeyChar);
            }
        }

        return inputBuilder.ToString();
    }
    }
}