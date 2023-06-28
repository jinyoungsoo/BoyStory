using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Battle
{
    public int playerhp = 100;
    public int playerdamage = 7;
    public Monster monster;

    public Battle(Monster monster)
    {
        this.monster = monster;
    }

    public void Battlegame()
    {
        Console.WriteLine("전투를 시작합니다");

        while (playerhp > 0 && monster.hp > 0)
        {
            monster.hp -= playerdamage;
            Console.WriteLine("플레이어가 몬스터에게 {0}의 데미지를 입혔습니다", playerdamage);

            if (monster.hp <= 0)
            {
                Console.WriteLine("몬스터를 처치했습니다");
            }

            playerhp -= monster.damage;
            Console.WriteLine("몬스터가 플레이어에게 {0}의 데미지를 입혔습니다", monster.damage);

            if (playerhp <= 0)
            {
                Console.WriteLine("플레이어가 사망했습니다");
                Console.WriteLine("맵으로 돌아갑니다");
            }
        }

        Console.WriteLine("플레이어의 남은 hp: {0}", playerhp);
    }
}

