namespace WindowsFormsApp2
{
    partial class CalculoTir
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoTir));
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Leyenda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BackGroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.Color.SlateGray;
            this.BackGroundPanel.Controls.Add(this.pictureBox4);
            this.BackGroundPanel.Controls.Add(this.textBox5);
            this.BackGroundPanel.Controls.Add(this.pictureBox3);
            this.BackGroundPanel.Controls.Add(this.label4);
            this.BackGroundPanel.Controls.Add(this.textBox4);
            this.BackGroundPanel.Controls.Add(this.textBox2);
            this.BackGroundPanel.Controls.Add(this.Leyenda);
            this.BackGroundPanel.Controls.Add(this.pictureBox2);
            this.BackGroundPanel.Controls.Add(this.textBox1);
            this.BackGroundPanel.Controls.Add(this.label2);
            this.BackGroundPanel.Controls.Add(this.pictureBox1);
            this.BackGroundPanel.Controls.Add(this.dataGridView1);
            this.BackGroundPanel.Controls.Add(this.button3);
            this.BackGroundPanel.Controls.Add(this.label1);
            this.BackGroundPanel.Controls.Add(this.label15);
            this.BackGroundPanel.Controls.Add(this.label8);
            this.BackGroundPanel.Controls.Add(this.button1);
            this.BackGroundPanel.Controls.Add(this.label3);
            this.BackGroundPanel.Controls.Add(this.textBox3);
            this.BackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(880, 505);
            this.BackGroundPanel.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SlateGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox5.Location = new System.Drawing.Point(659, 112);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(243, 107);
            this.textBox5.TabIndex = 58;
            this.textBox5.Text = "Año / mes del flujo de efectivo\r\nInversion Inicial\r\nCriterio de seleccion de proy" +
    "ecto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(128, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "K";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(125, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(59, 20);
            this.textBox4.TabIndex = 55;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(583, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(271, 107);
            this.textBox2.TabIndex = 54;
            this.textBox2.Text = "Periodo: \r\n\r\nIo: \r\nK: ";
            // 
            // Leyenda
            // 
            this.Leyenda.AutoSize = true;
            this.Leyenda.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leyenda.ForeColor = System.Drawing.Color.White;
            this.Leyenda.Location = new System.Drawing.Point(684, 81);
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.Size = new System.Drawing.Size(89, 28);
            this.Leyenda.TabIndex = 53;
            this.Leyenda.Text = "Leyenda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(237, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(22, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(717, 19);
            this.textBox1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Decision";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.Columna2});
            this.dataGridView1.Location = new System.Drawing.Point(289, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 227);
            this.dataGridView1.TabIndex = 48;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Periodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Periodo.Width = 50;
            // 
            // Columna2
            // 
            this.Columna2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columna2.HeaderText = "Flujo de Efectivo";
            this.Columna2.Name = "Columna2";
            this.Columna2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Columna2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Flujo de Efectivo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(603, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(549, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "TIR =";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(289, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tasa Interna de Retorno";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(125, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(785, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // CalculoTir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 505);
            this.Controls.Add(this.BackGroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculoTir";
            this.Text = "Form3";
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Leyenda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

