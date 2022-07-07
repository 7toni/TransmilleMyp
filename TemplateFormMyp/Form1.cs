using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateFormMyp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuchange();
        }        

        private void guna2GradientButton_viewtransmille_Click(object sender, EventArgs e)
        {
            menuchange("viewTransmille");
        }

        public void menuchange(string menu = null) {

            viewUno2.Visible = false;
            viewTransmille2.Visible = false;
            
            if (menu == "viewUno")
            {
                viewUno2.Visible = true;
                viewUno2.reset();
            }
            else if (menu == "viewTransmille") {
                viewTransmille2.Visible = true;
                viewTransmille2.estado();
            }

        }

        private void guna2GradientButton_config_Click(object sender, EventArgs e)
        {
            menuchange("viewUno");
        }

        private void guna2GradientButton_home_Click(object sender, EventArgs e)
        {
            menuchange();
        }
    }
}
