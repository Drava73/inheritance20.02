using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance20._02
{
    class Money
    {
        public int cash;
        public int dot_cash;
        public Money()
        {
            cash = 0;
            dot_cash = 0;
        }
        public Money(int cash,int dot_cash)
        {
            this.cash = cash;
            this.dot_cash = dot_cash;
        }
        public int CashControl
        {
            get { return cash; }

            set { cash = value; }
        }
        public int CashDotControl
        {
            get { return dot_cash; }

            set { dot_cash = value; }
        }
        
    }

    class Product : Money
    {
        private string thing;
        public Product(){
            thing = "None";
            cash = 0;
            dot_cash = 0;
        }
        public Product(string thing,int cash,int dot_cash) {
            this.thing = thing;
            this.cash = cash;
            this.dot_cash = dot_cash;
        }
        public void Show()
        {
            Console.Write($"{thing}");
            Console.Write($"\nCash:{cash}.{dot_cash}");
        }
        public static Product operator +(Product opl, int op2)
        {
            Product result = new Product();
            result.cash = opl.cash + op2;
            return result;
        }
        public static Product operator -(Product opl, int op2)
        {
            Product result = new Product();
            result.cash = opl.cash - op2;
            return result;
        }
    }
    /*    class Ystroistvo
        {
            public string ystr;
            public Ystroistvo()
            {
                ystr = "None";
            }
            public Ystroistvo(string ystr)
            {
                this.ystr = ystr;
            }
           public void Sound()
            {
                Console.Write("Издает звук:");
            }
            public void ShoW()
            {
                Console.Write("Устройство :");
            }
            public void Desc()
            {
                Console.Write("\nОписание:");
            }
        }
        class Chainik: Ystroistvo {
            public Chainik()
            {
                ystr = "Chainik";
                Sound();
                Console.Write("Sheeeeeshhhhh\n");
                ShoW();
                Console.Write($"{ystr}");
                Desc();
                Console.Write("Греет воду");
            }

        }
        class Mirkovolnovka : Ystroistvo {
            public Mirkovolnovka()
            {
                ystr = "Mirkovolnovka";
                Sound();
                Console.Write("Wooooooooooooow\n");
                ShoW();
                Console.Write($"{ystr}");
                Desc();
                Console.Write("Греет еду");
            }
        }
        class Car : Ystroistvo {
            public Car()
            {
                ystr = "Car";
                Sound();
                Console.Write("jinjinjinjin\n");
                ShoW();
                Console.Write($"{ystr}");
                Desc();
                Console.Write("Едет");
            }
        }
        class Parahod : Ystroistvo {
            public Parahod()
            {
                ystr = "Parahod";
                Sound();
                Console.Write("blblblblb\n");
                ShoW();
                Console.Write($"{ystr}");
                Desc();
                Console.Write("Идет");
            }
        }*/
    class MusicTool
    {
        public string ystr;
        public MusicTool()
        {
            ystr = "None";
        }
        public MusicTool(string ystr)
        {
            this.ystr = ystr;
        }
        public void Sound()
        {
            Console.Write("Издает звук:");
        }
        public void ShoW()
        {
            Console.Write("Устройство :");
        }
        public void Desc()
        {
            Console.Write("\nОписание:");
        }
        public void History()
        {
            Console.Write("\nИстория:");
        }
    }
    class Skripka : MusicTool
    {
        public Skripka()
        {
            ystr = "Скрипка";
            Sound();
            Console.Write("Sheeeeeshhhhh\n");
            ShoW();
            Console.Write($"{ystr}");
            Desc();
            Console.Write("Скрипит");
            History();
            Console.Write("-");
        }

    }
    class Trombon : MusicTool
    {
        public Trombon()
        {
            ystr = "Trombon";
            Sound();
            Console.Write("Wooooooooooooow\n");
            ShoW();
            Console.Write($"{ystr}");
            Desc();
            Console.Write("Trombonит");
            History();
            Console.Write("-");
        }
    }
    class Ykylel : MusicTool
    {
        public Ykylel()
        {
            ystr = "Ykylel";
            Sound();
            Console.Write("jinjinjinjin\n");
            ShoW();
            Console.Write($"{ystr}");
            Desc();
            Console.Write("Ykylelет");
            History();
            Console.Write("-");
        }
    }
    class Velonshelli : MusicTool
    {
        public Velonshelli()
        {
            ystr = "Velonshelli";
            Sound();
            Console.Write("blblblblb\n");
            ShoW();
            Console.Write($"{ystr}");
            Desc();
            Console.Write("Velonshelliит");
            History();
            Console.Write("-");
        }
    }
    public abstract class Worker
    {
        public virtual void Print() {
            Console.WriteLine("Я работаю");
        }
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я работаю ! Im a President");
        }
    }
    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я работаю ! Im a Security");
        }
    }
    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я работаю ! Im a Manager");
        }
    }
    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Я работаю ! Im a Engineer");
        }
    }
}
