
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("게임 시작");

            OneDay myOneDay = new OneDay();
            myOneDay.GameStoryOneDay();

            SecondDay mySecondDay = new SecondDay();
            mySecondDay.GameStorySecondDay();


            Shop myShop = new Shop();
            myShop.InitializeShop();
            myShop.StartShopping();


            Battle battle = new Battle(new Wolf());
            battle.Battlegame();

            Player player = new Player();
            player.Status();

        }
    }
}

