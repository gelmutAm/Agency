namespace Agency.WinFormsPL
{
    partial class MainForm
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
            this.btn_House = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_Agent = new System.Windows.Forms.Button();
            this.btn_Street = new System.Windows.Forms.Button();
            this.btn_Area = new System.Windows.Forms.Button();
            this.btn_City = new System.Windows.Forms.Button();
            this.btn_RentSale = new System.Windows.Forms.Button();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_House
            // 
            this.btn_House.Location = new System.Drawing.Point(171, 194);
            this.btn_House.Name = "btn_House";
            this.btn_House.Size = new System.Drawing.Size(75, 23);
            this.btn_House.TabIndex = 0;
            this.btn_House.Text = "Дома";
            this.btn_House.UseVisualStyleBackColor = true;
            this.btn_House.Click += new System.EventHandler(this.btn_House_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(43, 81);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(75, 23);
            this.btn_Client.TabIndex = 2;
            this.btn_Client.Text = "Клиенты";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // btn_Agent
            // 
            this.btn_Agent.Location = new System.Drawing.Point(43, 24);
            this.btn_Agent.Name = "btn_Agent";
            this.btn_Agent.Size = new System.Drawing.Size(75, 23);
            this.btn_Agent.TabIndex = 3;
            this.btn_Agent.Text = "Агенты";
            this.btn_Agent.UseVisualStyleBackColor = true;
            this.btn_Agent.Click += new System.EventHandler(this.btn_Agent_Click);
            // 
            // btn_Street
            // 
            this.btn_Street.Location = new System.Drawing.Point(171, 138);
            this.btn_Street.Name = "btn_Street";
            this.btn_Street.Size = new System.Drawing.Size(75, 23);
            this.btn_Street.TabIndex = 4;
            this.btn_Street.Text = "Улицы";
            this.btn_Street.UseVisualStyleBackColor = true;
            this.btn_Street.Click += new System.EventHandler(this.btn_Street_Click);
            // 
            // btn_Area
            // 
            this.btn_Area.Location = new System.Drawing.Point(171, 81);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Size = new System.Drawing.Size(75, 23);
            this.btn_Area.TabIndex = 5;
            this.btn_Area.Text = "Районы";
            this.btn_Area.UseVisualStyleBackColor = true;
            this.btn_Area.Click += new System.EventHandler(this.btn_Area_Click);
            // 
            // btn_City
            // 
            this.btn_City.Location = new System.Drawing.Point(171, 24);
            this.btn_City.Name = "btn_City";
            this.btn_City.Size = new System.Drawing.Size(75, 23);
            this.btn_City.TabIndex = 6;
            this.btn_City.Text = "Города";
            this.btn_City.UseVisualStyleBackColor = true;
            this.btn_City.Click += new System.EventHandler(this.btn_City_Click);
            // 
            // btn_RentSale
            // 
            this.btn_RentSale.Location = new System.Drawing.Point(287, 81);
            this.btn_RentSale.Name = "btn_RentSale";
            this.btn_RentSale.Size = new System.Drawing.Size(75, 38);
            this.btn_RentSale.TabIndex = 8;
            this.btn_RentSale.Text = "Сдается в аренду";
            this.btn_RentSale.UseVisualStyleBackColor = true;
            this.btn_RentSale.Click += new System.EventHandler(this.btn_RentSale_Click);
            // 
            // btn_Sale
            // 
            this.btn_Sale.Location = new System.Drawing.Point(287, 24);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(75, 23);
            this.btn_Sale.TabIndex = 9;
            this.btn_Sale.Text = "Продажа";
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.btn_Sale);
            this.Controls.Add(this.btn_RentSale);
            this.Controls.Add(this.btn_City);
            this.Controls.Add(this.btn_Area);
            this.Controls.Add(this.btn_Street);
            this.Controls.Add(this.btn_Agent);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.btn_House);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_House;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button btn_Agent;
        private System.Windows.Forms.Button btn_Street;
        private System.Windows.Forms.Button btn_Area;
        private System.Windows.Forms.Button btn_City;
        private System.Windows.Forms.Button btn_RentSale;
        private System.Windows.Forms.Button btn_Sale;
    }
}