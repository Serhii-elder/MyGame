using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Game
    {
        Player player;
        public void Start()
        {
            player = new Player();
            Console.Clear();
            Console.WriteLine("\n\tTab: show info player!");
            Console.WriteLine("\n\t1: hanting!");
            while (true)
            {
                if (GetButtom() == ConsoleKey.Tab)
                    player.Show();
                else if (GetButtom() == ConsoleKey.D1)
                    hunting();
            }
        }
        private void hunting()
        {
            Console.Clear();
            Console.WriteLine("\n\t1: wolf\n\t2: robber");
            if (GetButtom() == ConsoleKey.D1)
            {
                Batle(player, mobs);
            }
        }

        private void Batle(Player player,Mobs mobs)
        {

        }
        public static ConsoleKey GetButtom() {
            ConsoleKey but = Console.ReadKey().Key;
            return but;
        }   
    }
}
