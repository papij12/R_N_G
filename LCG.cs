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
            Seed = ((A * Seed) + C) % M;
           long answer = minvalue + Seed % (maxvalue - minvalue);
            //for (int i = 0; i < nextrandomnumber.Length; i++)
            //{
            //    nextrandomnumber[i] = Seed;
                
            //}
            return answer;
        }
    }
}
