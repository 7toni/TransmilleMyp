using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisaMyp
{
    public class _visa: InstrumentoData
    {        

        public _visa() {           
        }
       

        #region Funciones de Write, Read Ivi.Visa

        public IMessageBasedSession openVisa(string resource)
        {
            var mydevice = GlobalResourceManager.Open(resource) as IMessageBasedSession;
            return mydevice;
        }

        public void closeVisa(IMessageBasedSession mydevice)
        {
            mydevice.Dispose(); // write to instrument
        }

        public void writeVisa(IMessageBasedSession mydevice, string command)
        {
            //mydevice.TimeoutMilliseconds = 1000;
            mydevice.RawIO.Write(command); // write to instrument             
        }

        public void writeVisa_2(IMessageBasedSession mydevice, string command)
        {
            // mydevice.TimeoutMilliseconds = 2000;
            mydevice.Clear();
            //mydevice.RawIO.Write(command +"\n");
            mydevice.RawIO.Write(command + "\n");
            Thread.Sleep(500);
            mydevice.FormattedIO.Printf(command + "\n");            
            //mydevice.RawIO.Write(command); // write to instrument              
        }

        public string readVisa(IMessageBasedSession mydevice)
        {
            string result = "0";
            //mydevice.TimeoutMilliseconds = 1000;
            result = mydevice.RawIO.ReadString();
            //Console.WriteLine("resultado:" + result);
            return result; // read from instrument
        }

        public string conneccionvisa(string device)
        {
            string res;
            try
            {
                var mydevice = openVisa(device);
                writeVisa(mydevice, "*IDN?\n");
                res = readVisa(mydevice);
                closeVisa(mydevice);
                return res;
            }
            catch (Exception ex)
            {
                return res = "Error:101" + ex; //Error 101 Error valor:null
            }

        }
        #endregion

    }

}
