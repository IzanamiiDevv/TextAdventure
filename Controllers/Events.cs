using System;
using Commands;

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
    }
}