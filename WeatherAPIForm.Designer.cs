namespace WeatherAPI
{
    partial class WeatherAPIForm
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
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFeels = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXML
            // 
            this.btnXML.BackColor = System.Drawing.Color.Teal;
            this.btnXML.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXML.Location = new System.Drawing.Point(31, 29);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(308, 40);
            this.btnXML.TabIndex = 0;
            this.btnXML.Text = "Get Weather (XML)";
            this.btnXML.UseVisualStyleBackColor = false;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.BackColor = System.Drawing.Color.Teal;
            this.btnJSON.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJSON.ForeColor = System.Drawing.SystemColors.Window;
            this.btnJSON.Location = new System.Drawing.Point(31, 88);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(308, 40);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = "Get Weather (JSON)";
            this.btnJSON.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a zip code:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(31, 148);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(308, 20);
            this.txtZip.TabIndex = 3;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Info;
            this.txtCity.Enabled = false;
            this.txtCity.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCity.Location = new System.Drawing.Point(31, 189);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(308, 20);
            this.txtCity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // txtLatitude
            // 
            this.txtLatitude.BackColor = System.Drawing.SystemColors.Info;
            this.txtLatitude.Enabled = false;
            this.txtLatitude.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLatitude.Location = new System.Drawing.Point(31, 234);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(150, 20);
            this.txtLatitude.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.BackColor = System.Drawing.SystemColors.Info;
            this.txtLongitude.Enabled = false;
            this.txtLongitude.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLongitude.Location = new System.Drawing.Point(189, 234);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(150, 20);
            this.txtLongitude.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Longitude";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.SystemColors.Info;
            this.txtTemp.Enabled = false;
            this.txtTemp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTemp.Location = new System.Drawing.Point(31, 283);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(70, 20);
            this.txtTemp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Temperature";
            // 
            // txtLow
            // 
            this.txtLow.BackColor = System.Drawing.SystemColors.Info;
            this.txtLow.Enabled = false;
            this.txtLow.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLow.Location = new System.Drawing.Point(111, 283);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(70, 20);
            this.txtLow.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Low";
            // 
            // txtHigh
            // 
            this.txtHigh.BackColor = System.Drawing.SystemColors.Info;
            this.txtHigh.Enabled = false;
            this.txtHigh.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHigh.Location = new System.Drawing.Point(189, 283);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(70, 20);
            this.txtHigh.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "High";
            // 
            // txtFeels
            // 
            this.txtFeels.BackColor = System.Drawing.SystemColors.Info;
            this.txtFeels.Enabled = false;
            this.txtFeels.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFeels.Location = new System.Drawing.Point(269, 283);
            this.txtFeels.Name = "txtFeels";
            this.txtFeels.Size = new System.Drawing.Size(70, 20);
            this.txtFeels.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Feels like";
            // 
            // txtClouds
            // 
            this.txtClouds.BackColor = System.Drawing.SystemColors.Info;
            this.txtClouds.Enabled = false;
            this.txtClouds.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClouds.Location = new System.Drawing.Point(189, 329);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(150, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Clouds";
            // 
            // txtWind
            // 
            this.txtWind.BackColor = System.Drawing.SystemColors.Info;
            this.txtWind.Enabled = false;
            this.txtWind.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWind.Location = new System.Drawing.Point(31, 329);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(150, 20);
            this.txtWind.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Wind";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(264, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WeatherAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(368, 426);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFeels);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.btnXML);
            this.Name = "WeatherAPIForm";
            this.Text = "What\'s the weather like?";
            this.Load += new System.EventHandler(this.WeatherAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFeels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
    }
}

