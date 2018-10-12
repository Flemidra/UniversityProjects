using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class ValorPresenteNeto : Form
    {
        public ValorPresenteNeto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = Convert.ToDouble(textBox3.Text);

                if (dataGridView1.RowCount == 0)
                {
                    if (tmp > 0)
                    {
                        tmp = tmp * -1;
                    }
                    dataGridView1.Rows.Add("Io", tmp);
                }
                else
                {
                    dataGridView1.Rows.Add(dataGridView1.RowCount, tmp);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"El valor introducido es invalido. " + exception);
            }
                textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmp = new double[dataGridView1.RowCount];

            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                tmp[i] = Convert.ToDouble(dataGridView1[1, i].Value.ToString());
            }

            if (tmp.Length > 1)
            {
                if (!String.IsNullOrEmpty(textBox4.Text))
                {
                    double tir = Financial.NPV((Convert.ToDouble(textBox4.Text) / 100), ref tmp);
                    label15.Text = tir.ToString("#.###") + @"%";
                    if (tir * 100 > 0)
                    {
                        textBox1.Text = @"Se debera realizar la inversion, ya que el valor resultante es positivo y superior a 0.";

                    }
                    else
                    {
                    textBox1.Text = @"No se debera realizar la inversion, ya que el valor resultante es menor .";

                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El Valor Presente Neto permite determinar si una inversión cumple con el objetivo básico financiero: MAXIMIZAR la inversión. El Valor Presente Neto permite determinar si dicha inversión puede incrementar o reducir el valor de la empresa. Ese cambio en el valor estimado puede ser positivo, negativo o continuar igual. Si es positivo significará que el valor de la firma tendrá un incremento equivalente al monto del Valor Presente Neto.  Si es negativo quiere decir que la firma reducirá su riqueza en el valor que arroje el VPN.  Si el resultado del VPN es cero, la empresa no modificará el monto de su valor.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El flujo de efectivo es la resta entre el total de ingresos de un periodo menos el total de egresos del mismo periodo");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El valor de la inversion inicial se representa en negativo ya que es un gasto realizado por el inversionista, es decir, es una disminucion del capital inicial de la persona.");
        }
    }
}
