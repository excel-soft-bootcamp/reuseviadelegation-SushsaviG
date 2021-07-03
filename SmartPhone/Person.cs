using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusability
{
    public class Person
    {
        public void Communicate(IPhone _phone)
        {

            _phone.Hangup();
            _phone.Release();
        }
    }
}
