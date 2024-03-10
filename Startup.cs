using System;

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
            Console.WriteLine("The Program is Start");
        }
    }
}