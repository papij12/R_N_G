using System;
using System.Collections.Generic;
using System.Text;

namespace R_N_G
{
    class LCG : RNG
    {
        public LCG(long a, long c,long m, long seed) :base(a,c,m,seed)
        {

        }
        public override long Next(long minvalue, long maxvalue)
        {
            //long [] nextrandomnumber = new long [9];
            NextRandomNumber = ((A * NextRandomNumber) + C) % M;
          long answer = minvalue + NextRandomNumber % (maxvalue - minvalue);
           return answer;
        }
    }
}
