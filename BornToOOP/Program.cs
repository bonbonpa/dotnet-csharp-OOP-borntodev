using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello BornToDev");
            //Console.ReadLine();
            Human man1 = new Human(); //Instance = is ชี้ไปยังหน่วยความจำ
            man1.setLastName("dvp");
            man1.setName("Art");
            man1.addAge();

            Human man2 = new Human();
            man2.setName("GVP");
            man2.setLastName("KK");

            Human human1;

            string hel = man1.getName();

            Console.WriteLine(hel);
            Console.WriteLine(man2.getName());
            Console.ReadLine();

        }
    }
}
