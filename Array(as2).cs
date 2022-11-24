using System;

namespace ArrayAssignment_p2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of values : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[number];
            int count = 1;       
            for (int num = 0; num <number; num++)
            {
                Console.Write($"Enter Student {count} Name : ");
                names[num]=Console.ReadLine();
                count++;
            }
             
            Console.WriteLine();
            Console.WriteLine("All Students ");
            Console.Write("No     ");
            Console.Write("    Name");
            Console.WriteLine();
            Console.Write("===");
            Console.Write("    ===========");
            Console.WriteLine();
            for(int n = 0;n<names.Length;n++)
            {
                Console.WriteLine( n+1 + $"     {names[n]}");
                
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();

        }
    }
}
