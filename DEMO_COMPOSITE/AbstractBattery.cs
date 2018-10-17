using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    abstract class AbstractBattery : IBattery
    {
        public abstract int getFullCapacity();
        public abstract int getCurrentCapacity();
        public abstract bool charge();
        public abstract bool discharge();
        public virtual void gm_add(IBattery b) { }
        public virtual void gm_remove(IBattery b) { }
    }
}
