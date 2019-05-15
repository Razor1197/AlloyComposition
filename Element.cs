using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alloy_composition
{
    public class Element
    {
        public String Name;
        public float percent;

        public Element(String Name, float percent)
        {
            this.Name = Name;
            this.percent = percent;
        }
    }
}
