using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            String nama = input.Text;
            output.Text = "halo" + nama;
        }
    }
}
