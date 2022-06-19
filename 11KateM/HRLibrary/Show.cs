using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Show
    {
        public string Name;
        public string Host;
        public string Discribing;
        public Periodicity Period;
        public DateTime Time;
        public DateTime Date
        {
            get
            {
                if (this.Period == Periodicity.NonRecurrent)
                    return Date;
                else return DateTime.Today;
            }
        }

        public Show(string n, string h, string d)
        {
            Name = n;
            Host = h;
            Discribing = d;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Ведущий: " + Host);
            Console.WriteLine(Discribing);
            if (this.Period == Periodicity.NonRecurrent)
                Console.WriteLine(Date + " в " + Time);
            else Console.WriteLine(Period + " at " + Time);
        }
    }
}
