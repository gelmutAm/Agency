namespace Agency.WinFormsPL
{
    partial class SaleForm
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
            this.SaledataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SaledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaledataGridView
            // 
            this.SaledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaledataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaledataGridView.Location = new System.Drawing.Point(0, 0);
            this.SaledataGridView.Name = "SaledataGridView";
            this.SaledataGridView.Size = new System.Drawing.Size(800, 450);
            this.SaledataGridView.TabIndex = 0;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaledataGridView);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            ((System.ComponentModel.ISupportInitialize)(this.SaledataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SaledataGridView;
    }
}