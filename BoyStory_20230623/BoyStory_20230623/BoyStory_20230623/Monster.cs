using BoyStory_20230623;
using System;

public class Monster
{
    public virtual int hp { get; set; }
    public virtual int damage { get; set; }

    public virtual void BattleGame(int playerhp, int playerdamage)
    {
        Console.WriteLine("전투를 시작합니다");
        
        while (hp > 0 && playerhp > 0)
        {
            hp -= playerdamage;
            Console.WriteLine("플레이어가 몬스터에게 {0}의 데미지를 입혔습니다", playerdamage);

            if (hp <= 0)
            {
                Console.WriteLine("몬스터를 처치했습니다");
            }

            playerhp -= damage;
            Console.WriteLine("몬스터가 플레이어에게 {0}의 데미지를 입혔습니다", damage);

            if (playerhp <= 0)
            {
                Console.WriteLine("플레이어가 사망했습니다");
                Console.WriteLine("맵으로 돌아갑니다");
            }
        }

        Console.WriteLine("플레이어의 남은 hp: {0}", playerhp);
    }
}