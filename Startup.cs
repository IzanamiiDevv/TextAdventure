using System;
using Player;

namespace Startup
{
    class App
    {
        public static void Load()
        {
            OnLoad();
            OnStart();
        }
        public static void OnLoad(){
            Console.Title = "TextAdventure";
        }
        public static void OnStart()
        {
            Console.WriteLine("Enter Your Player Name");
            Player.Player.Name = Console.ReadLine() ?? "Player";
        }
    }
}