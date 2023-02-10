/*
 * Clark Comstock
 * 2/10/2023
 * Week 4 methods program
 * */

using System.ComponentModel.DataAnnotations;

namespace Week_4_Methods_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("Default constructor: below are the results of predetermined values");
            Console.WriteLine("The length is: " + r1.length);
            Console.WriteLine("The width is: " + r1.width);
            Console.WriteLine("The area is: " + Utility.Area(r1.length, r1.width));
            Console.WriteLine("The perimeter is: " + Utility.Perimeter(r1.length, r1.width));
            Console.WriteLine("--------------END DEFAULT TEST---------------");

            Rectangle r2 = new Rectangle();
            Console.WriteLine("\nYour turn, please enter a valid length: ");
            r2.length = Convert.ToInt32(Console.ReadLine());
            while (r2.length <= 0)
            {
                Console.WriteLine("You did not enter a valid length, please enter a length greater than 0: ");
                r2.length = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Now, please enter a valid width: ");
            r2.width = Convert.ToInt32(Console.ReadLine());
            while (r2.width <= 0)
            {
                Console.WriteLine("You did not enter a valid width, please enter a width greater than 0: ");
                r2.width = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nHere are the results of your input: ");
            Console.WriteLine("The length is: " + r2.length);
            Console.WriteLine("The width is: " + r2.width);
            Console.WriteLine("The area is: " + Utility.Area(r2.length, r2.width));
            Console.WriteLine("The perimeter is: " + Utility.Perimeter(r2.length, r2.width));
            Console.WriteLine("---------------END OF USER INPUT---------------");

            Console.WriteLine("\nNow we're gonna see a randomly generated rectangle:");
            Utility.MakeRectangle(1, 100, out r2.length, out r2.width);
            Console.WriteLine("The length is: " + r2.length);
            Console.WriteLine("The width is: " + r2.width);
            Console.WriteLine("The area is: " + Utility.Area(r2.length, r2.width));
            Console.WriteLine("The perimeter is: " + Utility.Perimeter(r2.length, r2.width));
            Console.WriteLine("---------------END OF PROGRAM---------------");
        }
    }

    class Rectangle
    {
        public int length = 0;
        public int width = 0;
        public Rectangle()
        {
            length = 10;
            width = 5;
        }
    }
    public class Utility
    {
        static public int Area(int l, int w)
        {
            return l * w;
        }
        static public int Perimeter(int l, int w)
        {
            return 2 * (l + w);
        }
        static public void MakeRectangle(int min, int max, out int l, out int w)
        {
            Random r = new Random();
            int n1 = r.Next(min, max);
            l = n1;
            int n2 = r.Next(min, max);
            w = n2;
        }
    }
}