using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void TickHandler(object sender, TimeArgs args);  //声明一个委托类型，定义事件处理函数的格式 

    public class TimeArgs
    {
        public int Hour { get; set; }       //当前时
        public int Minute { get; set; }     //当前分
        public int Second { get; set; }     //当前秒
    }
    public class Clock
    {
        private int hour, minute, second, aHour, aMinute,aSecond;
        public event TickHandler OnTick;
        public event TickHandler OnAlarm;
        public Clock(int hour, int minute)  //构造函数设置时间
        {
            if (hour < 60 && minute < 60)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = 0;
            }
            else
                this.hour = this.minute = this.second = 0;
        }
        public void SetClock(int hour, int minute)  //设置闹钟
        {
            aHour = hour;
            aMinute = minute;      
        }
        public void Run()
        {
            while (true)
            {
                if (this.second < 59) this.second++;
                else
                {
                    this.second = 0;
                    this.minute++;
                    if (this.minute == 60)
                    {
                        this.minute = 0;
                        this.hour = (this.hour + 1) % 24;
                    }
                }
                TimeArgs CurrentTime = new TimeArgs() { Hour = hour, Minute = minute, Second = second };//当前时间
                if (this.hour == this.aHour && this.minute == this.aMinute && this.second == this.aSecond)
                {
                    OnAlarm(this, CurrentTime);
                }
                else
                {
                    OnTick(this, CurrentTime);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class MyClock
    {
        public Clock myClock;
        public MyClock(int hour, int minute)//订阅事件
        {
            myClock = new Clock(hour, minute);
            myClock.OnTick += OnTick;
            myClock.OnAlarm += OnAlarm;
        }
        void OnTick(object sender, TimeArgs args)
        {
            Console.WriteLine("Tick!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
        }
        void OnAlarm(object sender, TimeArgs args)
        {
            Console.WriteLine("Alarm!：[" + args.Hour + ":" + args.Minute + ":" + args.Second + "]");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClock myClock = new MyClock(6, 30);   //设置时间
            myClock.myClock.SetClock(6, 31);     //设置闹钟；
            myClock.myClock.Run();
        }
    }
}