using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_COMPOSITE
{
    interface IChargeStrategy
    {
        //tác vụ nạp điện cho phần tử tích hợp theo 1 chiến lược xác định
        bool charge(List<IBattery> elems);

        //tác vụ thải điện khỏi phần tử tích hợp theo 1 chiến lược xác định
        bool discharge(List<IBattery> elems);
    }
}
