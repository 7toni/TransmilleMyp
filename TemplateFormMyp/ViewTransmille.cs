using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa;

namespace VisaMyp
{
    public partial class ViewTransmille : UserControl
    {
        public  VisaMyp._visa objvisa= new _visa();       

        public double rangomax { get; set; }
        public string unidad { get; set; }

        public bool standby = false;

        public IMessageBasedSession device { get; set; }        

        public ViewTransmille()
        {
            InitializeComponent();
            estado();
            guna2GradientButton_outputon.Enabled = false;
            gunaMediumRadioButton_manual.Checked = true;
            listBox_funciones.Enabled = false;
        }

        public void estado()
        {
            int size= InstrumentoData.conteo();
            if (size > 0)
            {
                gunaCircleButton_estado.BaseColor = Color.DeepSkyBlue;
                List<Equipo> _data = InstrumentoData.data();
                device = _data[0].sesion;
                listBox_funciones.Enabled = true;
            }
            else
            {
                gunaCircleButton_estado.BaseColor = Color.Gray;
            }
        }

        private void gunaCircleButton_estado_Click(object sender, EventArgs e)
        {
            estado();
        }

        private void listBox_funciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_rangos.Items.Clear();
            string funcion = listBox_funciones.SelectedItem.ToString();
            string[] data = rangos(funcion);
            foreach (string value in data)
            {
                listBox_rangos.Items.Add(value);
            }
        }

        public string[] rangos(string value)
        {
            string[] data = { };

            switch (value)
            {
                case "VOLT DC":
                    string[] rango = { "200mV", "2V", "20V", "200V", "1000V" };
                    data = rango;
                    break;
                case "VOLT AC":
                    string[] rango1 = { "200mV", "2V", "20V", "200V", "1000V" };
                    data = rango1;
                    break;
                case "CORRIENTE AC":
                    string[] rango2 = { "200uA", "2mA", "20mA", "200mA", "2A", "30A" };
                    data = rango2;
                    break;
                case "CORRIENTE DC":
                    string[] rango3 = { "200uA", "2mA", "20mA", "200mA", "2A", "30A" };
                    data = rango3;
                    break;
                case "RESISTENCIA":
                    string[] rango4 = {"100Ohms",
                        "330Ohms",
                        "1kOhm",
                        "3.3kOhms",
                        "10kOhms",
                        "33kOhms",
                        "100kOhms",
                        "330kOhms",
                        "1MOhms",
                        "3.3MOhms",
                        "10MOhms",
                        "33MOhms",
                        "100MOhms",
                        "330MOhms",
                        "1GOhms"
                    };
                    data = rango4;
                    break;
            }
            return data;
        }

        private void guna2GradientButton_limpiar_Click(object sender, EventArgs e)
        {
            listBox_rangos.Items.Clear();
            listBox_funciones.SelectedItem = false;
        }

