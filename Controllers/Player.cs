using System;
using Commands;

namespace Player
{
    class Player
    {
        public static string Name = "";
        public static string UI()
        {
            string input = Command.CustomConsoleInput($"C:/{Name} > ");
            return input ?? "";
        }


    }
}