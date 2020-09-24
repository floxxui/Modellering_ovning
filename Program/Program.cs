using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();            
            Player p2 = new Player();

           Random generator = new Random();

            int[] p1Location = new int[3];
            int[] p2Location = {generator.Next(50), generator.Next(50), generator.Next(50)};

            p2.x = p2Location[0];
            p2.y = p2Location[1];
            p2.z = p2Location[2];

            for (int i = 0; i < 3; i++)
            {
                p1Location[i] = GetLocation();
            }

        }

        static int GetLocation() 
        {
            System.Console.WriteLine("Write a number for p1's location");
            while(true)
            {
                string playerAnswer = Console.ReadLine();
                int p1Location;
                
                bool successful = int.TryParse(playerAnswer, out p1Location);

                if (successful == true)
                {
                    return p1Location;
                }

                else
                {
                    System.Console.WriteLine("Please enter a number for p1's location");
                }
            }
        }
    }
}
