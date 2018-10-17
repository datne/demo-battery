using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    class Cell : AbstractBattery
    {
        private int capacity;
        private int fullCapacity;
        public Cell(int capamax)
        {
            fullCapacity = capamax;
            capacity = capamax;
        }
        public override bool charge()
        {
            capacity++;
            return true;
        }
        public override bool discharge()
        {
            capacity--;
            return true;
        }
        public override int getCurrentCapacity()
        {
            return capacity;
        }
        public override int getFullCapacity()
        {
            return fullCapacity;
        }
        public override String ToString()
        {
            return capacity.ToString();
        }
    }
}
