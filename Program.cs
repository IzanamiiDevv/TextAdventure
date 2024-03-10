using System;
using System.Text;
using Command.User;
using Startup;
using Command;

namespace TextAdventure
{
    class Program
    {
        public static void Main()
        {
            App.Load();
            App.OnStart();
            Console.WriteLine("Hello World");
            User_Command.Input(Commanddd());
            Command.Command.CustomConsoleInput("");
        }

    private static string Commanddd()
    {
        // string input = CustomConsoleInput("➜ ");
        // return input ?? "";
        return "";
    }
    }
}

//Fix the Layout and Fix the Command Module