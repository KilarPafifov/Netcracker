using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netcracker
{
    class ControlFlowStatements1 : IControlFlowStatements1
    {
        public double GetFunctionValue(double x)
        {

            if (x > 0)
            {

                return 2 * (Math.Sin(x));
            }
            else
            {
                return 6 - x;
            }
        }

        public int initArray()
        {
            int[][] array = new int[8][];
            for (int i = 0; i < 8; i++)
            {
                array[i] = new int[5];
            }    
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i][j] = i * j;
                    Console.Write(Convert.ToString(array[i][j]));
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            return 0;
            
        }
        public int getMinValue(int[][] array)
        {
            int maxI = 0;
            int maxJ = 0;
            for(int i = 0; i < array.Rank; i++)
            {
                maxI = i;
            }
            for (int j = 0; j < array.Rank; j++)
            {
                maxI = j;
            }
            int minValue = -100;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (minValue > array[i][j])
                    {
                        minValue = array[i][j];
                    }
                }
            }
            return minValue;
        }

    }
}
