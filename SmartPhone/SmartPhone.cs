using System;
using System.Collections.Generic;
using System.Text;

namespace ReusabilityviaDelegation
{
  public  class SmartPhone
    {
        ICamera _cameraref;
        IGPS _gpsref;
        IPhone _phoneref;

        public void SetCamera(ICamera cameraref)
        {
            this._cameraref = cameraref;
        }
        public void SetGPS(IGPS gpsref)
        {
            this._gpsref = _gpsref;
        }
        public void SetPhone(IPhone phoneref)
        {
            this._phoneref = _phoneref;
        }

        public void TakePicture()
        {
            this._cameraref.TakePicture();
        }

        public void Hangup()
        {
            this._phoneref.Hangup();
        }
        public void Release()
        {
            this._phoneref.Release();
        }
        public void Navigate()
        {
            this._gpsref.Navigate();
        }
    }

}
}
