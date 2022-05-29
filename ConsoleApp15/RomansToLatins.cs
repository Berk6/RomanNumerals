using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class RomansToLatins
    {
        public static int RomansToLatinsMeth(string romanValue)
        {
            int total = 0;
            int latinValue = 0;
            int valueControl = 0;
            int valueControl2 = 0;
            int[] array = new int[romanValue.Length];
            for (int i = romanValue.Length - 1; i >= 0; i--)
            {
                if (romanValue[i] == 'I')
                { latinValue = 1; }
                else if (romanValue[i] == 'V')
                { latinValue = 5; }
                else if (romanValue[i] == 'X')
                { latinValue = 10; }
                else if (romanValue[i] == 'L')
                { latinValue = 50; }
                else if (romanValue[i] == 'C')
                { latinValue = 100; }
                else if (romanValue[i] == 'D')
                { latinValue = 500; }
                else if (romanValue[i] == 'M')
                { latinValue = 1000; }
                if (valueControl2 == latinValue )
                {
                    valueControl++;
                }
                else
                {
                    valueControl = 0;
                }
                if (valueControl == 3)
                {
                    return -1;
                }
                array[i] = latinValue;
                valueControl2 = latinValue;
            }
            for (int i = 1; i < romanValue.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    array[i - 1] = -array[i - 1];
                }
            }
            for (int i = 0; i < romanValue.Length; i++)
            {
                total = total + array[i];
            }
            return total;
        }
    }
}
