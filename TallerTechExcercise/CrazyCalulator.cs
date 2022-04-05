using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerTechExcercise
{
    public class CrazyCalulator
    {
        public long SumReverse(int[] number1, int[] number2) 
        {
            var len1 = number1.Length;
            var len2 = number2.Length;

            string numStr1 = "", numStr2="";

            int i = 0;
            int j = len2-1;

            while (i < len1 || j >= 0) 
            {
                if(i<len1)
                    numStr1 += number1[i];
                if(j>=0)
                    numStr2 += number2[j];
                
                i++;
                j--;
            }

            return long.Parse(numStr1) + long.Parse(numStr2);
        }
    }
}
