using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlytalosovellusWpf
{
    public class Sauna
    {
        public bool Switched { get; set; }

        public void SaunaOn()
        {
            Switched = true;
        }

        public void SaunaOff()
        {
            Switched = false;
        }
    }
}
