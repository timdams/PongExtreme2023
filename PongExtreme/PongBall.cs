namespace PongExtreme
{
    internal class PongBall
    {
        public PongBall()
        {
            X = rng.Next(3, WorldWidth - 2);
            Y = rng.Next(3, WorldHeight - 2);
            VectorX = rng.Next(-2, 3);
            VectorY = rng.Next(-2, 3);
        }

        public virtual char ConsoleChar
        {
            get
            {
                return 'O';
            }
        }

        static protected Random rng = new Random();
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        private int x = 0;
        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    x = 0;
                else if (value >= WorldWidth)
                    x = WorldWidth - 1;
                else
                    x = value;
            }
        }
        private int y = 0;
        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    y = 0;
                else if (value >= WorldHeight)
                    y = WorldHeight - 1;
                else
                    y = value;
            }
        }

        public static int WorldWidth { get; set; }
        public static int WorldHeight { get; set; }

        public virtual void Update()
        {
            if (X + VectorX >= WorldWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX;

            if (Y + VectorY >= WorldHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY;
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(ConsoleChar);
        }
    }
}