using System;
using System.Collections.Generic;
using System.Text;

namespace ReusabilityviaDelegation
{
    public class Photographer
    {
        public void Capture(ICamera _camera)
        {

            _camera.TakePicture();
        }
    }
}
