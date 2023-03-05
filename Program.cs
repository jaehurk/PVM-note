using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test2
{

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                         GAME                           |");
            System.Console.WriteLine("|                         START                          |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|            ■            vs             □             |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");


            Thread.Sleep(2000);

            Console.Clear();

            player player = new player();

            Monster monster = new Monster();


            do
            {
                player.SkillName();
                player.SkillUse();

                player.Attack(monster);
                
                monster.Attack(player);
                

                if (monster.hp == 0)
                {
                    System.Console.WriteLine("----------------------------------------------------------");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                         WIN                            |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                       DEAD!            |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|           ■                            x              |");
                    System.Console.WriteLine("|          player                       monster          |");
                    System.Console.WriteLine("----------------------------------------------------------");
                    System.Console.WriteLine("몬스터가 죽었습니다. 게임 승리!");

                    Thread.Sleep(3000);

                    Console.Clear();

                    break;

                }
                if (player.hp == 0)
                {
                    System.Console.WriteLine("----------------------------------------------------------");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                         LOSE                           |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|          DEAD!                                         |");
                    System.Console.WriteLine("|                                                        |");
                    System.Console.WriteLine("|            x                            □             |");
                    System.Console.WriteLine("|          player                       monster          |");
                    System.Console.WriteLine("----------------------------------------------------------");
                    System.Console.WriteLine("플레이어가 죽었습니다. 게임 패배");

                    Thread.Sleep(3000);

                    Console.Clear();

                    break;
                }
            } while (player.AskKeepPutData());
        }
    }

    interface Entity
    {
        void Attack(Entity entity);
        void TakeDamage();
        void Avoid();
        void ReduceHP();
    }

    class Monster : Entity
    {
        public int hp = 4;

        public void Attack(Entity entity)
        {
            
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                       ATTACK!          |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|            ■           ←              □             |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine($"몬스터가 플레이어를 공격했습니다");

            Thread.Sleep(2000);

            Console.Clear();

            entity.TakeDamage();
        }
        public void Avoid()
        {
            
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                        MISS!           |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|            ■                           x □           |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("몬스터가 공격을 피했습니다");

            Thread.Sleep(2000);

            Console.Clear();
        }
        public void ReduceHP()
        {
            hp--;
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                       DAMAGE!          |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|            ■                           □!            |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine($"몬스터가 공격을 받았습니다. 몬스터의 남은 체력 : ♥{hp}");

            Thread.Sleep(2000);

            Console.Clear();
        }
        public void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 3);
            if (randInt == 0)
            {
                Avoid();
            }
            
            else
            {
                ReduceHP();
            }
        }
    }

    class player : Entity
    {
        public int hp = 4;
        string A;
        string[] skill = new string[7] { "0. Fire 불", "1. Ice 얼음", "2. Windy 바람", "3. Ground 땅", "4. Electric 전기", "5. Dark 어둠", "6. Light 빛" };
        public void Attack(Entity entity)
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|         ATTACK!                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|           ■             →             □             |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("플레이어가 몬스터를 공격했습니다.");
            Thread.Sleep(2000);

            Console.Clear();

            entity.TakeDamage();
        }

        public void Avoid()
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|          MISS!                                         |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|         ■ x                            □             |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("플레이어가 공격을 피했습니다");

            Thread.Sleep(2000);

            Console.Clear();

        }
        public void ReduceHP()
        {
            hp--;
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|         DAMAGE!                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|           ■!                           □             |");
            System.Console.WriteLine("|          player                       monster          |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine($"플레이어가 공격을 받았습니다. 플레이어의 남은 체력 ♥{hp}");

            Thread.Sleep(2000);

            Console.Clear();
        }

        public void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 3);
            if (randInt == 0)
            {
                Avoid();
            }
            else
            {
                ReduceHP();
            }
        }

        public bool AskKeepPutData()
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|         도망                         재경기            |");
            System.Console.WriteLine("|          Run                         ReMatch           |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|         < N >                         < Y >            |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("|                                                        |");
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.Write("계속 싸우시겠습니까? 도망치겠습니까? (y/n) : ");
            string userAnser = System.Console.ReadLine();
            System.Console.WriteLine("----------------------------------------------------------");

            if (userAnser == "y" || userAnser == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SkillName()
        {
            System.Console.WriteLine();
            System.Console.WriteLine(skill[0]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[1]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[2]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[3]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[4]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[5]);
            System.Console.WriteLine();
            System.Console.WriteLine(skill[6]);
        }
        public int SkillUse()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("스킬을 사용하세요");
            System.Console.WriteLine("----------------------------------------------------------");


            A = System.Console.ReadLine();
            int Aa = Convert.ToInt32(A);
            SkillResult(Aa);
            return Aa;
        }
        public void SkillResult(int skillIndexNumber)
        {
            System.Console.WriteLine("----------------------------------------------------------");
            System.Console.Write(skill[skillIndexNumber]);


            System.Console.WriteLine("을/를 사용했습니다");
            System.Console.WriteLine("----------------------------------------------------------");

            Thread.Sleep(1000);

            Console.Clear();

            skill[skillIndexNumber] = " ";
        }

    }

}
