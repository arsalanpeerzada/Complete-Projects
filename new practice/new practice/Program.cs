using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace new_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamOneName = SetTeamName();
            string teamTwoName = SetTeamName();

            string[] teamOnePlayers = new string[11];
            string[] teamTwoPlayers = new string[11];

            Console.WriteLine("\n     " + teamOneName);
            teamOnePlayers = PopulateTeamPlayers(teamOneName);

            Console.WriteLine("\n     " + teamTwoName);
            teamTwoPlayers = PopulateTeamPlayers(teamTwoName);

            decimal[,] teamOneData = new decimal[11, 4];
            decimal[,] teamTwoData = new decimal[11, 4];

            Console.WriteLine("\n      " + teamOneName);
            teamOneData = PopulateTeamData(teamOnePlayers);



        }

        static string SetTeamName()
        {

            Console.WriteLine("Enter Team Name");
            string a = Console.ReadLine();
            return a;
        }

        static string[] PopulateTeamPlayers(string _name)
        {
            Console.WriteLine("Enter Players names");

            string[] name = new string[11];

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }
            return name;

        }

        static decimal[,] PopulateTeamData(string [] data)
        {
            
            string[] teamOnePlayers = new string[11];
          

            decimal[,] array = new decimal[11, 4];

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j==0)
                    {
                        Console.Write("Enter"+teamOnePlayers[i]+"'s batting average:        ");
                        Console.ReadLine();
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Enter" + teamOnePlayers[i] + "'s bowling average:          ");
                    }
                    else  if (j == 2)
                    {
                        Console.Write("Enter" + teamOnePlayers[i] + "'s strike rate:         ");
                    }
                    else if (j == 3)
                    {
                        Console.Write("Enter" + teamOnePlayers[i] + "'s highest score:         ");
                    }
                   
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return array;

        }
    }
}