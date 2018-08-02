using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.BusinessManagers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int GetHourlyPay()
        {
            return 15;
        }

        public int GetBonusRate()
        {
            return 5;
        }
    }
}
