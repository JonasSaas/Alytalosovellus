using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlytalosovellusWpf
{
    public class Lights
    {
        public bool Switched { get; set; }

        public string Dimmer { get; set; }


        public void LightsFull()
        {
            Switched = true;
            Dimmer = "100";
        }

        public void LightsTwoThird()
        {
            Switched = true;
            Dimmer = "66";
        }

        public void LightsThird()
        {
            Switched = true;
            Dimmer = "33";
        }

        public void LightsOff()
        {
            Switched = false;
            Dimmer = "0";
        }

    }
}
