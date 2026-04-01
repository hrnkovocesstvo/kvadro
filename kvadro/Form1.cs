using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvadro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kvatr kv = new kvatr((double)numericUpDownA.Value, (double)numericUpDownB.Value, (double)numericUpDownC.Value);

            textBoxOut.Text = $"objem: {kv.get_objem()} {textBoxJ.Text}³{Environment.NewLine}povrch: {kv.get_povrh()} {textBoxJ.Text}²";         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
