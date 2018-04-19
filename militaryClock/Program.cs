using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace militaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;
            //int userHourInput = h;
            //int userMinuteInput = m;
            //int userSecondInput = s;
            //int parsedHour;
            //int parsedMinute;
            //int parsedSecond;
            //int time;

            Console.WriteLine("Press 1 to choose a start time. Press 2 for current time.  Press 3 to start at zero.");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.D2)
            {
                DateTime.Now.ToString("HH:mm");
            }

            //    Console.WriteLine("What is the starting hour?");
            //    string userHourInput = Console.ReadLine();
            //    h = Convert.ToInt32(userHourInput);

            //    Console.WriteLine("What is the starting minute?");
            //    string userMinInput = Console.ReadLine();
            //    m = Convert.ToInt32(userMinInput);

            //    Console.WriteLine("What is the starting second?");
            //    string userSecondInput = Console.ReadLine();
            //    s = Convert.ToInt32(userSecondInput);

            //    Console.WriteLine("{0} : {1} : {2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));
            //}


            //if (info.Key == ConsoleKey.D3)
            //    Console.t
            //for (; h < 23; h++)
            //{
            //    //blinking int
            //    //h = hour;
            //    for (; m < 59; m++)
            //    {
            //        //blinking int
            //        // m = minute;
            //        for (; s < 59; s++)
            //        {
            //            //blinking int
            //            //s = second;
            //            Thread.Sleep(10);
            //            Console.Clear();
            //            Console.WriteLine("{0} : {1} : {2}", h.ToString("00"), m.ToString("00"), s.ToString("00"));

            //Code to make the clock blink
            //int k = 1;

            //if (true)
            //{
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.WriteLine("{0} : {1} : {2}", hour.ToString("00"), minute.ToString("00"), second.ToString("00"));
            //    Console.Clear();
            //    Thread.Sleep(400);
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("{0} : {1} : {2}", hour.ToString("00"), minute.ToString("00"), second.ToString("00"));
            //}
            ////else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("{0} : {1} : {2}", hour.ToString("00"), minute.ToString("00"), second.ToString("00"));
            //    Console.Clear();
            //    Thread.Sleep(400);
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.WriteLine("{0} : {1} : {2}", hour.ToString("00"), minute.ToString("00"), second.ToString("00"));
            //}
            //k = 2;

        }
    }
}
