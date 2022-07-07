using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaMyp
{
    public class Equipo:Instrumento
    {
        private int _id;
        private IMessageBasedSession _sesion;
        private string _modo;

        public int id {
            get { return _id; }
            set { _id = value;  }
        }

        public IMessageBasedSession sesion
        {
            get { return _sesion; }
            set { _sesion = value; }
        }

        public string modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

        public Equipo()
        { }

        public Equipo(int _id, string _marca, string _modelo, string _serie, string _firmware, string _direccion, string _modo, IMessageBasedSession _sesion)
            :base(_marca,_modelo,_serie,_firmware,_direccion)
        {
            this.id = _id;
            this.modelo = _modo;
            this.sesion = _sesion;

        }


    }
}
