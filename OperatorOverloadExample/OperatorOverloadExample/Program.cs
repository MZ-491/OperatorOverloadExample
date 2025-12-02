using System;

namespace ConsoleApp
{
    public class Rectangle
    {
        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static Rectangle operator +(Rectangle react1, Rectangle react2)
        {
            Rectangle ReactResult = new Rectangle(react1.Width + react2.Width, react1.Height + react2.Height);

            return ReactResult;
        }

    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle react1 = new Rectangle(12, 5);
            Rectangle react2 = new Rectangle(3, 7);

            Rectangle ReactResult = react1 + react2;

            Console.WriteLine($"'react1(12,10)' + 'react2(5,2)' = 'rectResult({ReactResult.Width},{ReactResult.Height})'");

            Console.ReadKey();
        }
    }
}