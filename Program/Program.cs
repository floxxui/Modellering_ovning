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
                p1Location[i] = GetLocation(i);
            }

            p1.x = p1Location[0];
            p1.y = p1Location[1];
            p1.z = p1Location[2];

            System.Console.WriteLine("Player 1 location: " + p1.x + ", " + p1.y + ", " + p1.z);
            System.Console.WriteLine("Player 2 location: " + p2.x + ", " + p2.y + ", " + p2.z);

            GetDistance( p1Location, p2Location);

            Console.ReadLine();
        }

        static int GetLocation(int i) 
        {
            string[] whichLocation = {"x", "y", "z"};

            System.Console.WriteLine("Write a number for player 1's location " + whichLocation[i]);

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

        static void GetDistance(int[] p1Location, int[] p2Location)
        {
            int[] distance = new int[3];

            for (int i = 0; i < 3; i++)
            {
                if (p1Location[i] >= p2Location[i])
                {
                    distance[i] = p1Location[i] - p2Location[i];
                }
                else if (p1Location[i] <= p2Location[i])
                {
                    distance[i] = p2Location[i] - p1Location[i];
                }
                else
                {
                    distance[i] = 0;
                } 
            }
            Console.WriteLine("The distance between player 1 and player 2 is " + distance[0] + ", " + distance[1] + ", " + distance[2]);
        }
    }
}
