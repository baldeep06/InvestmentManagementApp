namespace InvestmentManagementApp
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddtoPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStockData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2077, 197);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 832);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(547, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1113, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Investment Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnDelete2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.btnAddtoPort);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btnStockData);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(-21, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 1141);
            this.panel3.TabIndex = 1;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.Location = new System.Drawing.Point(71, 1000);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(375, 78);
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.Text = "Sell Stock";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter # of Shares Below:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 737);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 62);
            this.textBox2.TabIndex = 7;
            // 
            // btnAddtoPort
            // 
            this.btnAddtoPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoPort.Location = new System.Drawing.Point(71, 491);
            this.btnAddtoPort.Name = "btnAddtoPort";
            this.btnAddtoPort.Size = new System.Drawing.Size(368, 82);
            this.btnAddtoPort.TabIndex = 6;
            this.btnAddtoPort.Text = "Fetch Data";
            this.btnAddtoPort.UseVisualStyleBackColor = true;
            this.btnAddtoPort.Click += new System.EventHandler(this.btnAddtoPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Ticker Below:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 62);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnStockData
            // 
            this.btnStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockData.Location = new System.Drawing.Point(79, 820);
            this.btnStockData.Name = "btnStockData";
            this.btnStockData.Size = new System.Drawing.Size(360, 97);
            this.btnStockData.TabIndex = 1;
            this.btnStockData.Text = "Add to Portfolio";
            this.btnStockData.UseVisualStyleBackColor = true;
            this.btnStockData.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 150);
            this.button1.TabIndex = 0;
            this.button1.Text = "Investment Simulator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewStocks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewStocks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shares,
            this.Ticker,
            this.OpenPrice,
            this.ClosePrice});
            this.dataGridViewStocks.Location = new System.Drawing.Point(616, 352);
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.RowHeadersWidth = 123;
            this.dataGridViewStocks.RowTemplate.Height = 46;
            this.dataGridViewStocks.Size = new System.Drawing.Size(1332, 933);
            this.dataGridViewStocks.TabIndex = 2;
            this.dataGridViewStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStocks_CellContentClick);
            // 
            // Shares
            // 
            this.Shares.HeaderText = "# of Shares";
            this.Shares.MinimumWidth = 15;
            this.Shares.Name = "Shares";
            this.Shares.Width = 244;
            // 
            // Ticker
            // 
            this.Ticker.HeaderText = "Ticker";
            this.Ticker.MinimumWidth = 15;
            this.Ticker.Name = "Ticker";
            this.Ticker.Width = 167;
            // 
            // OpenPrice
            // 
            this.OpenPrice.HeaderText = "Open Price";
            this.OpenPrice.MinimumWidth = 15;
            this.OpenPrice.Name = "OpenPrice";
            this.OpenPrice.Width = 239;
            // 
            // ClosePrice
            // 
            this.ClosePrice.HeaderText = "Close Price";
            this.ClosePrice.MinimumWidth = 15;
            this.ClosePrice.Name = "ClosePrice";
            this.ClosePrice.Width = 242;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 73);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Portfolio";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::InvestmentManagementApp.Properties.Resources.stock_market;
            this.ClientSize = new System.Drawing.Size(2059, 1325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewStocks);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStockData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.Button btnAddtoPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticker;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosePrice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Label label4;
    }
}