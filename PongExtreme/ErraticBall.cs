using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongExtreme
{
    internal class ErraticBall: PongBall
    {
        public override char ConsoleChar
        {
            get
            {
                return 'P';
            }
        }

        public override void Update()
        {
            if(rng.Next(0,30)==0)  //1 kans op 30 dat dit zal gebeuren
            {
                //vector veranderen

                VectorX = rng.Next(-2, 3);
                VectorY = rng.Next(-2, 3);
            }

            base.Update();

        }
    }
}
