using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BRNG.Engine
{
    class BRNGEntropyGenerator
    {       
        public long Generate (long seed)
        {
            Random trueRNG = new Random((int)seed);
            return trueRNG.Next();
        }
        public BRNGEntropyGenerator()
        {
                
        }
    }
}
