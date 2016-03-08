using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelZombieMarketing
{
    class Program
    {
        static void Main(string[] args)
        {
            ZombieSalesmanInvasion();
        }

        static void ZombieSalesmanInvasion()
        {
            //Variables
            Random rnd = new Random();
            int zombieSalesMan = 1, humans = 100, creatureSum = (zombieSalesMan + humans), turns = 0/*, visits = 0 variable for counting visits*/;
            //Loop while there's humans left
            do
            {
                //Zombie salesman/salesmen visit house/houses
                for (int i = 0; i < zombieSalesMan; i++)
                {
                    //if there's a human remove it
                    if (rnd.Next(1, creatureSum) <= humans)
                        humans--;
                    //stop visiting houses if there's no humans left
                    if (humans == 0)
                        break;
                    /*
                    //if there's humans left keep counting visits
                    if (humans > 0)
                        visits++;
                    //else stop counting visits
                    else
                        break;
                     */
                }
                //add new zombie salesman/salesmen by substracting remaining humans from the total sum of creatures (humans and zombies)
                zombieSalesMan = creatureSum - humans;
                //count the turns
                turns++;
                //write result for each turn
            } while (humans > 0);
                WriteStats(zombieSalesMan, turns, humans);
        }

        //Method for writing statistics to the console
        static void WriteStats(int zombieSalesMan, /*int visits,*/ int turns, int humans)
        {
            Console.Clear();
            Console.WriteLine($"Zombies: {zombieSalesMan}");
            Console.WriteLine($"Humans: {humans}");
            //Console.WriteLine($"Visits {visits}"); for displaying visits made by zombies
            Console.WriteLine($"Turn: {turns}");
            Console.ReadKey();
        }
    }
}
