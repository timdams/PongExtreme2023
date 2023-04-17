namespace PongExtreme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PongBall.WorldHeight = Console.WindowHeight;
            PongBall.WorldWidth = Console.WindowWidth;

            Console.CursorVisible = false;

            List<PongBall> allBalls = new List<PongBall>();
            
            allBalls.Add(new PongBall());
            allBalls.Add(new ErraticBall());
            allBalls.Add(new ColorfullErraticBall());
            allBalls.Add(new ColorfullErraticBall());
            allBalls.Add(new ColorfullErraticBall());

            allBalls.Add(new TeleportBall());
            while (true)
            {
                foreach (var ball in allBalls)
                {
                    ball.Update();
                }

                foreach (var ball in allBalls)
                {
                    ball.Draw();
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}