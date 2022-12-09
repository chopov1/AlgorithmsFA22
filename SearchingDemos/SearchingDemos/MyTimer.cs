using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SearchingDemos

{
    public class MyTimer
    {
        public double TIME;

        private static System.Timers.Timer aTimer;
        public string ALGO;
        private bool finished;
        private bool waiting;

        double Interval;

        DateTime prev;
        public MyTimer(double interval)
        {
            finished = false;
            Interval = interval;
            setTimer(interval);
        }

        private void setTimer(double interval)
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(interval);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (finished)
            {
                finished = false;
                Console.WriteLine($"{ALGO} took {e.SignalTime.Second - prev.Second} seconds and {e.SignalTime.Millisecond - prev.Millisecond - Interval} milliseconds to execute",
                              e.SignalTime);
            }
            else
            {
                Console.WriteLine("Starting timer");
                finished = true;
            }
            prev = e.SignalTime;
            waiting = false;
        }

        public void StartTimer()
        {
            waiting = true;
            aTimer.Start();
            while (waiting)
            {

            }
            return;
        }

        public double StopTimer()
        {
            aTimer.Stop();
            return TIME;
        }
    }
}
