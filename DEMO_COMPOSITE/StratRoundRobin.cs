using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    class StratRoundRobin:IChargeStrategy
    {
        int aCharger = -1; 
        int aDecharger = -1;

        public bool charge(List<IBattery> elems)
        {
            //hiệu chỉnh chỉ số battery cần nạp
            aCharger = (aCharger + 1) % elems.Count;
            return elems[aCharger].charge();
        }

        public bool discharge(List<IBattery> elems)
        {
            //hiệu chỉnh chỉ số battery cần thải
            aDecharger = (aDecharger + 1) % elems.Count;
            return elems[aDecharger].charge();
        }
    }
}
