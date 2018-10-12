using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class NewItemDebit : Form
    {
        public NewItemDebit(int option)
        {
            InitializeComponent();
            if (option == 2)
                //En caso de no tener saldo de contado, se solicita las mensualidades a pagar
                label3.Text = ("Pago de Mensualidades");
        }
       
        private void TopHeader_MouseMove(object sender, MouseEventArgs e)
        {
            //Metodos para mover la ventana utilizando el panel superior.
            NativeMethods.ReleaseCaptureAction(); // Mueve la pestana utilizando el mouse
            NativeMethods.SendMessageAction(this.Handle,   0x112,  0xF012, 0);// Mueve la pestana utilizando el mouse
        }
    }
}
