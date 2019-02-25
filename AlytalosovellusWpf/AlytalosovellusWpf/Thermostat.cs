using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlytalosovellusWpf
{
    public class Thermostat
    {
        public int Temperature { get; set; }

        public string Lampotila { get; set; }

        public void SetTemperature()
        {
            Lampotila = Temperature.ToString();
        }

    }

}
