namespace POS.CASHIER
{
    partial class cashierUI
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
            this.flowLayoutPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.totalContainer = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.headerButtonsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.middleTable = new System.Windows.Forms.TableLayoutPanel();
            this.SIDEBARPANEL = new System.Windows.Forms.Panel();
            this.actionButtonControls1 = new POS.CASHIER.ActionButtonControls();
            this.orderSummary1 = new POS.CASHIER.OrderSummary();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bottomTable.SuspendLayout();
            this.totalContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerTable.SuspendLayout();
            this.headerButtonsFlow.SuspendLayout();
            this.middleTable.SuspendLayout();
            this.SIDEBARPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.actionButtonControls1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 235);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.bottomTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 250);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bottomTable
            // 
            this.bottomTable.ColumnCount = 2;
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTable.Controls.Add(this.totalContainer, 0, 0);
            this.bottomTable.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.bottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTable.Location = new System.Drawing.Point(0, 0);
            this.bottomTable.Name = "bottomTable";
            this.bottomTable.RowCount = 1;
            this.bottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTable.Size = new System.Drawing.Size(920, 250);
            this.bottomTable.TabIndex = 2;
            this.bottomTable.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomTable_Paint);
            // 
            // totalContainer
            // 
            this.totalContainer.Controls.Add(this.textBox1);
            this.totalContainer.Controls.Add(this.label1);
            this.totalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalContainer.Location = new System.Drawing.Point(3, 3);
            this.totalContainer.Name = "totalContainer";
            this.totalContainer.Size = new System.Drawing.Size(454, 244);
            this.totalContainer.TabIndex = 0;
            this.totalContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.totalContainer_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 103);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CASH RECIEVED:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(463, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 244);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(227, 122);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 116);
            this.button6.TabIndex = 3;
            this.button6.Text = "F12\r\nPAY";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lavender;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.MediumPurple;
            this.button5.Location = new System.Drawing.Point(0, 122);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 116);
            this.button5.TabIndex = 2;
            this.button5.Text = "F5\r\nNEW ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(227, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 116);
            this.button4.TabIndex = 1;
            this.button4.Text = "F4\r\nVOID";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 116);
            this.button3.TabIndex = 0;
            this.button3.Text = "F3 \r\nHOLD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.headerTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 70);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // headerTable
            // 
            this.headerTable.ColumnCount = 2;
            this.headerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerTable.Controls.Add(this.label2, 0, 0);
            this.headerTable.Controls.Add(this.headerButtonsFlow, 1, 0);
            this.headerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTable.Location = new System.Drawing.Point(0, 0);
            this.headerTable.Name = "headerTable";
            this.headerTable.RowCount = 1;
            this.headerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTable.Size = new System.Drawing.Size(920, 70);
            this.headerTable.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "COP - POINT OF SALE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // headerButtonsFlow
            // 
            this.headerButtonsFlow.Controls.Add(this.button1);
            this.headerButtonsFlow.Controls.Add(this.button2);
            this.headerButtonsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerButtonsFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.headerButtonsFlow.Location = new System.Drawing.Point(463, 3);
            this.headerButtonsFlow.Name = "headerButtonsFlow";
            this.headerButtonsFlow.Padding = new System.Windows.Forms.Padding(0, 8, 10, 0);
            this.headerButtonsFlow.Size = new System.Drawing.Size(454, 64);
            this.headerButtonsFlow.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(304, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(155, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "PRODUCTS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // middleTable
            // 
            this.middleTable.ColumnCount = 2;
            this.middleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.middleTable.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.middleTable.Controls.Add(this.SIDEBARPANEL, 1, 0);
            this.middleTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleTable.Location = new System.Drawing.Point(0, 70);
            this.middleTable.Name = "middleTable";
            this.middleTable.RowCount = 1;
            this.middleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleTable.Size = new System.Drawing.Size(920, 241);
            this.middleTable.TabIndex = 4;
            // 
            // SIDEBARPANEL
            // 
            this.SIDEBARPANEL.Controls.Add(this.orderSummary1);
            this.SIDEBARPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SIDEBARPANEL.Location = new System.Drawing.Point(573, 3);
            this.SIDEBARPANEL.Name = "SIDEBARPANEL";
            this.SIDEBARPANEL.Size = new System.Drawing.Size(344, 235);
            this.SIDEBARPANEL.TabIndex = 1;
            // 
            // actionButtonControls1
            // 
            this.actionButtonControls1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.actionButtonControls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionButtonControls1.Location = new System.Drawing.Point(0, 0);
            this.actionButtonControls1.Name = "actionButtonControls1";
            this.actionButtonControls1.Size = new System.Drawing.Size(564, 235);
            this.actionButtonControls1.TabIndex = 0;
            // 
            // orderSummary1
            // 
            this.orderSummary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderSummary1.Location = new System.Drawing.Point(0, 0);
            this.orderSummary1.Name = "orderSummary1";
            this.orderSummary1.Size = new System.Drawing.Size(344, 235);
            this.orderSummary1.TabIndex = 0;
            // 
            // cashierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 561);
            this.Controls.Add(this.middleTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "cashierUI";
            this.Text = "cashierUI";
            this.Load += new System.EventHandler(this.cashierUI_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bottomTable.ResumeLayout(false);
            this.totalContainer.ResumeLayout(false);
            this.totalContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.headerTable.ResumeLayout(false);
            this.headerTable.PerformLayout();
            this.headerButtonsFlow.ResumeLayout(false);
            this.middleTable.ResumeLayout(false);
            this.SIDEBARPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OrderSummary orderSummary1;
        private System.Windows.Forms.Panel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel bottomTable;
        private System.Windows.Forms.Panel totalContainer;
        private System.Windows.Forms.TableLayoutPanel headerTable;
        private System.Windows.Forms.FlowLayoutPanel headerButtonsFlow;
        private System.Windows.Forms.TableLayoutPanel middleTable;
        private ActionButtonControls actionButtonControls1;
        private System.Windows.Forms.Panel SIDEBARPANEL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}