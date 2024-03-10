using System;
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
        return Console.ReadLine() ?? "";
    }
}
}