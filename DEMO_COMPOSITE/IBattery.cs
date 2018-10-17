using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    interface IBattery
    {
        int getFullCapacity();
        int getCurrentCapacity();
        bool discharge();
        bool charge();
        void gm_add(IBattery b);
        void gm_remove(IBattery b);
    }
}
