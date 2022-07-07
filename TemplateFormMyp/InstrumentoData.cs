using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaMyp
{
    public  class InstrumentoData
    {

        private static List<Equipo> dataequipo = new List<Equipo>();

        public InstrumentoData() {
        }

        public static string add(Equipo equipo) {
            try
            {
                dataequipo.Add(equipo);
                return "001|Exitoso";
            }
            catch (Exception ex)
            {
                return "001|Error|" + ex.ToString();

            }
        }

        public static Equipo buscar(int id) {
            for (int i = 0; i < dataequipo.Count; i++)
            {
                if (id == dataequipo[i].id)
                {
                    string marca = dataequipo[i].marca;
                    string modelo = dataequipo[i].modelo;
                    string serie = dataequipo[i].serie;
                    string firmware = dataequipo[i].firmaware;
                    string direccion = dataequipo[i].direccion;
                    string modo = dataequipo[i].modo;
                    IMessageBasedSession sesion = dataequipo[i].sesion;
                    Equipo objequipo = new Equipo(id, marca, modelo, serie, firmware, direccion, modo, sesion);
                    return objequipo;
                }
            }
            return null;
        }

        public static int conteo() {
            return dataequipo.Count;
        }

        public static List<Equipo> data()
        {
            return dataequipo;
        }


    }
}

