using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_pitagoras_b
{
    class Catetos: Pitagoras
    {
        private string catetoa;

        public string CatetoA
        {
            get => catetoa;
            set => catetoa = value;
        }

        private string catetob;
        public string Catetob
        {
            get => catetob;
            set => catetoa = value;
        }

        private string catetoc;
        public string Catetoc
        {
            get => catetoc;
            set => catetoc = value;
        }

        public Catetos(string definicion, string año, string tipodematematica, string catetoa, string catetob, string catetoc) : base(definicion, año, tipodematematica)
        {
            this.catetoa = catetoa;
            this.catetob = catetob;
            this.catetoc = catetoc;
        }
    }
}
