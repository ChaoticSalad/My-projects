using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class Bee : IStingPatrol
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg
        {
            get;
            private set;
        }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public int AlertLevel
        {
            get;
        }

        public int StingerLength
        {
            get;
            set;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }

        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int length)
        {
            return 1;
        }
    }
}
