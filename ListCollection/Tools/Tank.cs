using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCollection.Tools
{
    public class Tank : SavasAraci
    {
        public override void Saldir() //ovveride ettik ezdik Saldir metodunu 
        {//içeriğini girebileceğiz
            MessageBox.Show("Hedefe Top Atesleyerek saldırıldı");
        }
    }
}
