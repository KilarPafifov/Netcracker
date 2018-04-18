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
            if (Math.Round(test.GetFunctionValue(2),1) != 1.8)
            {
                return false;
            }
           
            if(test.GetFunctionValue(0) != 6)
            {
                return false;
            }

            if (test.GetFunctionValue(-2) != 8)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TestGetFunctionValue());
            Console.ReadLine();
        }
    }
}
