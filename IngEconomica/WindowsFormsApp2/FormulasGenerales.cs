using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormulasGenerales : Form
    {
        public FormulasGenerales()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            float aux, auxb, auxc;
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                //(P/F, i, n)
                aux = Convert.ToSingle(textBox3.Text.Trim());
                auxb = Convert.ToSingle(textBox2.Text.Trim());
                auxc = Convert.ToSingle(textBox1.Text.Trim());
                auxb = auxb / 100;
                label15.Text = Convert.ToString(aux * (1 / (Math.Pow((auxb + 1), auxc))), CultureInfo.InvariantCulture);
            }

            if ((textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                //(F/P, i, n)
                aux = Convert.ToSingle(textBox4.Text.Trim());
                auxb = Convert.ToSingle(textBox5.Text.Trim());
                auxc = Convert.ToSingle(textBox6.Text.Trim());
                auxb = auxb / 100;
                label16.Text = Convert.ToString(aux * Math.Pow((auxb + 1), auxc), CultureInfo.InvariantCulture);
            }

            if ((textBox7.Text != "") && (textBox8.Text != "") && (textBox9.Text != ""))
            {
                //(P/A, i ,n)
                aux = Convert.ToSingle(textBox7.Text.Trim());
                auxb = Convert.ToSingle(textBox8.Text.Trim());
                auxc = Convert.ToSingle(textBox9.Text.Trim());
                auxb = auxb / 100;
                label17.Text = Convert.ToString(aux * (Math.Pow((auxb+1),auxc)-1)/(auxb * (Math.Pow((auxb+1),auxc))), CultureInfo.InvariantCulture);
            }

            if ((textBox10.Text != "") && (textBox11.Text != "") && (textBox12.Text != ""))
            {
                //(A/P, i ,n)
                aux = Convert.ToSingle(textBox10.Text.Trim());
                auxb = Convert.ToSingle(textBox11.Text.Trim());
                auxc = Convert.ToSingle(textBox12.Text.Trim());
                auxb = auxb / 100;
                label18.Text = Convert.ToString(aux * (auxb * (Math.Pow((auxb + 1), auxc))) / (Math.Pow((auxb + 1), auxc) - 1), CultureInfo.InvariantCulture);
            }

            if ((textBox13.Text != "") && (textBox14.Text != "") && (textBox15.Text != ""))
            {
                //(F/A, i ,n)
                aux = Convert.ToSingle(textBox13.Text.Trim());
                auxb = Convert.ToSingle(textBox14.Text.Trim());
                auxc = Convert.ToSingle(textBox15.Text.Trim());
                auxb = auxb / 100;
                label19.Text = Convert.ToString(aux * ((Math.Pow((auxb+1), auxc)-1)/auxb), CultureInfo.InvariantCulture);
            }

            if ((textBox16.Text != "") && (textBox17.Text != "") && (textBox18.Text != ""))
            {
                //(A/F, i ,n)
                aux = Convert.ToSingle(textBox16.Text.Trim());
                auxb = Convert.ToSingle(textBox17.Text.Trim());
                auxc = Convert.ToSingle(textBox18.Text.Trim());
                auxb = auxb / 100;
                label20.Text = Convert.ToString(aux * (auxb / (Math.Pow((auxb + 1), auxc) - 1)), CultureInfo.InvariantCulture);
            }

            if ((textBox19.Text != "") && (textBox20.Text != "") && (textBox21.Text != ""))
            {
                //(P/G, i ,n)
                aux = Convert.ToSingle(textBox19.Text.Trim());
                auxb = Convert.ToSingle(textBox20.Text.Trim());
                auxc = Convert.ToSingle(textBox21.Text.Trim());
                auxb = auxb / 100;
                label21.Text = Convert.ToString(aux * ((Math.Pow((auxb+1), auxc) - auxb * auxc - 1)/ (Math.Pow(auxb,2)* Math.Pow((auxb+1),auxc))), CultureInfo.InvariantCulture);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular el valor presente." + "\n" +
                            @"F: Valor en el futuro." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular el valor futuro." + "\n" +
                            @"P: Valor presente o pago de contado." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular los pagos uniformes en el presente." + "\n" +
                            @"A: Pagos o mensualidades." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular el valor presente tomando como base una serie de pagos uniformes." + "\n" +
                            @"P: Valor presente o pago de contado." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular el valor futuro tomando como base una serie de pagos uniformes." + "\n" +
                            @"A: Pagos o mensualidades." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular una serie de pagos uniformes tomando como base un valor futuros." + "\n" +
                            @"F: Valor en el futuro." + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Esta formula sirve para calcular el gradiente o depreciacion tomando como base un valor presente." + "\n" +
                            @"G: Gradiente o depreciacion" + "\n" +
                            @"I: Porcentaje de Interes." + "\n" +
                            @"N: Numero de periodos a tomar en cuenta.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Si necesita ayuda, puede hacer click en cada una de las formulas, en el cual le mostrara un mensaje indicando que significa cada elemento y su utilizacion.");
        }
    }
}
