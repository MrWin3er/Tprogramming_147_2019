using System;

namespace CourseApp
{
    public class Auto
    {
        private int speed;

        public Auto()
        : this("Untitled")
        {
        }

        public Auto(string name)
        : this(name, 2000)
        {
        }

        public Auto(string name, int year)
        : this(name, year, 60)
        {
        }

        public Auto(string name, int year, int speed)
        {
            this.speed = speed;
            this.Name = name;
            this.Year = year;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                if (value >= 0 && value < 300)
                {
                    this.speed = value;
                }
                else
                {
                    throw new System.Exception("Speed should be more 0 and less than 300");
                }
            }
        }

        public string Name { get; set; }

        public int Year { get; set; }

        public override string ToString()
        {
            string s = $"The car {Name}({Year}) is moving at a speed of {Speed} km/h.";
            return s;
        }
    }
}