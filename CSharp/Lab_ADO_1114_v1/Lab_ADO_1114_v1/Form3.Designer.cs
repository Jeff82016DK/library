namespace Lab_ADO_1114_v1
{
    partial class Form3
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Rowstats = new System.Windows.Forms.Button();
            this.btn_Updata = new System.Windows.Forms.Button();
            this.txt_CurrencyKey = new System.Windows.Forms.TextBox();
            this.txt_CurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.txt_CurrencyName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Demo_v1 = new System.Windows.Forms.Button();
            this.btn_Demo_v2 = new System.Windows.Forms.Button();
            this.SQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(41, 37);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(163, 81);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "取得資料";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Rowstats
            // 
            this.btn_Rowstats.Location = new System.Drawing.Point(220, 37);
            this.btn_Rowstats.Name = "btn_Rowstats";
            this.btn_Rowstats.Size = new System.Drawing.Size(159, 81);
            this.btn_Rowstats.TabIndex = 0;
            this.btn_Rowstats.Text = "狀態";
            this.btn_Rowstats.UseVisualStyleBackColor = true;
            this.btn_Rowstats.Click += new System.EventHandler(this.btn_Rowstats_Click);
            // 
            // btn_Updata
            // 
            this.btn_Updata.Location = new System.Drawing.Point(413, 37);
            this.btn_Updata.Name = "btn_Updata";
            this.btn_Updata.Size = new System.Drawing.Size(162, 81);
            this.btn_Updata.TabIndex = 0;
            this.btn_Updata.Text = "更新";
            this.btn_Updata.UseVisualStyleBackColor = true;
            this.btn_Updata.Click += new System.EventHandler(this.btn_Updata_Click);
            // 
            // txt_CurrencyKey
            // 
            this.txt_CurrencyKey.Location = new System.Drawing.Point(41, 182);
            this.txt_CurrencyKey.Name = "txt_CurrencyKey";
            this.txt_CurrencyKey.Size = new System.Drawing.Size(195, 43);
            this.txt_CurrencyKey.TabIndex = 1;
            // 
            // txt_CurrencyAlternateKey
            // 
            this.txt_CurrencyAlternateKey.Location = new System.Drawing.Point(286, 182);
            this.txt_CurrencyAlternateKey.Name = "txt_CurrencyAlternateKey";
            this.txt_CurrencyAlternateKey.Size = new System.Drawing.Size(206, 43);
            this.txt_CurrencyAlternateKey.TabIndex = 1;
            // 
            // txt_CurrencyName
            // 
            this.txt_CurrencyName.Location = new System.Drawing.Point(546, 182);
            this.txt_CurrencyName.Name = "txt_CurrencyName";
            this.txt_CurrencyName.Size = new System.Drawing.Size(203, 43);
            this.txt_CurrencyName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(492, 464);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(574, 266);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(409, 464);
            this.textBox4.TabIndex = 3;
            // 
            // btn_Demo_v1
            // 
            this.btn_Demo_v1.Location = new System.Drawing.Point(609, 37);
            this.btn_Demo_v1.Name = "btn_Demo_v1";
            this.btn_Demo_v1.Size = new System.Drawing.Size(162, 81);
            this.btn_Demo_v1.TabIndex = 0;
            this.btn_Demo_v1.Text = "Demo_v1";
            this.btn_Demo_v1.UseVisualStyleBackColor = true;
            this.btn_Demo_v1.Click += new System.EventHandler(this.btn_Demo_v1_Click);
            // 
            // btn_Demo_v2
            // 
            this.btn_Demo_v2.Location = new System.Drawing.Point(795, 37);
            this.btn_Demo_v2.Name = "btn_Demo_v2";
            this.btn_Demo_v2.Size = new System.Drawing.Size(162, 81);
            this.btn_Demo_v2.TabIndex = 0;
            this.btn_Demo_v2.Text = "Demo_v2";
            this.btn_Demo_v2.UseVisualStyleBackColor = true;
            this.btn_Demo_v2.Click += new System.EventHandler(this.btn_Demo_v2_Click);
            // 
            // SQL
            // 
            this.SQL.Location = new System.Drawing.Point(971, 37);
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(162, 81);
            this.SQL.TabIndex = 0;
            this.SQL.Text = "SQL";
            this.SQL.UseVisualStyleBackColor = true;
            this.SQL.Click += new System.EventHandler(this.SQL_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 742);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_CurrencyName);
            this.Controls.Add(this.txt_CurrencyAlternateKey);
            this.Controls.Add(this.txt_CurrencyKey);
            this.Controls.Add(this.SQL);
            this.Controls.Add(this.btn_Demo_v2);
            this.Controls.Add(this.btn_Demo_v1);
            this.Controls.Add(this.btn_Updata);
            this.Controls.Add(this.btn_Rowstats);
            this.Controls.Add(this.btn_Read);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Rowstats;
        private System.Windows.Forms.Button btn_Updata;
        private System.Windows.Forms.TextBox txt_CurrencyKey;
        private System.Windows.Forms.TextBox txt_CurrencyAlternateKey;
        private System.Windows.Forms.TextBox txt_CurrencyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_Demo_v1;
        private System.Windows.Forms.Button btn_Demo_v2;
        private System.Windows.Forms.Button SQL;
    }
}