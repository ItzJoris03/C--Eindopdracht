using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVerhuurBedrijf
{
    internal class Container
    {
        public int id { get; set; }
        public float volume { get; set; }
        public bool isAvailable { get; set; }
        public List<Period> periods { get; private set; }

        public Container(float volume)
        {
            this.volume = volume;
            this.periods = ContainerRDBMS.readPeriods(this);
        }

        public Container(int id, float volume, bool isAvailable)
        {
            this.id = id;
            this.volume = volume;
            this.isAvailable = isAvailable;
            this.periods = ContainerRDBMS.readPeriods(this);
        }

        public Period getLongestPeriod()
        {
            int longest = 0;
            int last;
            Period result = null;
            foreach(Period period in periods)
            {
                last = Convert.ToInt32(period.getPeriod());

                if(longest < last)
                {
                    longest = last;
                    result = period;
                }
            }

            return result;
        }

        public float getTotalCosts()
        {
            float totalCosts = 0f;
            foreach(Period period in this.periods)
            {
                
                totalCosts += period.calculateCosts();
            }

            return totalCosts;
        }

        public void addPeriod(Period period)
        {
            periods.Add(period);
        }
    }
}
