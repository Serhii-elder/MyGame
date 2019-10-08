using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    abstract class Mobs
    {
        string name;
        int health;
        int damage;
    }

    class Wolf : Mobs
    {
        string name;
        int health;
        int damage;

        public Wolf()
        {
            name = "Black wolf";       
        }

        public void Atac()
        {

        }
    }
}
