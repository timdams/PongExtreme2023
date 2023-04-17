using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PongExtreme
{
    internal class TeleportBall:ErraticBall
    {
        const int TELEPORTDISTANCE = 30;
        public override void Update()
        {
            base.Update();

            if(rng.Next(0,30)==0)
            {
                X = rng.Next(X - TELEPORTDISTANCE, X + TELEPORTDISTANCE+1);

                Y = rng.Next(Y - TELEPORTDISTANCE, Y + TELEPORTDISTANCE+1);

                even = !even;
            }
        }

        public override char ConsoleChar
        {
            get
            {
                return 'T';
            }
        }

        private bool even = false;
        public override void Draw()
        {
            if(even)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            

            base.Draw();

            Console.ResetColor();
        }
    }
}
