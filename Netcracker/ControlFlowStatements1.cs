using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netcracker
{
    class ControlFlowStatements1 : IControlFlowStatements1
    {
        public float GetFunctionValue(float x)
        {
            if(x > 0)
            {
                return 2 * (Math.Abs(x));
            }
            else
            { 
                return 6 - x;
            }
        }
    }
}
