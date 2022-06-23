using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVerhuurBedrijf
{
    internal class ContainerRental
    {
        public List<Container> containers { get; private set; }
        
        public ContainerRental()
        {
            this.containers = ContainerRDBMS.readContainers();
        }

        public float getTotalProfits()
        {
            float totalProfits = 0f;
            foreach(Container container in this.containers)
            {
                totalProfits += container.getTotalCosts();
            }
            return totalProfits;
        }

        public string getLongestRentalPeriod()
        {
            int longest = 0;
            int last;
            Container result = null;

            foreach(Container container in this.containers)
            {
                if(container.periods.Count > 0)
                {
                    last = Convert.ToInt32(container.getLongestPeriod().getPeriod());

                    if (longest < last)
                    {
                        longest = last;
                        result = container;
                    }
                }
            }

            return longest.ToString() + " dagen";
        }

        public float getVolumeAverage()
        {
            float totalVolume = 0f;
            int count = (this.containers.Count == 0) ? 1 : this.containers.Count;

            foreach (Container container in this.containers)
            {
                totalVolume += container.volume;
            }

            return totalVolume / count;
        }

        public void addContainer(Container container)
        {
            this.containers.Add(container);
        }

        public bool addContainer(float volume)
        {
            Container container = new Container(volume);
            if(ContainerRDBMS.createContainer(container))
            {
                containers = ContainerRDBMS.readContainers();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeContainer(Container container)
        {
            if (ContainerRDBMS.deleteContainer(container))
            {
                this.containers = ContainerRDBMS.readContainers();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
