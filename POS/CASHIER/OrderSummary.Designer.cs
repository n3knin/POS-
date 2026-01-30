namespace POS.CASHIER
{
    partial class OrderSummary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.separator.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPic
            // 
            this.logoPic.BackgroundImage = global::POS.Properties.Resources.posna_removebg_preview;
            this.logoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(300, 281);
            this.logoPic.TabIndex = 0;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.logoPic_Click_2);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.separator.Controls.Add(this.label2);
            this.separator.Controls.Add(this.label1);
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 281);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(300, 111);
            this.separator.TabIndex = 1;
            this.separator.Paint += new System.Windows.Forms.PaintEventHandler(this.separator_Paint_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "San Miguel, Tagum City, Davao del Norte\r\n8100\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "COP - Cash On Point";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.contentPanel.Controls.Add(this.comboBox1);
            this.contentPanel.Controls.Add(this.lblTotal);
            this.contentPanel.Controls.Add(this.lblSubtotal);
            this.contentPanel.Controls.Add(this.lblPaymentMethod);
            this.contentPanel.Controls.Add(this.lblOrderSummary);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 392);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(300, 208);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(17, 163);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(127, 31);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: 0.0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click_2);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(17, 132);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(164, 31);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Sub total: 0.0";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click_2);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(18, 88);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(237, 28);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "PAYMENT METHOD :";
            this.lblPaymentMethod.Click += new System.EventHandler(this.lblPaymentMethod_Click_2);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderSummary.Location = new System.Drawing.Point(17, 9);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(226, 32);
            this.lblOrderSummary.TabIndex = 0;
            this.lblOrderSummary.Text = "ORDER SUMMARY";
            this.lblOrderSummary.Click += new System.EventHandler(this.lblOrderSummary_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASH ",
            "CREDIT CARD",
            "E-Wallet"});
            this.comboBox1.Location = new System.Drawing.Point(23, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.logoPic);
            this.Name = "OrderSummary";
            this.Size = new System.Drawing.Size(300, 600);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.separator.ResumeLayout(false);
            this.separator.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
