using DesignPatternsDemo.BusinessManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empType)
        {
            IEmployeeManager manager = null;

            if (empType == 1)
                manager = new PermanentEmployeeManager();
            else if (empType == 2)
                manager = new ContractEmployeeManager();

            return manager;
        }
    }
}
