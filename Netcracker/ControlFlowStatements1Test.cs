using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netcracker
{
    class ControlFlowStatements1Test 
    {
        public static bool TestGetFunctionValue()
        {
            ControlFlowStatements1 test = new ControlFlowStatements1();
            if ((test.GetFunctionValue(-1)) == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

            
            Console.ReadLine();
        }
    }
}
