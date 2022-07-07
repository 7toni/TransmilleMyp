using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.Visa;
using VisaMyp;

namespace TemplateFormMyp
{
    public partial class ViewUno : UserControl
    {
        public  _visa objvisa = new _visa();
        //public VisaMyp.InstrumentoData objinstrument = new VisaMyp.InstrumentoData();
        //public List<VisaMyp._instrument> objinstrument = new List<VisaMyp._instrument>(); // Generador

        public ViewUno()
        {
            InitializeComponent();
            reset();
        }

        public void resorce()
        {
            try
            {
                IEnumerable<string> devices;
                var rm = new ResourceManager();
                var resource = rm.Find("?*");
                devices = resource;
                foreach (string value in devices)
                {
                    //metroCombodevices.Items.Add(value);
                    listBox_equipos.Items.Add(value);
                }
            }
            catch (Exception er)
            {
                //MetroMessageBox.Show(this, "Alerta!.", "Mensaje de notificación \r\n" + er.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gunaGradient2Panel1_MouseHover(object sender, EventArgs e)
        {
            gunaGradient2Panel1.GradientColor1 = Color.FromArgb(35, 35, 35);
            gunaGradient2Panel1.GradientColor2 = Color.FromArgb(35, 35, 35);
            //41, 134, 204
        }

        private void gunaGradient2Panel2_MouseHover(object sender, EventArgs e)
        {
            gunaGradient2Panel2.GradientColor1 = Color.FromArgb(35, 35, 35);
            gunaGradient2Panel2.GradientColor2 = Color.FromArgb(35, 35, 35);
        }

        private void gunaGradient2Panel1_MouseEnter(object sender, EventArgs e)
        {
            gunaGradient2Panel1.GradientColor1 = Color.FromArgb(27, 30, 32);
            gunaGradient2Panel1.GradientColor2 = Color.FromArgb(27, 30, 32);
        }

        private void gunaGradient2Panel2_MouseEnter(object sender, EventArgs e)
        {
            gunaGradient2Panel2.GradientColor1 = Color.FromArgb(27, 30, 32);
            gunaGradient2Panel2.GradientColor2 = Color.FromArgb(27, 30, 32);
        }

        private void listBox_equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TextBox_resource.Text = listBox_equipos.SelectedItem.ToString();
            guna2GradientButton_open.Enabled = true;
        }

        private void guna2GradientButton_cargar_Click(object sender, EventArgs e)
        {
            listBox_equipos.Items.Clear();
            resorce();
        }

        private void guna2GradientButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2GradientButton_open_Click(object sender, EventArgs e)
        {
            string resource = guna2TextBox_resource.Text.ToString();
            string result = objvisa.conneccionvisa(resource);

            string nombre = result.ToString();
            var arraydevice = nombre.Split(',');

            guna2TextBox_marca.Text = arraydevice[0];
            guna2TextBox_modelo.Text = arraydevice[1];
            guna2TextBox_serie.Text = arraydevice[2];
            guna2TextBox_firmware.Text = arraydevice[3];
            guna2TextBox_direccion.Text = resource;

            guna2GradientButton_add.Enabled = true;
        }

        private void guna2GradientButton_add_Click(object sender, EventArgs e)
        {

            string[] data =
            {
                guna2TextBox_marca.Text,
                guna2TextBox_modelo.Text,
                guna2TextBox_serie.Text,
                guna2TextBox_firmware.Text,
                guna2TextBox_direccion.Text
            };

            //objinstrument.Add(new VisaMyp._instrument { Marca = data[0], Modelo = data[1], Serie = data[2], Firmware = data[3], Resource = data[4], Device = objvisa.openVisa(data[4]), });


            InstrumentoData.add(new Equipo {id=1, marca= data[0], modelo= data[1], serie= data[2], firmaware= data[3], direccion= data[4], modo="", sesion= objvisa.openVisa(data[4]) });

            List<Equipo> _data = InstrumentoData.data();

            Form1 viewprincipal = new Form1();

            for (int i = 0; i < _data.Count; i++)
            {
                var value = _data[i].marca + _data[i].modelo + _data[i].serie; 
                viewprincipal.listView_datadevices.Items.Add(value.ToString());                 

            }

            

            reset();
        }

        public void reset() {
            guna2GradientButton_open.Enabled = false;
            guna2GradientButton_add.Enabled = false;
            guna2TextBox_marca.Text = "";
            guna2TextBox_modelo.Text = "";
            guna2TextBox_serie.Text = "";
            guna2TextBox_firmware.Text = "";
            guna2TextBox_direccion.Text = "";
            guna2TextBox_resource.Text = "";
        }
    }
}
