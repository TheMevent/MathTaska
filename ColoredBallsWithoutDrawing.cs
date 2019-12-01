using System;
using System.Collections.Generic;

namespace MyLittleProgram
{
    public class Program
    {
        public static List<Ball> balls;
        public static void Main(string[] args)
        {
            balls = new List<Ball>
            {
                new Ball
                {
                    color = Color.White
                },
                new Ball
                {
                    color = Color.White
                },
                new Ball
                {
                    color = Color.White
                },
                new Ball
                {
                    color = Color.Black
                },
                new Ball
                {
                    color = Color.Black
                }
            };

            var random = new Random();

            var myBall = balls[random.Next(balls.Count)];

            int x = myBall.color == Color.White ? 1 : 0;

            Console.WriteLine($"{x}");
        }
    }

    public class Ball
    {
        public Color color;
    }

    public enum Color
    {
        White,
        Black
    }
}
