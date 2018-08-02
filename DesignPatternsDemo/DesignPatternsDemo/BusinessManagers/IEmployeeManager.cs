using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.BusinessManagers
{
    public interface IEmployeeManager
    {
        int GetHourlyPay();
        int GetBonusRate();
    }
}
