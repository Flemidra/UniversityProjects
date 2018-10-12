﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string Username = "Flemidra", Password = "Flemidra";
        public Form2()
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.TextAlign = HorizontalAlignment.Left;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            textBox2.Text = "";
            textBox2.TextAlign = HorizontalAlignment.Left;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void RetrievePassword_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Usuario Flemidra, Contraseña Flemidra.");
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Username && textBox2.Text == Password)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("El correo y/o contraseña es invalido");
            }
            
        }
    }
}
