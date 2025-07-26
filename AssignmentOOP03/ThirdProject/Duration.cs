using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class Duration
    {
        private double hours;
        private double minutes;
        private double seconds;
        private double TotalSecond => hours * 3600 + minutes * 60 + seconds;


        private void CalcDuration(double x)
        {
            hours = (int)x / 3600;
            x %= 3600;
            minutes = (int)x / 60;
            seconds = (int)x % 60;
        }
        
        public Duration(double hours, double minutes, double seconds)
        { 
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration(double x)
        {
            CalcDuration(x);
        }
        public double Hours
        { 
            get { return hours; }
            set { hours = value < 0 ? 0 : value; }
        }
        public double Minutes
        {
            get { return minutes; }
            set { minutes = value < 0 ? 0 : value; }
        }
        public double Seconds
        {
            get { return seconds; }
            set { seconds = value < 0 ? 0 : value; }
        }
        public override string ToString()
        {
            return $" Hours: {hours}, Minutes : {minutes}, Seconds : {seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
                return this.TotalSecond == other.TotalSecond;
            return false;
        }

        
        public override int GetHashCode()
        {
            return TotalSecond.GetHashCode();
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.TotalSecond + right.TotalSecond);
        }

        public static Duration operator +(Duration left, double second)
        {
            return new Duration(left.TotalSecond + second);
        }
        public static Duration operator +(double second, Duration right)
        {
            return new Duration(right.TotalSecond + second);
        }

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration(Math.Max(left.TotalSecond - right.TotalSecond , 0));
        }

        public static Duration operator ++(Duration D)
        {
            D.minutes++;
            return new Duration(D.TotalSecond);
        }
        public static Duration operator --(Duration D)
        {
            D.minutes--;
            return new Duration(Math.Max(D.TotalSecond , 0));
        }
        public static bool operator > (Duration left , Duration right)
        {
            return left.TotalSecond > right.TotalSecond;
        }
        public static bool operator < (Duration left, Duration right)
        {
            return left.TotalSecond < right.TotalSecond;
        }
        public static bool operator <= (Duration left, Duration right)
        {
            return left.TotalSecond <= right.TotalSecond;
        }
        public static bool operator >=(Duration left, Duration right)
        {
            return left.TotalSecond >= right.TotalSecond;
        }
        public static bool operator true(Duration d)
        {
            return d.TotalSecond != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSecond == 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1).AddSeconds(d.TotalSecond);
        }

    }
}
