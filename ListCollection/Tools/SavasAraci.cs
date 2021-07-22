using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection.Tools
{ //abstract yapmamızdaki amaç metodun her miras alan classda farklı kullanılması
    public abstract class SavasAraci //miras vermekle görevli abstract class
    {//bir metot yazıcaz diğer sınıflarda farklı çalışacak
        public abstract void Saldir();
        //saldırma gemiye,tanka,savaş ucağına özel bir metotdur

    }
}
