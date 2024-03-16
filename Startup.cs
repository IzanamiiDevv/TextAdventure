using System;
using Player;
using Events;
using TextAdventure;

namespace Startup
{
    class App
    {
        public static string start = "start";
        public static string exit = "exit";

        public static void Load()
        {
            OnLoad();
        }
        public static void OnLoad(){
            Console.Title = "TextAdventure";
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Text Adventure");
            Console.ResetColor();
            Console.Write("!");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"          {start}         ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"          {exit}         ");
            Console.ResetColor();
            Console.WriteLine("--------------------------");
            PlayerMenu();
        }
        public static void OnStart()
        {
            Console.WriteLine("Enter Your Player Name");
            Player.Player.Name = Console.ReadLine() ?? "Player";
            Program.Step();
        }

        public static void PlayerMenu()
        {
            Console.WriteLine("Enter The Command Above");
            string input = Console.ReadLine() ?? "";
            if(input.ToLower() == start)
            {
                OnStart();

            }else
            {
                Event.Exit();
            }
        }
    }
}