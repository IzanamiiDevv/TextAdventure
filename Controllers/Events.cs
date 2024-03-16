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

        public static void Battle(int playerHealth, int enemyHealth)
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


namespace Enemy
{
    class Enemy
    {
        public static int[] Turn(int player, int enemy)
        {
            Random random = new Random();

            if(random.Next(0, 2) == 0)
            {
                return Attack(player, enemy);
            }

            return Defend(player, enemy);
        }

        public static int[] Attack(int player, int enemy)
        {
            int PlayerHP = player;
            int EnemyHP = enemy;
            Random random = new Random();

            PlayerHP -= (random.Next(1, 11) == 1) ? 9 : 3;
            Console.WriteLine("Enemy Attacked");
            int[] newState = { PlayerHP, EnemyHP };
            return newState;
        }

        public static int[] Defend(int player, int enemy)
        {
            int PlayerHP = player;
            int EnemyHP = enemy;
            Random random = new Random();

            EnemyHP += (random.Next(1, 11) == 1) ? 5 : 2;
            Console.WriteLine("Enemy Defend");
            int[] newState = { player, enemy};
            return newState;
        }
    }
}