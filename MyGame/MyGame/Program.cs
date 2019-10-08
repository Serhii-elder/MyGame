using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Game newgame = new Game();
            newgame.Start();
        }
    }
}
