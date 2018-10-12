using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class CalculoTir : Form
    {
        public CalculoTir()
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
                double tir = Financial.IRR(ref tmp, 0.3);
                label15.Text = (tir*100).ToString("#.###") + @"%";

                if (!String.IsNullOrEmpty(textBox4.Text))
                {
                    if (tir * 100 > Convert.ToDouble(textBox4.Text))
                    {
                        textBox1.Text = @"Se debera realizar la inversion, ya que el valor resultante es superior al valor de K.";

                    }
                    else
                    {
                    textBox1.Text = @"No se debera realizar la inversion, ya que el valor resultante es menor que el valor de K.";

                    }
                }
                else
                {
                    textBox1.Text = ("No se puede tomar una decision sin tener un criterio definido (K)");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"La Tasa Interna de Retorno (TIR) es la tasa de interés o rentabilidad que ofrece una inversión. Es decir, es el porcentaje de beneficio o pérdida que tendrá una inversión para las cantidades que no se han retirado del proyecto.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El flujo de efectivo es la resta entre el total de ingresos de un periodo menos el total de egresos del mismo periodo");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El criterio de seleccion es el porcentaje minimo que usted desea recibir para ser aceptable su proyecto.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"La inversion inicial es expresada en un valor negativo, ya que es un gasto que se realizo para hacer dicha inverson, es por ello que se coloca negativo.");
        }
    }
}
