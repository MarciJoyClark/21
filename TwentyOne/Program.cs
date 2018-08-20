using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Twenty One! What's your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money do you want to play with today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}, would you like to begin?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer== "Yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Feel free to play more! Bye bye!");
            Console.Read();
        }
    }
}
