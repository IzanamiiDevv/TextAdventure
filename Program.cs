using System;
using System.Text;
using Commands.User;
using Startup;
using Commands;
using Player;

namespace TextAdventure
{
    class Program
    {
        public static void Main()
        {
            Load();
        }

        public static void Load()
        {
            //Run Once
            App.Load();
        }

        public static void Step()
        {
            //Run PerLoad
            Console.WriteLine("Menu");
            User_Command.Input(Player.Player.UI(),"menu",0,0);
        }
    }
}
