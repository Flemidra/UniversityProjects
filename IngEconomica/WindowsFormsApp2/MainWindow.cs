using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        

        private void Close_Click(object sender, EventArgs e)
        {
            //Boton cerrar
            Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            //Maximizar ventana
            Maximize.Visible = false;
            RestoreWindow.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            //Restaurar Pestaña
            RestoreWindow.Visible = false;
            Maximize.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void Shrink_Click(object sender, EventArgs e)
        {
            //Minimizar
            WindowState = FormWindowState.Minimized;
        }

        private void TopHeader_MouseMove(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCaptureAction(); // Mueve la pestana utilizando el mouse
            NativeMethods.SendMessageAction(Handle,   0x112,  0xF012, 0);// Mueve la pestana utilizando el mouse
        }

        private void ShowMenu_Tick(object sender, EventArgs e)
        {
            //Contador para la animacion de apertura del menu
            {
                if (PanelMenu.Width >= 220)
                {
                    HideMenu.Enabled = false;
                }
                else
                    PanelMenu.Width = PanelMenu.Width + 10;
            }
        }

        private void HideMenu_Tick(object sender, EventArgs e)
        {
            //Contador para la animacion de cerrado del menu
            {
                if (PanelMenu.Width <= 60)
                    ShowMenu.Enabled = false;
                else
                    PanelMenu.Width = PanelMenu.Width - 10;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            //Boton para ocultar y mostrar menu hamburguesa
            HideMenu.Enabled = false;
            ShowMenu.Enabled = false;
            if (PanelMenu.Width == 220)
            {
              HideMenu.Enabled = true;
            }
            else
            {
                if (PanelMenu.Width == 60)
                {
                   ShowMenu.Enabled = true;
                }
            }
        }
       private void OpenAtContentPanel(object formhijo)
       {
           //Creacion de nuevo contenido dentro del panel central del MainMenu
           if (panel1.Controls.Count > 0)
               panel1.Controls.RemoveAt(0);
           if (formhijo is Form fh)
           {
               fh.TopLevel = false;
               fh.FormBorderStyle = FormBorderStyle.None;
               fh.Dock = DockStyle.Fill;
               panel1.Controls.Add(fh);
               panel1.Tag = fh;
               fh.Show();
           }
       }

        private void Dashboard_Click(object sender, EventArgs e)
        {
                OpenAtContentPanel(new FormulasGenerales());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Copyright (©) 2015 - 2022 Flemidra. All Rights Reserved");
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            OpenAtContentPanel(new ValorPresenteNeto());
        }

        private void Products_Click(object sender, EventArgs e)
        {
            OpenAtContentPanel(new CalculoTir());
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            OpenAtContentPanel(new BeneficioCosto());
        }
    }
}
