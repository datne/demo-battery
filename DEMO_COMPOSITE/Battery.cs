using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    class Battery : AbstractBattery
    {
        //danh sách các battery thành phần
        private List<IBattery> elems = new List<IBattery>();
        //chiến lược nạp/thải năng lượng
        private IChargeStrategy myStrat;

        public Battery(int nCells, int capCells, bool bycycles)
        {
            for (int i = 0; i < nCells; i++)
            {
                elems.Add(new Cell(capCells));
            }
            if (bycycles)
                myStrat = new StratRoundRobin();
            else
                myStrat = new StratMinMax();
        }

        public override void gm_add(IBattery b)
        {
            elems.Add(b);
        }
        //tác vụ bớt battery b ra khỏi battery hiện hành
        public override void gm_remove(IBattery b)
        {
            elems.Remove(b);
        }


        public override bool charge()
        {
            return myStrat.charge(elems);
        }
        //tác vụ thải 1u khỏi battery
        public override bool discharge()
        {
            return myStrat.discharge(elems);
        }
        //tác vụ tham khảo công suất hiện hành của battery
        public override int getCurrentCapacity()
        {
            int sum = 0;
            foreach (IBattery c in elems)
            {
                sum += c.getCurrentCapacity();
            }
            return sum;
        }
        //tác vụ tham khảo công suất max của battery
        public override int getFullCapacity()
        {
            int sum = 0;
            foreach (IBattery c in elems)
            {
                sum += c.getFullCapacity();
            }
            return sum;
        }
    
        public override String ToString()
        {
            String buf = "[";
            foreach (IBattery c in elems)
            {
                buf += c + ", ";
            }
            return buf.Substring(0, buf.Length - 2) + "]";
        }
    }
}
