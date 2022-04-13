using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Body
    {
        private decimal weight;
        private decimal speed;

        public decimal Weight
        {
            get { return weight; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Значение меньше 0");
                else 
                    weight = value;
            }
        }

        public decimal Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Значение меньше 0");
                else
                    speed = value;
            }
        }

        public Body(decimal weight, decimal speed)
        {
            this.Weight = weight;
            this.Speed = speed;
        }

        public decimal FindKineticEnergy() => (this.weight*this.speed*this.speed) / 2;

    }
}
