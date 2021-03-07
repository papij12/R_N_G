using System;
using System.Collections.Generic;
using System.Text;

namespace R_N_G
{
   public abstract class RNG
    {
        protected long A { get; set; }
        protected long C { get; set; }
        protected long M { get; set; }
        protected long NextRandomNumber { get; set; }
        public RNG(long a, long c, long m, long seed)
        {
            A = a;
            C = c;
            M = m;
            NextRandomNumber = seed;
        }
        public abstract long Next(long minvalue, long maxvalue);
            
    }
}
