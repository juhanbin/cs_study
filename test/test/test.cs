using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace CSharp
{
    //객체(OOP)
        
    //Knight
    //속성:hp,attack
    //기능:Move,Attack,Die

    //참조
    class Knight
    {
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    //복사
    struct Mage
    {
        public int hp;
        public int attack;
    }
    
    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }
        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }
        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            //KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;
            
            Knight knight = new Knight();   //객체 생성
            knight.hp=100;
            knight.attack = 10;
            /*
            knight.Move();
            knight.Attack();
            KillKnight(knight);
            */

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
        }
    }
}