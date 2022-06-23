using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVerhuurBedrijf
{
    internal class Period
    {
        public int id { get; set; }

        public int containerId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Period(int containerId, DateTime startDate, DateTime endDate)
        {
            this.containerId = containerId;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public Period(int id, int containerId, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.containerId = containerId;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public string getPeriod()
        {
            this.endDate.Subtract(this.startDate);
            return this.endDate.Subtract(this.startDate).ToString("%d");
        }

        public float calculateCosts(Container container = null)
        {
            if(container == null)
            {
                container = ContainerRDBMS.readContainer(this.containerId);
            }
            
            float disposalCosts;

            if(container.volume <= 2)
            {
                disposalCosts = 60f;
            }
            else
            {
                disposalCosts = 125f;
            }

            return (float)Convert.ToInt32(getPeriod()) * 40f * container.volume + disposalCosts;
        }
    }
}
