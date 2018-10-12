namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TopHeader = new System.Windows.Forms.Panel();
            this.RestoreWindow = new System.Windows.Forms.Button();
            this.Shrink = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Log_In = new System.Windows.Forms.Button();
            this.DecorativePanel1 = new System.Windows.Forms.Panel();
            this.RetrievePassword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.TopHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopHeader
            // 
            this.TopHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.TopHeader.Controls.Add(this.RestoreWindow);
            this.TopHeader.Controls.Add(this.Shrink);
            this.TopHeader.Controls.Add(this.Close);
            this.TopHeader.Controls.Add(this.Maximize);
            this.TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(500, 35);
            this.TopHeader.TabIndex = 0;
            this.TopHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopHeader_MouseMove);
            // 
            // RestoreWindow
            // 
            this.RestoreWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestoreWindow.BackgroundImage")));
            this.RestoreWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RestoreWindow.FlatAppearance.BorderSize = 0;
            this.RestoreWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RestoreWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RestoreWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreWindow.Location = new System.Drawing.Point(425, 0);
            this.RestoreWindow.Name = "RestoreWindow";
            this.RestoreWindow.Size = new System.Drawing.Size(35, 35);
            this.RestoreWindow.TabIndex = 3;
            this.RestoreWindow.UseVisualStyleBackColor = true;
            this.RestoreWindow.Visible = false;
            this.RestoreWindow.Click += new System.EventHandler(this.RestoreWindow_Click);
            // 
            // Shrink
            // 
            this.Shrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Shrink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shrink.BackgroundImage")));
            this.Shrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Shrink.FlatAppearance.BorderSize = 0;
            this.Shrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Shrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Shrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shrink.Location = new System.Drawing.Point(390, 0);
            this.Shrink.Name = "Shrink";
            this.Shrink.Size = new System.Drawing.Size(35, 35);
            this.Shrink.TabIndex = 2;
            this.Shrink.UseVisualStyleBackColor = true;
            this.Shrink.Click += new System.EventHandler(this.Shrink_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(461, -1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 35);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximize.BackgroundImage")));
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Location = new System.Drawing.Point(425, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(35, 35);
            this.Maximize.TabIndex = 1;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(189, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 265);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox2.Location = new System.Drawing.Point(53, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox1.Location = new System.Drawing.Point(53, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Email";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(14, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(153, 93);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Log_In
            // 
            this.Log_In.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Log_In.FlatAppearance.BorderSize = 0;
            this.Log_In.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Log_In.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Log_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_In.ForeColor = System.Drawing.Color.White;
            this.Log_In.Image = global::WindowsFormsApp2.Properties.Resources.reportes;
            this.Log_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Log_In.Location = new System.Drawing.Point(3, 113);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(220, 50);
            this.Log_In.TabIndex = 0;
            this.Log_In.Text = "Log In";
            this.Log_In.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Log_In.UseVisualStyleBackColor = true;
            this.Log_In.Click += new System.EventHandler(this.Log_In_Click);
            this.Log_In.Enter += new System.EventHandler(this.Log_In_Click);
            // 
            // DecorativePanel1
            // 
            this.DecorativePanel1.BackColor = System.Drawing.Color.Cyan;
            this.DecorativePanel1.Location = new System.Drawing.Point(3, 123);
            this.DecorativePanel1.Name = "DecorativePanel1";
            this.DecorativePanel1.Size = new System.Drawing.Size(5, 40);
            this.DecorativePanel1.TabIndex = 0;
            // 
            // RetrievePassword
            // 
            this.RetrievePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RetrievePassword.FlatAppearance.BorderSize = 0;
            this.RetrievePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RetrievePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.RetrievePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetrievePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrievePassword.ForeColor = System.Drawing.Color.White;
            this.RetrievePassword.Image = ((System.Drawing.Image)(resources.GetObject("RetrievePassword.Image")));
            this.RetrievePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RetrievePassword.Location = new System.Drawing.Point(0, 169);
            this.RetrievePassword.Name = "RetrievePassword";
            this.RetrievePassword.Size = new System.Drawing.Size(220, 50);
            this.RetrievePassword.TabIndex = 3;
            this.RetrievePassword.Text = "Forget Password";
            this.RetrievePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RetrievePassword.UseVisualStyleBackColor = true;
            this.RetrievePassword.Click += new System.EventHandler(this.RetrievePassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 2;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.RetrievePassword);
            this.PanelMenu.Controls.Add(this.DecorativePanel1);
            this.PanelMenu.Controls.Add(this.Log_In);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 35);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(189, 265);
            this.PanelMenu.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.TopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.TopHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopHeader;
        private System.Windows.Forms.Button Shrink;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button RestoreWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Panel DecorativePanel1;
        private System.Windows.Forms.Button RetrievePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

