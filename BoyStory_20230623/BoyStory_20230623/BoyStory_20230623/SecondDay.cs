using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class SecondDay
    {

        public void GameStorySecondDay()
        {

            Console.Clear();

            Console.WriteLine("다음날 아침 새들의 지저귀는 소리를 들으면서");
            Console.WriteLine("당신은잠에서 깼다.");
            Console.WriteLine("그 때, 방 밖으로 유모의 목소리가 들렸다.");

            Console.WriteLine(" \"도련님, 아침 식사가 준비되었습니다. 일어나셨습니까?\"");

            Console.WriteLine("당신은 일어났다고 대답을 하며 아침 식사를 위해 나갈 채비를 하였고");
            Console.WriteLine("준비를 마친 후 방을 나서 식당으로 향하였다.");



            Console.WriteLine("식당에 도착한 당신은 당신의 부모님한테 아침 문안 인사를 하며");
            Console.WriteLine("그대로 식탁으로 향했고 의자에 앉았다");
            Console.WriteLine("그 순간 요리사가 당신의 자리에 요리를 가져다 주었고,");
            Console.WriteLine("당신과 당신의 가족은 식사를 시작하였다.");
            Console.WriteLine("그 때 당신의 아버지가 이야기를 하기 시작하였고");
            Console.WriteLine("\"오늘은 풍년을 기념하며 마을에서 수확제를 하는데···");
            Console.WriteLine("당신은 아버지의 이야기를 들으며 마을에 갈 생각이 들었다.");



            Console.WriteLine("당신은 식사 후 자신의 방으로 돌아왔으며");
            Console.WriteLine("유모한테 축제를 구경하기 마을에 간다는 얘기를 하고");
            Console.WriteLine("당신은 마을에 갈 채비를 하기 시작하였다.");

            Console.WriteLine("그렇게 마을에 갈 준비를 마친 당신은 방을 나섰고");
            Console.WriteLine("당신이 방을 나서 집 정문을 열고 밖으로 향할 무렵");
            Console.WriteLine("급하게 달려오는 유모의 발소리가 들렸다");
            Console.WriteLine("그대로 유모는 당신 곁으로 왔고");

            Console.WriteLine("숨을 헐떡이며 당신한테 말을 하였다.");
            Console.WriteLine("\"도... 도련님. 가주... 님께서 전해주라고... 하셨... 습니다.\" ");


            //+100골드
            Shop myshop = new Shop(); // Shop 클래스의 인스턴스 생성
            myshop.playerGold += 100; // playerGold 변수에 100을 더함

            // 최종적으로 playerGold 값 출력
            Console.WriteLine("현재 소지 골드: " + myshop.playerGold);


            Console.WriteLine("그렇게 당신은 유모로 부터 골드를 전해받았고");
            Console.WriteLine("유모한테 다녀오겠다는 인사를 하며");
            Console.WriteLine("마을로 향하기 시작하였다.");



            Console.WriteLine("당신은 그대로 마을로 가는 흙길을 걷기 시작하였다.");
            Console.WriteLine("다행히 어느정도 정비가 되었는지");
            Console.WriteLine("가는 길은 비교적 평탄하였고");
            Console.WriteLine("그대로 걷기를 10분 여... ");
            Console.WriteLine("당신은 마을의 입구에 도착하였다.");
            Console.WriteLine("");
            Console.WriteLine("당신은 마을에 들어왔고");
            Console.WriteLine("마을은 시끌벅쩍한 분위기로 가득 차 있었으며");
            Console.WriteLine("각종 노점들이 즐비하였다.");
            Console.WriteLine("");
            Console.WriteLine("당신은 노점을 지나치며 구경하던 중");
            Console.WriteLine("한 노점상이 하는 말이 들렸다");
            Console.WriteLine("\"각종 꼬치 있습니다. 한번 둘러보세요\"");
            Console.WriteLine("당신은 노점상의 말을 듣고");
            Console.WriteLine("당신은 꼬치를 파는 노점으로 갔고");
            Console.WriteLine("당신을 발견한 노점상은");
            Console.WriteLine("\"각종 꼬치 있습니다. 한 번 둘러보세요\"");
            Console.WriteLine("라고 당신한테 말을 하였고");


            Console.WriteLine("1.당신은 노점에서 판매하는 꼬치를 둘러본다");
            Console.WriteLine("1.아니다(임시)");


            string choice5 = Console.ReadLine();

            switch (choice5)
            {
                case "1":
                    Console.WriteLine("당신은 노점에서 판매하는 꼬치를 둘러본다");
                    Shop myShop = new Shop();
                    myShop.InitializeShop();

                    // 100골드 반영
                    myShop.playerGold += 100;

                    myShop.StartShopping();
                    Console.WriteLine("현재 소지 골드: " + myShop.playerGold);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("아니다(임시)");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }
        }
    }
}
