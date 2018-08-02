using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.BusinessManagers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int GetHourlyPay()
        {
            return 12;
        }

        public int GetBonusRate()
        {
            return 3;
        }
    }
}
