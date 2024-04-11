namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LocationTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ButtonSearch = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Data8 = new System.Windows.Forms.Label();
            this.Data9 = new System.Windows.Forms.Label();
            this.Data10 = new System.Windows.Forms.Label();
            this.Data3 = new System.Windows.Forms.Label();
            this.Data7 = new System.Windows.Forms.Label();
            this.Data1 = new System.Windows.Forms.Label();
            this.Data2 = new System.Windows.Forms.Label();
            this.Data5 = new System.Windows.Forms.Label();
            this.Data4 = new System.Windows.Forms.Label();
            this.Data6 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1.SuspendLayout();
            this.siticoneGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Animated = true;
            this.LocationTextBox.AutoRoundedCorners = true;
            this.LocationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LocationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.LocationTextBox.BorderRadius = 21;
            this.LocationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocationTextBox.DefaultText = "";
            this.LocationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LocationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LocationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LocationTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.LocationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.LocationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LocationTextBox.Location = new System.Drawing.Point(12, 12);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.PasswordChar = '\0';
            this.LocationTextBox.PlaceholderText = "Location";
            this.LocationTextBox.SelectedText = "";
            this.LocationTextBox.Size = new System.Drawing.Size(770, 45);
            this.LocationTextBox.TabIndex = 0;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            this.LocationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LocationTextBox_KeyDown);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Animated = true;
            this.ButtonSearch.AutoRoundedCorners = true;
            this.ButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch.BorderRadius = 21;
            this.ButtonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Location = new System.Drawing.Point(789, 12);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(180, 45);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderRadius = 20;
            this.siticoneGradientPanel1.Controls.Add(this.ButtonSearch);
            this.siticoneGradientPanel1.Controls.Add(this.LocationTextBox);
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(980, 69);
            this.siticoneGradientPanel1.TabIndex = 2;
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel2.BorderRadius = 20;
            this.siticoneGradientPanel2.Controls.Add(this.pictureBox1);
            this.siticoneGradientPanel2.Controls.Add(this.Data8);
            this.siticoneGradientPanel2.Controls.Add(this.Data9);
            this.siticoneGradientPanel2.Controls.Add(this.Data10);
            this.siticoneGradientPanel2.Controls.Add(this.Data3);
            this.siticoneGradientPanel2.Controls.Add(this.Data7);
            this.siticoneGradientPanel2.Controls.Add(this.Data1);
            this.siticoneGradientPanel2.Controls.Add(this.Data2);
            this.siticoneGradientPanel2.Controls.Add(this.Data5);
            this.siticoneGradientPanel2.Controls.Add(this.Data4);
            this.siticoneGradientPanel2.Controls.Add(this.Data6);
            this.siticoneGradientPanel2.Controls.Add(this.Location);
            this.siticoneGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(1, 76);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(980, 370);
            this.siticoneGradientPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(945, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // Data8
            // 
            this.Data8.AutoSize = true;
            this.Data8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data8.Location = new System.Drawing.Point(500, 205);
            this.Data8.Name = "Data8";
            this.Data8.Size = new System.Drawing.Size(121, 25);
            this.Data8.TabIndex = 1;
            this.Data8.Text = "Cloud Cover:";
            // 
            // Data9
            // 
            this.Data9.AutoSize = true;
            this.Data9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data9.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data9.Location = new System.Drawing.Point(35, 275);
            this.Data9.Name = "Data9";
            this.Data9.Size = new System.Drawing.Size(173, 25);
            this.Data9.TabIndex = 1;
            this.Data9.Text = "Observation Time:";
            // 
            // Data10
            // 
            this.Data10.AutoSize = true;
            this.Data10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data10.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data10.Location = new System.Drawing.Point(35, 310);
            this.Data10.Name = "Data10";
            this.Data10.Size = new System.Drawing.Size(276, 25);
            this.Data10.TabIndex = 1;
            this.Data10.Text = "Local Observation Date-Time:";
            // 
            // Data3
            // 
            this.Data3.AutoSize = true;
            this.Data3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data3.Location = new System.Drawing.Point(35, 170);
            this.Data3.Name = "Data3";
            this.Data3.Size = new System.Drawing.Size(242, 25);
            this.Data3.TabIndex = 1;
            this.Data3.Text = "Temperature (Feels Like):";
            // 
            // Data7
            // 
            this.Data7.AutoSize = true;
            this.Data7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data7.Location = new System.Drawing.Point(500, 170);
            this.Data7.Name = "Data7";
            this.Data7.Size = new System.Drawing.Size(147, 25);
            this.Data7.TabIndex = 1;
            this.Data7.Text = "Pressure (hPa):";
            // 
            // Data1
            // 
            this.Data1.AutoSize = true;
            this.Data1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data1.Location = new System.Drawing.Point(35, 100);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(96, 25);
            this.Data1.TabIndex = 1;
            this.Data1.Text = "Weather:";
            // 
            // Data2
            // 
            this.Data2.AutoSize = true;
            this.Data2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data2.Location = new System.Drawing.Point(35, 135);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(208, 25);
            this.Data2.TabIndex = 1;
            this.Data2.Text = "Temperature (Actual):";
            // 
            // Data5
            // 
            this.Data5.AutoSize = true;
            this.Data5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data5.Location = new System.Drawing.Point(500, 100);
            this.Data5.Name = "Data5";
            this.Data5.Size = new System.Drawing.Size(170, 25);
            this.Data5.TabIndex = 1;
            this.Data5.Text = "UV Index (1-12):";
            // 
            // Data4
            // 
            this.Data4.AutoSize = true;
            this.Data4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data4.Location = new System.Drawing.Point(35, 205);
            this.Data4.Name = "Data4";
            this.Data4.Size = new System.Drawing.Size(96, 25);
            this.Data4.TabIndex = 1;
            this.Data4.Text = "Humidity:";
            // 
            // Data6
            // 
            this.Data6.AutoSize = true;
            this.Data6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Data6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Data6.Location = new System.Drawing.Point(500, 135);
            this.Data6.Name = "Data6";
            this.Data6.Size = new System.Drawing.Size(64, 25);
            this.Data6.TabIndex = 1;
            this.Data6.Text = "Wind:";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.Location.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Location.Location = new System.Drawing.Point(35, 35);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(115, 32);
            this.Location.TabIndex = 1;
            this.Location.Text = "Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherApp 1.0.0";
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox LocationTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ButtonSearch;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label Data1;
        private System.Windows.Forms.Label Data2;
        private System.Windows.Forms.Label Data3;
        private System.Windows.Forms.Label Data4;
        private System.Windows.Forms.Label Data5;
        private System.Windows.Forms.Label Data6;
        private System.Windows.Forms.Label Data7;
        private System.Windows.Forms.Label Data8;
        private System.Windows.Forms.Label Data9;
        private System.Windows.Forms.Label Data10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}