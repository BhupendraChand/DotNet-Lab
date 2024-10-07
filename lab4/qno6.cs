using System;


    internal class qno6

{
    class Time
    {
        int hour, minute, second;

        public Time()
        { }

        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void getTime()
        {
            Console.WriteLine("The Time is = " + hour.ToString("00") + " : " + minute.ToString("00") + " : " + second.ToString("00"));
        }

        public Time addTime(Time t2)
        {
            int thour = this.hour;
            int tminute = this.minute;
            int tsecond = this.second;

            thour += t2.minute;
            tminute += t2.second;
            tsecond += t2.second;

            while (tsecond >= 60)
            {
                tsecond -= 60;
                tminute += 1;
            }

            while (tminute >= 60)
            {
                tminute -= 60;
                thour += 1;
            }

            return new Time(thour, tminute, tsecond);
        }

        public Time subtractTime(Time t2)
        {
            int thour = this.hour;
            int tminute = this.minute;
            int tsecond = this.second;

            thour -= t2.minute;
            tminute -= t2.second;
            tsecond -= t2.second;

            while (tminute < 0)
            {
                tminute += 60;
                thour -= 1;
            }

            while (tsecond < 0)
            {
                tsecond += 60;
                tminute -= 1;
            }



            return new Time(thour, tminute, tsecond);
        }
    }
    internal class Hour
    {
        public static void Main()
        {
            Time time = new Time(1, 2, 3);
            Time time2 = new Time(4, 5, 6);
            time.getTime();

            Time sumTime = time.addTime(time2);
            time2.getTime();

            Time differenceTime = time.subtractTime(time2);
            differenceTime.getTime();
            Console.ReadKey();
        }
        
    }
}

