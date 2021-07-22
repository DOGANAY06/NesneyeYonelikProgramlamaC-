using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım.Models
{
    public class ClassRoom
    {
        public string number { get; set; }

        public string character { get; set; }

        public string FullName()
        {
            return (" " +number+" -"+ character);

        }
    }
}
