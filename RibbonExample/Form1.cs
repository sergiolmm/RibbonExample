using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibbonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonButton1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Botao 1 double click");
        }
    }
}
