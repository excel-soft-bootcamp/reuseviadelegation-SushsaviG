using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusability
{
    public class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            SmartPhone _smartPhone = new SmartPhone();
            
            _smartPhone.Click();
            _smartPhone.Hangup();
            _smartPhone.Navigate();
            GPS _gps = new GPS();
            Phone _phone = new Phone();

            Photographer _photo = new Photographer();
            _photo.Capture(_camera);
            _photo.Capture(_smartPhone);
            Person _person = new Person();
            _person.Communicate(_phone);
            

        }
    }
}
