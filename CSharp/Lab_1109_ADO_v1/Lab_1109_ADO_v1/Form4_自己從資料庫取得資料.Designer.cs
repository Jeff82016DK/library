namespace Lab_1109_ADO_v1
{
    partial class Form4_自己從資料庫取得資料
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
            this.btn = new System.Windows.Forms.Button();
            this.dgvDataTable = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.northwindDataSet1 = new Lab_1109_ADO_v1.NorthwindDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(27, 50);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(295, 93);
            this.btn.TabIndex = 0;
            this.btn.Text = "取得資料";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgvDataTable
            // 
            this.dgvDataTable.AllowUserToAddRows = false;
            this.dgvDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTable.Location = new System.Drawing.Point(46, 194);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.RowHeadersWidth = 51;
            this.dgvDataTable.RowTemplate.Height = 27;
            this.dgvDataTable.Size = new System.Drawing.Size(583, 197);
            this.dgvDataTable.TabIndex = 1;
            this.dgvDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTable_CellContentClick);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(356, 50);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(295, 93);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "修改欄位";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form4_自己從資料庫取得資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 452);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvDataTable);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form4_自己從資料庫取得資料";
            this.Text = "Form4_自己從資料庫取得資料";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataGridView dgvDataTable;
        private System.Windows.Forms.Button btnModify;
        private NorthwindDataSet northwindDataSet1;
    }
}