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
    public partial class UC_Switch : UserControl
    {
        public UC_Switch()
        {
            InitializeComponent();
        }

        private bool encendido;

        public bool Encendido
        {
            get { return encendido; }
            set {
                if (value)
                {
                    pnlSwitch.Left = 30;
                    pnlSwitch.BackColor = Color.Green;
                }
                else
                {
                    pnlSwitch.Left = 2;
                    pnlSwitch.BackColor = Color.Red;
                }
                encendido = value; }
        }



        public string Texto { 
            get => lblTexto.Text; 
            set => lblTexto.Text = value; 
        }

        private void pnlSwitch_Click(object sender, EventArgs e)
        {
            Encendido = !Encendido;
        }
    }
}
