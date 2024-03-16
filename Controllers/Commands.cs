using System;
using System.Text;
using TextAdventure;
using Events;

namespace Commands
{
    class Command
    {
        public static string CustomConsoleInput(string prompt)
        {
            StringBuilder inputBuilder = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(prompt);
            Console.ResetColor();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(); // Move to the next line after Enter is pressed
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && inputBuilder.Length > 0)
                {
                    inputBuilder.Remove(inputBuilder.Length - 1, 1);
                    Console.Write("\b \b"); // Move the cursor back, erase the character, and move the cursor back again
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    inputBuilder.Append(keyInfo.KeyChar);
                    Console.Write(keyInfo.KeyChar);
                }
            }
            return inputBuilder.ToString();
        }
    }
    
    namespace User
    {
        class User_Command
        {
            public static void Input(string command,string state,int Phealth, int Ehealth)
            {
                if(state == "menu")
                {
                    switch (command.ToLower())
                    {
                        case "exit":
                            Event.Exit();
                            break;
                        case "battle":
                            //Declaring a Battle
                            Event.Battle(100, 100);
                            break;
                        default:
                            Console.WriteLine("Reload");
                            Program.Step();
                            break;
                    }
                } else
                {
                    switch (command.ToLower())
                    {
                        case "exit":
                            Event.Exit();
                            break;
                        case "attack":
                            int[] newStats = Attack(Phealth, Ehealth);
                            Event.Battle(newStats[0], newStats[1]);
                            break;
                        case "defend":
                            Defend();
                            Event.Battle(Phealth, Ehealth);
                            break;
                        default:
                            Console.WriteLine("Reload");
                            Event.Battle(Phealth,Ehealth);
                            break;
                    }
                }
            }

            public static int[] Attack(int player,int enemy)
            {
                int PlayerHP = player;
                int EnemyHP = enemy;

                EnemyHP -= 3;

                int[] newStats = { PlayerHP, EnemyHP };
                return newStats;
            }

            public static void Defend()
            {

            }
        }
    }
}