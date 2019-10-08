using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Player
    {
        
        public string name;
        public int health;
        public int maxhealth;
        public int power;
        public int coins;

        public Player()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            health = 100;
            maxhealth = 100;
            power = 10;
            coins = 0;
        }
        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("******************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Name\t{name}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health\t{health}/{maxhealth}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Power\t{power}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Coins\t{coins}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("******************");
            Console.ResetColor();
        }

    }
}
