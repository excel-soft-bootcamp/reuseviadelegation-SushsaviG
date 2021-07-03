using System;

namespace ReusabilityviaDelegation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            GPS _gps = new GPS();
            Phone _phone = new Phone();
            SmartPhone _smartphone = new SmartPhone();
            _smartphone.TakePicture();
            _smartphone.Hangup();
            _smartphone.Release();
            _smartphone.Navigate();
            Person _person = new Person();
            _person.Communicate(_phone);
            _person.Communicate(_smartPhone);
            Photographer _photo = new Photographer();
            _photo.Capture(_camera);
            _photo.Capture(_smartphone);
            Traveller _traveller = new Traveller();
            _traveller.Hike(_gps);
            _traveller.Hike(_smartPhone);



        }
    }
}
