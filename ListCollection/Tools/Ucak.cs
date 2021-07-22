using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCollection.Tools
{
    public class Ucak : SavasAraci
    {
        public override void Saldir()
        {
            MessageBox.Show("Füze atılarak saldırıldı");
        }
    }
}
