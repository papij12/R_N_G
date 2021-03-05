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
        public override long Next()
        {
            Seed = ((A * Seed) + C) % M;
            //maxValue = M;
            //minValue = Seed;
            return Seed;
        }
    }
}
