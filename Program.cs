using System;

namespace AreaOfTriangle

{
    class Triangle
    {
        public int height, width;
        public Triangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
    }
    class FindArea
    {
        class Program
        {
            static void Main(string[] args)
            {
                Triangle tri1 = new Triangle(12, 3);
                Console.WriteLine($"The area of the triangle is {tri1.height * tri1.width / 2}.");
                Console.ReadLine();
            }
        }
    }
}
