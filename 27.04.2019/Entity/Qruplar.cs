using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._04._2019.Entity
{
    class Qruplar
    {
        public int Id { get; set; }
        public string QrupAdi { get; set; }
        public string Qeyd { get; set; }
        public Filial Filiali { get; set; }
        public XidmetNovu Xidmetnovu { get; set; }
        public Seviyye Seviyye { get; set; }

        public Qruplar Clone()
        {



            Qruplar qrupClone = new Qruplar();
            qrupClone.Filiali = this.Filiali;
            qrupClone.Id = this.Id;
            qrupClone.Qeyd = this.Qeyd;
            qrupClone.QrupAdi = this.QrupAdi;
            qrupClone.Seviyye = this.Seviyye;
            qrupClone.Xidmetnovu = this.Xidmetnovu;

            return qrupClone;

        }
    }
}
