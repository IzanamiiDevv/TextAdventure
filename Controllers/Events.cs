using System;
using Commands;
using Commands.User;
using Player;

namespace Events
{
    class Event
    {
        public static void Exit()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Program was Ended by User");
            Console.ResetColor();
        }

        public static void Battle(int enemyHealth, int playerHealth)
        {
            //Loop for Battle
            Console.WriteLine("Battle");
            string state = "battle";


            //UI for Status
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Player.Player.Name}:{playerHealth}");
            Console.ResetColor();
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"Enemy:{enemyHealth}");
            Console.ResetColor();
            Console.WriteLine();

            //Command Layout
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("   Attack");
            Console.ResetColor();
            Console.Write("      ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Defend");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            User_Command.Input(Player.Player.UI(),state,playerHealth,enemyHealth);
        }
    }
}