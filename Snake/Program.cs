using System;
using System.Threading;

namespace Snake
{
    internal static class Program
    {
        private static void Main()
        {

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw(ConsoleColor.Red);


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER!\r\nTry again...");
                    Thread.Sleep(1000);
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw(ConsoleColor.Red);
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Move(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
