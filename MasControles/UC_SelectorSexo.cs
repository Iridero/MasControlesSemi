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
    public enum Sexos { Masculino, Femenino};
    public partial class UC_SelectorSexo : UserControl
    {
        public event EventHandler<SelectorSexoEventArgs> SexoActualizado;

        private Sexos sexo;

        public Sexos Sexo
        {
            get { return sexo; }
            set {
                if (value==Sexos.Masculino)
                {
                    btnSexo.Text = "♂";
                    btnSexo.ForeColor = Color.RoyalBlue;
                    SexoActualizado?.Invoke(this, new SelectorSexoEventArgs(value));
                }
                else
                {
                    btnSexo.Text = "♀";
                    btnSexo.ForeColor = Color.HotPink;
                    SexoActualizado?.Invoke(this, new SelectorSexoEventArgs(value));
                }
                sexo = value; 
            }
        }

        public UC_SelectorSexo()
        {
            InitializeComponent();
        }

        private void btnSexo_Click(object sender, EventArgs e)
        {
            if (sexo==Sexos.Masculino)
            {
                Sexo = Sexos.Femenino;
            }
            else
            {
                Sexo = Sexos.Masculino;
            }
        }
    }
    public class SelectorSexoEventArgs : EventArgs
    {
        public Sexos Sexo { get; set; }
        public SelectorSexoEventArgs()
        {

        }
        public SelectorSexoEventArgs(Sexos sexo)
        {
            Sexo = sexo;
        }
    }
}
