using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon2
{
    internal class MeldingSenderFabrikk
    {
        public IMeldingSender LagMeldingSender(string meldingSenderType) 
        {
            if (meldingSenderType == "sms")
            {
                return new SmsMeldingSender();
            }

            if (meldingSenderType == "epost")
            {
                throw new NotImplementedException();
            }

            if (meldingSenderType == "brev")
            {
                return new BrevMeldingSender();
            }

            return null;
        }
    }
}
