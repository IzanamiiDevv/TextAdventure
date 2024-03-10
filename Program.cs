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
            User_Command.Input(Command.Command.Commanddd());
        }

        public static void Load()
        {
            //Run Once
        }

        public static void Step()
        {
            //Run PerLoad
        }
    }
}

//Fix the Layout and Fix the Command Module