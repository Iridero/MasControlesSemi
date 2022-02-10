using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_SelectorSexo1_SexoActualizado(object sender, SelectorSexoEventArgs e)
        {
            MessageBox.Show(e.Sexo.ToString());
        }
    }
}
