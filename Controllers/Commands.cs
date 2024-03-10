using System;
using TextAdventure;

namespace User_Commands
{
    class User_Command
    {
        public static void Input(string command)
        {
            switch (command.ToLower())
            {
                case "exit":
                Console.Beep();
                break;
                default:
                Console.WriteLine("Reload");
                Program.Main();
                break;
            }
        }
    }
}