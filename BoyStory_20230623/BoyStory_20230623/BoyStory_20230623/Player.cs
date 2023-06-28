using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class Player
    {
        public int playerdamage = 7;
        public int playerhp = 100;
        public int statCount = 0;

        public int exppoints = 0;
        public int statpointthreshold = 3;

        public void Status()
        {
            Console.CursorVisible = false;

            for (int i = 1; exppoints <= 10; i++)
            {
                exppoints++;
                Console.WriteLine("경험치를 얻었습니다!");

                if (exppoints % statpointthreshold == 0)
                {
                    playerhp += 10;
                    Console.WriteLine("플레이어 체력이 10 증가했습니다.");
                }

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write("현재 플레이어 체력: " + playerhp + " ");
            }

            Console.WriteLine();
            Console.CursorVisible = true;
            Console.WriteLine("프로그램이 종료되었습니다.");
        }
    }






    // 스탯을 얻을 때마다 statCount 증가
    // 스탯을 3 얻을 때마다 playerHp 증가
    //for (int i = 1; i <= 10; i++) // 10번 반복
    //{
    //    statCount++;
    //    Console.WriteLine("체력 스탯을 얻었습니다!");

    //    if (statCount % 3 == 0) // statCount가 3의 배수인 경우
    //    {
    //        playerHp += 10;
    //        Console.WriteLine("플레이어 체력이 10 증가했습니다.");
    //    }

    //    Console.WriteLine("현재 플레이어 체력: " + playerHp);
    //    Console.WriteLine();



}
    

    

