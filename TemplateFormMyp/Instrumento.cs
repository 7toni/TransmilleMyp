using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaMyp
{
    public class Instrumento
    {

        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public string firmaware { get; set; }
        public string direccion { get; set; } //resource
        //private IMessageBasedSession device;
        //public string device { get; set; }


        public Instrumento()
        { }

        public Instrumento(string _marca, string _modelo, string _serie, string _firmware, string _direccion)
        {
            this.marca = _marca;
            this.modelo = _modelo;
            this.serie = _serie;
            this.firmaware = _firmware;
            this.direccion = _direccion;
        }



    }

}
