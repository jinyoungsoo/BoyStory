using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class OneDay
    {

        public SecondDay mySecondDay;

        

        public void GameStoryOneDay()
        {

            Console.WriteLine("\"카메룬 호수에는 악마가 살고 있어요\"");
            Console.WriteLine("");
            Console.WriteLine("당신은 방에서 유모의 이야기를 듣고 있었다.");
            Console.WriteLine("카메룬 호수는 집 뒤쪽에 있는 숲의 끝에 있었고,");
            Console.WriteLine("썩은 수초가 뒤엉켜 있으며 태양빛 조차 들지 않는 그늘진 늪. 즉, 죽은 호수였다.");
            Console.WriteLine(" ");
            Console.WriteLine("\"그러니까 카메론 호수에는 절대 가면 안되요!\"");
            Console.WriteLine("당신의 유모는 당신한테 그렇게 말하고 있었다.");
            Console.WriteLine(" ");
            Console.WriteLine("\"아이참, 듣고 계신 건가요?\"");
            Console.WriteLine(" ");
            Console.WriteLine("그렇게 유모는 당신한테 말했다");
            Console.WriteLine(" ");
            Console.WriteLine("당신은 유모가 하는 말에 반신반의했지만 반문하면 유모가 화를 낼 것이기에");
            Console.WriteLine("조용히 듣고 있었다");
            Console.WriteLine(" ");
            Console.WriteLine("그렇게 열심히 말을 하던 유모는 시간이 되었는지");
            Console.WriteLine("\"그럼 안녕히 주무세요.\"");
            Console.WriteLine("라는 말을 남기고는 당신의 방을 나갔다.");
            Console.WriteLine(" ");
            Console.WriteLine("당신은 유모가 말하던 카메룬 호수가 문득 궁금해졌다.");
            Console.WriteLine(" ");


            Console.WriteLine("1. 호수로 가기 위해 숲으로 향한다");
            Console.WriteLine("2. 방에서 수면을 취한다");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("당신은 호수로 가기 위해 숲으로 향한다");
                    break;
                case "2":
                    Console.WriteLine("당신은 방에서 수면을 취한다");
                    SecondDay mySecondDay = new SecondDay();
                    mySecondDay.GameStorySecondDay();
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("당신은 방에서 램프를 가방에 넣고 단검을 허리에 찬 후 방에 있는 창문을 연 후");
            Console.WriteLine("창문 밖으로 밧줄을 내린 후 밧줄을 타고 당신은 집 밖으로 나왔다.");
            Console.WriteLine("하지만 당신은 숲을 가기 위해서는 경비병의 눈을 피해 집 뒤쪽의 숲의 입구로 향해야 한다.\r\n");
            Console.WriteLine("");


            Console.WriteLine("1.당신은 옆의 담장으로 향한다");
            Console.WriteLine("2.당신은 뒷문으로 향한다");


            string choice2 = Console.ReadLine();

            switch (choice2)
            {
                case "1":
                    Console.WriteLine("당신은 옆의 담장으로 향한다");
                    break;
                case "2":
                    Console.WriteLine("당신은 뒷문으로 향한다");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }


            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("다행히 옆의 담장에는 경비병이 없었고");
            Console.WriteLine("당신은 담장을 넘고 집 뒤쪽의 숲으로 향하게 되었다");


            Console.WriteLine("당신은 10분 정도를 걸어서 숲의 입구로 보이는 곳에 도착하였다.");
            Console.WriteLine("밤이라 그런지 숲은 어둠에 둘러싸여 숲 안의 모습은 전혀 보이지 않았다.");
            Console.WriteLine("");
            Console.WriteLine("당신은 방을 나서기 전에 준비했던 가방에서 램프를 꺼내 들었고");
            Console.WriteLine("램프를 켜서 숲을 비추었다.");
            Console.WriteLine("");
            Console.WriteLine("하지만 대략의 윤곽만 보일 뿐...");
            Console.WriteLine("숲의 안쪽은 제대로 보이지 않았다.");
            Console.WriteLine("문득 당신은 공포심을 느꼈다.");
            Console.WriteLine("");

            Console.WriteLine("1.당신은 공포심에 굴복해 집으로 다시 돌아간다");
            Console.WriteLine("2.당신은 공포심을 느끼면서도 숲으로 나아간다");

            string choice3 = Console.ReadLine();

            switch (choice3)
            {
                case "1":
                    Console.WriteLine("당신은 공포심에 굴복해 집으로 다시 돌아간다");
                    break;
                case "2":
                    Console.WriteLine("당신은 공포심을 느끼면서도 숲으로 나아간다");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }


            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("당신은 램프를 켜고 숲 안으로 향한다");
            Console.WriteLine("");
            Console.WriteLine("당신은 램프의 불빛에 의존해 숲의 안쪽으로 하염 없이 향했으며");
            Console.WriteLine("");
            Console.WriteLine("그렇게 램프의 불빛에 의존하며 안쪽으로 향한 지 20여분 정도가 지날 무렵");
            Console.WriteLine("갑자기 당신은 귓 속으로 늑대의 울음 소리가 파고든다...");
            Console.WriteLine("");
            Console.WriteLine("당신은 공포감을 느끼면서도 호수를 향해 숲 안 쪽으로 계속 향한다.");
            Console.WriteLine("");
            Console.WriteLine("그렇게 걷기를 10분 여 분이 흘렀을 무렵");
            Console.WriteLine("당신의 앞에 늑대가 나타났다");
            Console.WriteLine("");



            Console.WriteLine("1.당신은 허리에 찬 단검을 뽑아 들며 늑대와의 전투를 준비한다");
            Console.WriteLine("2.도망간다");

            string choice4 = Console.ReadLine();

            switch (choice4)
            {
                case "1":
                    Console.WriteLine("당신은 허리에 찬 단검을 뽑아 들며 늑대와의 전투를 준비한다");
                    Battle myBattle = new Battle(new Wolf());
                    myBattle.Battlegame();

                    break;
                case "2":
                    Console.WriteLine("도망간다");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("당신은 늑대와의 사투 후 온 몸이 만신창이였다.");
            Console.WriteLine("그 때 당신 귓 속으로 늑대의 울음 소리가 또 다시 들렸고");
            Console.WriteLine("당신의 만신창이인 몸으로는 더 이상 앞으로 가는 것은 위험하다고");
            Console.WriteLine("판단하였고, 그렇게 당신은 왔던 길로 되돌아가기 시작했다.");
            Console.WriteLine("");

            Console.WriteLine("당신은 다행히 숲의 입구까지 늑대를 만나지 않고");
            Console.WriteLine("무사히 도착했다.");
            Console.WriteLine("");
            Console.WriteLine("그대로 당신은 왔던 길을 되돌아가 방으로 향했고");
            Console.WriteLine("다행히 경비의 눈을 피해 방으로 무사히 돌아왔고");
            Console.WriteLine("그대로 당신은 방에서 수면을 취했다.");


            Console.ReadLine();
            Console.Clear();

            if (mySecondDay != null)
            {
                mySecondDay.GameStorySecondDay(); // 둘째날 게임 이야기 호출
            }
        }

      
    }

       
    
}

