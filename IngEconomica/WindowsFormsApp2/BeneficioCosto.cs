using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class BeneficioCosto : Form
    {
        public BeneficioCosto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = Convert.ToDouble(textBox3.Text);
                dataGridView1.Rows.Add(dataGridView1.RowCount, tmp);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"El valor introducido es invalido. " + exception);
            }
                textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) && !String.IsNullOrEmpty(textBox7.Text))
            {
                double aux = Convert.ToDouble(textBox5.Text) / (Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox7.Text));
                label15.Text = Convert.ToString(aux, CultureInfo.InvariantCulture);
                if (aux >= 1)
                {
                    textBox1.Text = @"El proyecto es rentable, ya que los beneficios seran superiores a los costos de la inversion.";
                }
                else
                {
                    textBox1.Text = @"El proyecto no es rentable, ya que los beneficios seran menores o iguales a los costos de la inversion.";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"El análisis costo-beneficio es una herramienta financiera que mide la relación entre los costos y beneficios asociados a un proyecto de inversión con el fin de evaluar su rentabilidad.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var tmp = Convert.ToDouble(textBox2.Text);
                dataGridView2.Rows.Add(dataGridView2.RowCount, tmp);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"El valor introducido es invalido. " + exception);
            }
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tmp = new double[dataGridView1.RowCount];

            for (var i = 0; i < dataGridView1.RowCount; i++)
            {
                tmp[i] = Convert.ToDouble(dataGridView1[1, i].Value.ToString());
            }

            if (tmp.Length > 0)
            {
                if (!String.IsNullOrEmpty(textBox4.Text))
                {
                    double tir = Financial.NPV((Convert.ToDouble(textBox4.Text) / 100), ref tmp);
                    textBox5.Text = tir.ToString("#.###");
                }
            }

            var tmp2 = new double[dataGridView2.RowCount];
            for (var i = 0; i < dataGridView2.RowCount; i++)
            {
                tmp2[i] = Convert.ToDouble(dataGridView2[1, i].Value.ToString());
            }

            if (tmp2.Length > 0)
            {
                if (!String.IsNullOrEmpty(textBox4.Text))
                {
                    double tir = Financial.NPV((Convert.ToDouble(textBox4.Text) / 100), ref tmp2);
                    textBox6.Text = tir.ToString("#.###");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Primero debera llevar rellenar los dos recuadros de costos beneficios, colocar los datos de interes e inversion inicial. Y por ultimo debera generar el Valor Actual Neto de ingresos y costos, presionando los botones Calcular! y Calcular B/C (En ese orden)");
        }
    }
}
