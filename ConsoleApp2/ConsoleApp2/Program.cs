using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string games = "GAMES", wins = "WINS", perfectPlay = "PERFECTPLAY", maxCombo = "MAXCOMBO", rate = "RATE";
            string mg = "GRANDMASTER", m = "MASTER", s2 = "SILVER II";
            string lobby = "LOBBY", history = "HISTORY", leaderboard = "LEADERBOARD";
            string rank = "RANK", player = "PLAYER", tier = "TIER", lp = "LP";
            double ratePoint = 99.29;
            int nGames = 166, nWins = 123, nPerfectPlay = 221, nMaxCombo = 176;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃  {leaderboard}                                                                   {lobby} {history} {leaderboard}  ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ {rank}   {player}              {games}  {wins}  {tier}           {lp}       ┃  USER INFORMATION");
            Console.WriteLine($"┃  1     □ 냄시               {nGames}    {nWins}  {mg}    568      ┃  ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"┃  2     □ 도라에몽이야뭐야   176    114  {mg}    356      ┃                            {games}");
            Console.WriteLine($"┃  3     □ C H E P Y           69     55  {mg}    355      ┃         ┏━━━━━━━┓                  {nGames}");
            Console.WriteLine($"┃  4     □ 루니아나           150     95  {mg}    295      ┃         ┃       ┃          {wins}");
            Console.WriteLine($"┃  5     □ 신즈               113     77  {mg}    254      ┃         ┃       ┃                  {nWins}");
            Console.WriteLine($"┃  6     □ 즈나루             120     80  {m}         240      ┃         ┃       ┃          {perfectPlay}");
            Console.WriteLine($"┃  7     □ Espresso           118     76  {m}         181      ┃         ┗━━━━━━━┛                  {nPerfectPlay}");
            Console.WriteLine($"┃ 7294   □ broodroost...       8      6   {s2}       72      ┃        {mg}         {maxCombo}");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛           냄 시                    {nMaxCombo}");
            Console.WriteLine($"                                                                                               {rate}");
            Console.WriteLine($"                                                                                                     {ratePoint}");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                                                    START                                                  ┃");
            Console.WriteLine("┃                                                   PRESS F5                                                ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
