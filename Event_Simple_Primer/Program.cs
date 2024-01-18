using System;
namespace Event_Simple_Primer
{
    class Programm
    {
        static void Main()
        {
            Human human = new Human(100);
            human.OnChangeHealth += GetHealth;

            human.Health -= 10;
            human.Health -= 100;



        }

        public static void GetHealth(int Health) 
        {
            Console.WriteLine($"Health: {Health}");
        }
    }
}