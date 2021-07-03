using System;
using System.Collections.Generic;
using System.Text;

namespace ReusabilityviaDelegation
{
    public class Traveller
    {
        public void Hike(IGPS _gps)
        {

            _gps.Navigate();
        }
    }
}
