using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList isimler = new MyList();

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Deniz");

            Console.WriteLine("Hello World!");
        }
    }
}
