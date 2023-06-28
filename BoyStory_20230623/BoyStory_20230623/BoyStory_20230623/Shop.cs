using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoyStory_20230623
{
    public class Shop
    {
        public List<Item> playerInventory;
        public List<Item> shopInventory;
        public int playerGold = 100;

        public void InitializeShop()
        {
            playerInventory = new List<Item>();
            shopInventory = new List<Item>
            {
                new Item("닭 꼬치", 10),
                new Item("양 꼬치", 15),
                new Item("돼지 꼬치", 5),
                new Item("소 꼬치", 20)
            };
            
        }

        public void StartShopping()
        {
            Console.WriteLine("상점에 오신 것을 환영합니다!");

            while (true)
            {
                Console.WriteLine("\n----- 상점 재고 -----");
                DisplayInventory(shopInventory);

                Console.WriteLine("\n----- 플레이어 인벤토리 -----");
                DisplayInventory(playerInventory);

                Console.WriteLine("\n소지 골드: " + playerGold);
                Console.WriteLine("\n원하는 작업을 선택하세요:");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("2. 상점 종료");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("구매할 아이템의 번호를 입력하세요:");
                    int index = int.Parse(Console.ReadLine());

                    if (index >= 0 && index < shopInventory.Count)
                    {
                        Item selectedItem = shopInventory[index];

                        if (playerGold >= selectedItem.Price)
                        {
                            playerGold -= selectedItem.Price;
                            playerInventory.Add(selectedItem);
                            shopInventory.Remove(selectedItem);

                            Console.WriteLine(selectedItem.Name + "을(를) 구매했습니다!");
                        }
                        else
                        {
                            Console.WriteLine("골드가 부족합니다.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("유효하지 않은 아이템 번호입니다.");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("상점 이용해 주셔서 감사합니다!");
                    break;
                }
                else
                {
                    Console.WriteLine("유효하지 않은 선택입니다.");
                }
            }
        }

        private void DisplayInventory(List<Item> inventory)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Item item = inventory[i];
                Console.WriteLine(i + ". " + item.Name + " - " + item.Price + " 골드");
            }
        }
    }
}

