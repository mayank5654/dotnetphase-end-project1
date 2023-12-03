using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPace_Cricket_Academy
{
    internal class OneDayTeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public int Capacity { get; }

        public OneDayTeam()
        {
            Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public void Remove(int playerId)
        {
            if (oneDayTeam.Exists(player => player.PlayerID == playerId))
            {
                oneDayTeam.RemoveAll(player => player.PlayerID == playerId);
                Console.WriteLine("Player removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found in the list!");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(player => player.PlayerID == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(player => player.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
