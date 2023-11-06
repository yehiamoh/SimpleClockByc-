using System;

namespace clock
{
    class Time
    {
        int hour;
        int second;
        int minute;
        public int Hour
        {
            get { return hour; }
            set
            {
                if (hour > 23 || hour < 0)
                {
                    Console.WriteLine("Invalid input for hour input hours again between 0-23");
                    hour = int.Parse(Console.ReadLine());
                }
                else
                    hour = value;

            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (minute > 59 || minute < 0)
                {
                    Console.WriteLine("Invalid input for hour input minutes again between 0-59");
                    minute = int.Parse(Console.ReadLine());
                }
                else
                    minute = value;

            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (second > 59 || second < 0)
                {
                    Console.WriteLine("Invalid input for second input minutes again between 0-59");
                    second = int.Parse(Console.ReadLine());
                }
                else
                    second = value;

            }
        }
        public Time()
        {
            Hour = Minute = Second = 0;
        }
        public Time(int H, int M, int S)
        {
            Hour = H; Minute = M; Second = S;
        }
        public Time(int H, int M)
        {
            Hour = H; Minute = M; Second = 0;
        }
        public Time(int H)
        {
            Hour = H; Second = 0; Minute = 0;
        }
        public Time(Time x)
        {
            Hour = x.Hour; Minute = x.Minute; Second = x.Second;
        }
        public string Display()
        {
            string mode; string op;
            if (Hour >= 12)
            {
                mode = "AM";
            }
            else
            {
                mode = "PM";
            }
            if (Hour == 12 || Hour == 0) Hour = 0;
            else
                Hour = Hour % 12;
            op = Hour.ToString() + " : " + Minute.ToString() + " : " + Second.ToString() + " " + mode;
            return op;

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Time time = new Time(26,8,0);
                Console.WriteLine(time.Display()); 
            }
        }
    }
}