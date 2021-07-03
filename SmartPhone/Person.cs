using System;
using System.Collections.Generic;
using System.Text;

namespace ReusabilityviaDelegation
{
    public class Person
    {
        public void Communicate(IPhone phone)
        {

            phone.Hangup();
            phone.Release();
        }
    }
}
