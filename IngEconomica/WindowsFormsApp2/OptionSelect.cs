using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OptionSelect : Form
    {
        private int Option = 0;
        public OptionSelect()
        {
            InitializeComponent();
        }

        private void TopHeader_MouseMove(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCaptureAction(); // Mueve la pestana utilizando el mouse
            NativeMethods.SendMessageAction(this.Handle,   0x112,  0xF012, 0);// Mueve la pestana utilizando el mouse
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Posee pago de contado
            Option = 1;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Posee mensualidades
            Option = 2;
            this.Hide();
        }

        public int GetOption()
        {
            //Retorna el valor de la opcion
            return (Option);
        }
    }
}
