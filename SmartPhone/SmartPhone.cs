using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reusability
{
   public class SmartPhone:IPhone,ICamera,IGPS
    {
        IPhone _hangup;
        IPhone _release;
        ICamera _click;
        IGPS _navigate;
        public SmartPhone()
        {

        }

        public SmartPhone(IPhone hangup,IPhone release,ICamera click,IGPS navigate):this()
        {
            this._hangup = hangup;
            this._release = release;
            this._click = click;
            this._navigate = navigate;
        }
        
        public void Click()
        {
            this._click.Click();


        }
        
        public void Navigate() { this._navigate.Navigate(); }
    
        public void Hangup() { this._hangup.Hangup(); }
        public void Release() { this._release.Release(); }



    }
}