        private void listBox_rangos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string funcion = listBox_funciones.SelectedItem.ToString();
            string rango = listBox_rangos.SelectedItem.ToString();
            dividir_rango(rango);
        }

        public void dividir_rango(string data)
        {

            data = data.Trim();
            char[] arraychar = data.ToCharArray();
            string unidades = "";
            string valor = "";
            bool number = false;

            foreach (char value in arraychar)
            {
                if (Char.IsLetter(value))
                {
                    unidades += value;
                }
                else if (Char.IsPunctuation(value))
                {
                    if (number == true)
                    {
                        valor += value;
                    }
                    else
                    {
                        valor += "0" + value;
                    }
                }
                else if (Char.IsNumber(value))
                {
                    valor += value;
                    number = true;
                }
            }
            rangomax = Double.Parse(valor);
            unidad = unidades;
        }

        public string[] escanear_entrada(string data)
        {
            data = data.Trim();
            char[] arraychar = data.ToCharArray();
            string unidades = "";
            string valor = "";
            bool number = false;
            bool letter = false;

            string[] newdata = new string[2];

            foreach (char value in arraychar)
            {
                if (Char.IsLetter(value))
                {
                    unidades += value;
                    letter = true;
                }
                else if (value == '.')
                {
                    if (number == true)
                    {
                        valor += value;
                    }
                    else
                    {
                        valor += "0" + value;
                    }
                }
                else if (Char.IsNumber(value))
                {
                    valor += value;
                    number = true;
                }
            }

            if (valor.Length > 0)
            {
                string punto = valor.Substring(valor.Length - 1, 1);
                if (punto == ".")
                {
                    valor += "0";
                }
            }
            else
            {
                valor = "0";
            }

            newdata[0] = valor;
            if (letter == true)
            {
                newdata[1] = unidades;
            }
            else
            {
                newdata[1] = "";
            }
            return newdata;
        }

        private void guna2GradientButton_outputon_Click(object sender, EventArgs e)
        {
            string[] data = { };
            double salida = 0;
            string valor = guna2TextBox_valor.Text;
            string rango = "";
            data = escanear_entrada(valor);
            guna2TextBox_valor.Text = data[0] + data[1];

            if (gunaMediumRadioButton_manual.Enabled) {
                rango = listBox_rangos.SelectedItem.ToString();                
            }            

            if (!String.IsNullOrEmpty(data[0]))
            {
                salida = double.Parse(data[0]);
                
                //"r164/O0/S0<CR>"
                var command = command_rangos(listBox_funciones.SelectedItem.ToString(), rango);
                command += "/O" + data[0];
                command += "/S0<CR>";
                standby = false;
                objvisa.writeVisa_2(device, command);
            }

        }

        private void guna2TextBox_valor_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(guna2TextBox_valor.Text))
            {
                if (!String.IsNullOrEmpty(listBox_rangos.SelectedItem.ToString()))
                {
                    guna2GradientButton_outputon.Enabled = true;
                }
                else
                {
                    gunaLabel_error.Text = "Seleccionar rango";
                }
            }
            else
            {
                guna2GradientButton_outputon.Enabled = false;
            }

        }

        private void guna2GradientButton_stanby_Click(object sender, EventArgs e)
        {
            if (!standby)
            {
                objvisa.writeVisa_2(device, "/S1<CR>");
                standby = true;
            }
            else
            {
                objvisa.writeVisa_2(device, "/S0<CR>");
            }
        }

        private void guna2GradientButton_cls_Click(object sender, EventArgs e)
        {
            objvisa.writeVisa_2(device, "*CLS");
        }

        private void guna2GradientButton_rst_Click(object sender, EventArgs e)
        {
            objvisa.writeVisa_2(device, "*RST");
        }        

        public string command_rangos(string value, string vrango)
        {
            string[] data = { };
            string[] data_command = { };
            string command= "";

            switch (value)
            {
                case "VOLT DC":
                    string[] rango = { "200mV", "2V", "20V", "200V", "1000V" };
                    string[] commands = { "r1", "r2", "r3", "r4", "r5" };
                    data = rango;
                    data_command = commands;
                    break;
                case "VOLT AC":
                    string[] rango1 = { "200mV", "2V", "20V", "200V", "1000V" };
                    string[] commands1 = { "r21", "r22", "r23", "r24", "r25" };
                    data = rango1;
                    data_command = commands1;
                    break;
                case "CORRIENTE DC":
                    string[] rango2 = { "200uA", "2mA", "20mA", "200mA", "2A", "30A" };
                    string[] commands2 = { "r11", "r12", "r13", "r14", "r15" };
                    data = rango2;
                    data_command = commands2;
                    break;
                case "CORRIENTE AC":
                    string[] rango3 = { "200uA", "2mA", "20mA", "200mA", "2A", "30A" };
                    string[] commands3 = { "r31", "r32", "r33", "r34", "r35" };
                    data = rango3;
                    data_command = commands3;
                    break;
                case "RESISTENCIA":
                    string[] rango4 = {"100Ohms",
                        "330Ohms",
                        "1kOhm",
                        "3.3kOhms",
                        "10kOhms",
                        "33kOhms",
                        "100kOhms",
                        "330kOhms",
                        "1MOhms",
                        "3.3MOhms",
                        "10MOhms",
                        "33MOhms",
                        "100MOhms",
                        "330MOhms",
                        "1GOhms"
                    };
                    string[] commands4 = {"r164",
                        "r165",
                        "r166",
                        "r167",
                        "r168",
                        "r169",
                        "r170",
                        "r171",
                        "r172",
                        "r173",
                        "r174",
                        "r175",
                        "r176",
                        "r177",
                        "r178"
                    };
                    data = rango4;
                    data_command = commands4;
                    break;
            }

            var i = -1;
            foreach (var item in data)
            {
                i++;
                if (item== vrango) {
                    command = data_command[i];
                    break;
                }
            }

            return command;
        }
    }
}
