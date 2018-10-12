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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            Maximize.Visible = false;
            RestoreWindow.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            RestoreWindow.Visible = false;
            Maximize.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void Shrink_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopHeader_MouseMove(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCaptureAction(); // Mueve la pestana utilizando el mouse
            NativeMethods.SendMessageAction(this.Handle,   0x112,  0xF012, 0);// Mueve la pestana utilizando el mouse
        }

        private void ShowMenu_Tick(object sender, EventArgs e)
        {
            {
                if (PanelMenu.Width >= 220)
                {
                    this.HideMenu.Enabled = false;
                }
                else
                    this.PanelMenu.Width = PanelMenu.Width + 10;
            }
        }

        private void HideMenu_Tick(object sender, EventArgs e)
        {
            {
                if (PanelMenu.Width <= 60)
                    this.ShowMenu.Enabled = false;
                else
                    this.PanelMenu.Width = PanelMenu.Width - 10;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
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
       private void OpenAtContentPanel(object Formhijo)
       {
           if (this.panel1.Controls.Count > 0)
               this.panel1.Controls.RemoveAt(0);
           Form fh = Formhijo as Form;
           fh.TopLevel = false;
           fh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           fh.Dock = DockStyle.Fill;
           this.panel1.Controls.Add(fh);
           this.panel1.Tag = fh;
           fh.Show();
       }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            OpenAtContentPanel(new Dashboard());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Copyright (©) 2015 - 2022 Flemidra. All Rights Reserved");
        }
    }
}
