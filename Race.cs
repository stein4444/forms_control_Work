using System;
using System.Collections.Generic;

namespace Forms_ControlWork
{
    [Serializable]
    public class Races
    {
        public List<Race> races { get; set; } = new List<Race>();
    }
    [Serializable]
    public class Race
    {
        public string name { get; set; }
        public string timeArr { get; set; }
        public string timeDeparture { get; set; }
        public Race() { }
        public Race(string n, string time, string timeD)
        {
            name = n;
            timeArr = time;
            timeDeparture = timeD;
        }

    }
}
