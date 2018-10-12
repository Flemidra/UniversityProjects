namespace WindowsFormsApp2
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TopHeader = new System.Windows.Forms.Panel();
            this.RestoreWindow = new System.Windows.Forms.Button();
            this.Shrink = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Clients = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sell = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Products = new System.Windows.Forms.Button();
            this.DecorativePanel1 = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.ShowMenu = new System.Windows.Forms.Timer(this.components);
            this.HideMenu = new System.Windows.Forms.Timer(this.components);
            this.TopHeader.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
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
            this.TopHeader.Size = new System.Drawing.Size(1100, 35);
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
            this.RestoreWindow.Location = new System.Drawing.Point(1025, 0);
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
            this.Shrink.Location = new System.Drawing.Point(990, 0);
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
            this.Close.Location = new System.Drawing.Point(1061, -1);
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
            this.Maximize.Location = new System.Drawing.Point(1025, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(35, 35);
            this.Maximize.TabIndex = 1;
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 505);
            this.panel1.TabIndex = 2;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Controls.Add(this.panel6);
            this.PanelMenu.Controls.Add(this.User);
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Controls.Add(this.Clients);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.Sell);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.Products);
            this.PanelMenu.Controls.Add(this.DecorativePanel1);
            this.PanelMenu.Controls.Add(this.Dashboard);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Controls.Add(this.MenuButton);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 35);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 505);
            this.PanelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(0, 396);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 50);
            this.panel6.TabIndex = 9;
            this.panel6.Visible = false;
            // 
            // User
            // 
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.User.Enabled = false;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(2, 396);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(220, 50);
            this.User.TabIndex = 11;
            this.User.Text = " Ficha Tecnica";
            this.User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.User.UseVisualStyleBackColor = true;
            this.User.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Location = new System.Drawing.Point(0, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 50);
            this.panel4.TabIndex = 6;
            // 
            // Clients
            // 
            this.Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clients.FlatAppearance.BorderSize = 0;
            this.Clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.ForeColor = System.Drawing.Color.White;
            this.Clients.Image = ((System.Drawing.Image)(resources.GetObject("Clients.Image")));
            this.Clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clients.Location = new System.Drawing.Point(2, 322);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(220, 50);
            this.Clients.TabIndex = 7;
            this.Clients.Text = "Beneficio/Costo";
            this.Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(0, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 50);
            this.panel3.TabIndex = 4;
            // 
            // Sell
            // 
            this.Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sell.FlatAppearance.BorderSize = 0;
            this.Sell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Sell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell.ForeColor = System.Drawing.Color.White;
            this.Sell.Image = ((System.Drawing.Image)(resources.GetObject("Sell.Image")));
            this.Sell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sell.Location = new System.Drawing.Point(2, 263);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(220, 50);
            this.Sell.TabIndex = 5;
            this.Sell.Text = "Valor Actual Neto";
            this.Sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 2;
            // 
            // Products
            // 
            this.Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Products.FlatAppearance.BorderSize = 0;
            this.Products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Image = ((System.Drawing.Image)(resources.GetObject("Products.Image")));
            this.Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.Location = new System.Drawing.Point(2, 205);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(220, 50);
            this.Products.TabIndex = 3;
            this.Products.Text = "Tasa Interna de Retorno";
            this.Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // DecorativePanel1
            // 
            this.DecorativePanel1.BackColor = System.Drawing.Color.Cyan;
            this.DecorativePanel1.Location = new System.Drawing.Point(0, 148);
            this.DecorativePanel1.Name = "DecorativePanel1";
            this.DecorativePanel1.Size = new System.Drawing.Size(5, 50);
            this.DecorativePanel1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = global::WindowsFormsApp2.Properties.Resources.reportes;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(2, 148);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(220, 50);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Formulas Generales";
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(13, 45);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(217, 93);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Mobile_Menu_Icon;
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuButton.Location = new System.Drawing.Point(163, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(55, 40);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ShowMenu
            // 
            this.ShowMenu.Interval = 40;
            this.ShowMenu.Tick += new System.EventHandler(this.ShowMenu_Tick);
            // 
            // HideMenu
            // 
            this.HideMenu.Interval = 40;
            this.HideMenu.Tick += new System.EventHandler(this.HideMenu_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.TopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.TopHeader.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopHeader;
        private System.Windows.Forms.Button Shrink;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Button RestoreWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Timer ShowMenu;
        private System.Windows.Forms.Timer HideMenu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel DecorativePanel1;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

