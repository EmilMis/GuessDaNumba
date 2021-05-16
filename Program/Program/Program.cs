using System;
using System.Threading;

namespace Program
{
    internal class Program
    {
        public static void ScrollText(String TextToScroll, int timeOut)
        {
            for (int i = 0; i < TextToScroll.Length; i++)
            {
                Console.Write(TextToScroll[i]);
                Thread.Sleep(timeOut);
            }
        }
        public static void Main(string[] args)
        {
            ScrollText("Hey, this text will be scrolled", 50);
        }
    }
}