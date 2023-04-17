using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongExtreme
{
    internal class ColorfullErraticBall: ErraticBall
    {
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ResetColor();
        }
    }
}
